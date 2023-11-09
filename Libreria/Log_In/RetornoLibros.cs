using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_In
{
    public partial class RetornoLibros : Alquilar_Libros
    {
        //creacion de strin usuario donde se guardara la 
        //identificacion del usuario del programa
        private string usuario = "";
        //creacion de la conexion a la base de datos
        private SqlConnection conn;
        private string sCn;
        public RetornoLibros()
        {
            txtCodigo_Libro.ReadOnly = false;
            InitializeComponent();
            Conexion CnL = new Conexion();
            CnL.Conec();
            sCn = CnL.cadena;

            conn = new SqlConnection(sCn);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public RetornoLibros(string usuario_id)
        {
            txtCodigo_Libro.ReadOnly = false;
            InitializeComponent();
            Conexion CnL = new Conexion();
            CnL.Conec();
            sCn = CnL.cadena;

            conn = new SqlConnection(sCn);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            usuario = usuario_id;
        }
        //En caso de que el usuario desee salir del programa
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Las siguiente funcion verifica el contenido de los campos de la form
        private bool verificar_contenido1()
        {
            bool continuar = true;
            string dui = txtDUI.Text;
            if (dui.Length != 9)
            {
                MessageBox.Show("Error el dui tiene que tener unicamente 9 numeros");
                continuar = false;
            }

            for (int i = 0; i < dui.Length; i++)
            {
                if (!char.IsDigit(dui[i]))
                {
                    MessageBox.Show("Error el dui tiene que tener unicamente 9 numeros");
                    continuar = false;
                }
            }
            for (int i = 0; i<txt_codigo_alquiler.Text.Length;i++)
            {
                if(!char.IsDigit(txt_codigo_alquiler.Text[i]))
                {
                    MessageBox.Show("Error el codigo de alquiler tiene que tener unicamente numeros");
                    continuar = false;
                }
            }
            return continuar;
        }
        
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            //Verificamos si todos los campos de la form estan llenados correctamente
            if (verificar_contenido1())
            {
                //Confirmamos la existencia de este prestamo
                string query1 = "SELECT fecha_entrega,fecha_de_prestamo,libro_id FROM Prestamos " +
                    "WHERE prestamos_id = @idprestamo AND cliente=@dui";
                SqlCommand command1 = new SqlCommand(query1, conn);
                command1.Parameters.AddWithValue("@idprestamo", txt_codigo_alquiler.Text);
                command1.Parameters.AddWithValue("@dui", txtDUI.Text);
                try
                {
                    SqlDataReader reader1 = command1.ExecuteReader();
                    if(reader1.HasRows)
                    {
                        //Verificamos si el libro prestado no ha sido devuelto
                        DateTime fecha_prestamo = new DateTime();
                        int dias_retraso = 0;
                        string libro_id = "";
                        string fecha_entrega = "";
                        while (reader1.Read())
                        {
                            fecha_entrega = reader1[0].ToString();
                            fecha_prestamo = DateTime.Parse(reader1[1].ToString());
                            libro_id = reader1[2].ToString();
                        }
                        //Si el libro no ha sido devuelto entonces si fecha de entrega sigue siendo NULL
                        if (fecha_entrega=="")
                        {
                            //Se verifica si el libro fue devuelto a tiempo
                            if (fecha_prestamo.AddDays(14) < DateTime.Now)
                            {
                                dias_retraso = (DateTime.Now - fecha_prestamo.AddDays(14)).Days;
                            }
                            //Se calcula la mora y se actualiza el estado del prestamo
                            double mora = dias_retraso * 1.5;
                            string query2 = "UPDATE Prestamos SET demora=@Mora,fecha_entrega=@Fecha_devolucion WHERE prestamos_id=@id";
                            SqlCommand command2 = new SqlCommand(query2, conn);
                            command2.Parameters.AddWithValue("@Mora", mora);
                            command2.Parameters.AddWithValue("@Fecha_devolucion", DateTime.Now.ToString("MM-dd-yyyy"));
                            command2.Parameters.AddWithValue("@id", txt_codigo_alquiler.Text);
                            try
                            {
                                command2.ExecuteNonQuery();
                                //Se le presenta al usuario la mora a pagar
                                txtcosto.Text = mora.ToString();
                                //Se revisa si el libro se encuentra disponible o no
                                string query3 = "UPDATE Libros SET disponible='disponible' WHERE libro_id=@id";
                                SqlCommand command3 = new SqlCommand(query3, conn);
                                command3.Parameters.AddWithValue("@id", libro_id);
                                try
                                {
                                    //Se le informa al usuario que el proceso fue realizado exitosamente
                                    command3.ExecuteNonQuery();
                                    MessageBox.Show("Proceso realizado correctamente");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Ocurrio un error inesperado al momento de cambiar el estado actual del libro: " + ex.Message);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ocurrio un error inesperado al momento de registrar la entrega: " + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Este libro ya ha sido devuelto");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El prestamo indicado no esta registrado");
                        txtDUI.Text = "";
                        txt_codigo_alquiler.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error inesperado al momento de buscar el registro del prestamo " +
                            "con el DUI ingresado: " + ex.Message);
                }
                txtDUI.Text = "";
                txt_codigo_alquiler.Text = "";
            }
        }
    }
}
