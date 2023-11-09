using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_In
{
    public partial class AdministrarAutores : Form
    {
        private SqlConnection conn;
        private string sCn;
        public AdministrarAutores()
        {
            InitializeComponent();
            Conexion CnL = new Conexion();
            CnL.Conec();
            sCn = CnL.cadena;

            conn = new SqlConnection(sCn);
        }
        private void limpiar()
        {
            conn.Open();
            string query = "SELECT ISNULL(MAX(escritor_id), 0) + 1 FROM Escritores";
            SqlCommand command = new SqlCommand(query, conn);

            int nuevoID = (int)command.ExecuteScalar();
            conn.Close();

            txtId.Text = nuevoID.ToString();
            txtNombre.Clear();
            txtPais.Clear();
            dtpFecha.DataBindings.Clear();
            
        }
        private void actualizar_grid(SqlConnection cnx)
        {
            string consulta = "select * from Escritores";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dvgEscritores.DataSource = dt;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                string pais = txtPais.Text;
                DateTime fecha = dtpFecha.Value;
                string fechaSql = fecha.ToString("yyyy-MM-dd HH:mm:ss");

                string insertar = String.Format("INSERT INTO Escritores VALUES ('{0}','{1}','{2}','{3}')", id, nombre, pais, fechaSql);
                SqlCommand comando = new SqlCommand(insertar, conn);
                comando.Parameters.AddWithValue("@escritor_id", id);
                comando.Parameters.AddWithValue("@nombre_escritor", nombre);
                comando.Parameters.AddWithValue("@pais", pais);
                comando.Parameters.AddWithValue("@fecha_nacimiento", fechaSql);

                comando.ExecuteNonQuery();

                conn.Close();
                limpiar();
                actualizar_grid(conn);
                MessageBox.Show("Escritor ingresado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AdministrarAutores_Load(object sender, EventArgs e)
        {

            conn.Open();
            string query = "SELECT ISNULL(MAX(escritor_id), 0) + 1 FROM Escritores";
            SqlCommand command = new SqlCommand(query, conn);

            int nuevoID = (int)command.ExecuteScalar();

            txtId.Text = nuevoID.ToString();
            conn.Close();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string id = txtId.Text;
                string nombre = txtNombre.Text;
                string pais = txtPais.Text;
                DateTime fecha = dtpFecha.Value;
                string fechaSql = fecha.ToString("yyyy-MM-dd HH:mm:ss");

                SqlCommand comando = new SqlCommand("UPDATE Escritores SET escritor_id = @id, nombre_escritor = @nombre, pais = @pais, fecha_nacimiento = @fechaSql WHERE escritor_id = @id", conn);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@pais", pais);
                comando.Parameters.AddWithValue("@fechaSql", fechaSql);


                comando.ExecuteNonQuery();

                conn.Close();

                actualizar_grid(conn);
                MessageBox.Show("Escritor modificado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            actualizar_grid(conn);
            limpiar();
        }

        private void dvgEscritores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            int columna = e.ColumnIndex;

            string id = dvgEscritores.Rows[fila].Cells[0].Value.ToString();
            string nombre = dvgEscritores.Rows[fila].Cells[1].Value.ToString();
            string pais = dvgEscritores.Rows[fila].Cells[2].Value.ToString();
            DateTime fecha = (DateTime)dvgEscritores.Rows[fila].Cells[3].Value;

            txtId.Text = id;
            txtNombre.Text = nombre;
            txtPais.Text = pais.ToString();
            dtpFecha.Text = fecha.ToString();
            dtpFecha.Text = fecha.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conn.Open();
            int id = int.Parse(txtId.Text);
            string query = "select max(escritor_id) from Libros where escritor_id = '" + id + "'";
            SqlCommand command = new SqlCommand(query, conn);
            object resultado = command.ExecuteScalar();
            int valor = (int)resultado;
            conn.Close();


            if (id != 0)
            {
                if (id != valor)
                {
                    try
                    {
                        conn.Open();
                        string eliminar = String.Format("DELETE FROM Escritores WHERE escritor_id = '" + id + "'");
                        SqlCommand comando = new SqlCommand(eliminar, conn);
                        comando.ExecuteNonQuery();
                        actualizar_grid(conn);
                        MessageBox.Show("Escritor eliminado exitosamente");
                        conn.Close();
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inesperado: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Este autor no se puede eliminar ya que hay libros que ocupan este autor.");
                }
                
            }
            else
            {
                MessageBox.Show("Por favor seleccione un escritor a eliminar");
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VentanaAdmin form = new VentanaAdmin();
            form.Show();
            this.Hide();
        }
    }
}
