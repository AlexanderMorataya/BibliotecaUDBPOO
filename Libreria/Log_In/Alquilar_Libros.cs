<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Collections;

namespace Log_In
{
    public partial class Alquilar_Libros : Form
    {
        //creacion de strin usuario donde se guardara la 
        //identificacion del usuario del programa
        private string usuario = "";
        //creacion de la conexion a la base de datos
        private SqlConnection conn;
        private string sCn;
        public Alquilar_Libros()
        {
            InitializeComponent();
            Conexion CnL = new Conexion();
            CnL.Conec();
            sCn = CnL.cadena;

            conn = new SqlConnection(sCn);
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Alquilar_Libros(string usuario_id)
        {
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
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Eventos cuando el usuario quiere generar su codigo de alquiler
        private void btn_generar_Click(object sender, EventArgs e)
        {
            //En el caso de que el cliente ya este registrado en el sistema
            if (rb_primera_vez.Checked == false && rbtn_reserva.Checked==false)
            {
                //Verificacion de la validez del contenido de la form
                if(verificar_contenido1())
                {
                    //Verificacion de la disponibilidad del libro
                    if (verificar_disponibilidad(txtCodigo_Libro.Text))
                    {
                        //Verificacion que el cliente este registrado en el sistema
                        string query1 = "SELECT [cliente_id] FROM Cliente WHERE [cliente_id] = @DUI";
                        SqlCommand command1 = new SqlCommand(query1, conn);
                        command1.Parameters.AddWithValue("@DUI", txtDUI.Text);
                        try
                        {
                            SqlDataReader reader = command1.ExecuteReader();
                            if (reader.HasRows) 
                            {
                                //Llamada a la funcion actualizar para actualizar la base de datos y mostrar la informacion 
                                //en la form
                                actualizar(txtDUI.Text, txtCodigo_Libro.Text);
                            }
                            else
                            {
                                MessageBox.Show("Cliente no registrado");
                                txtDUI.Text = "";
                            }
                        }
                        //Catch en caso de encontrar errores al momento de verificar si el cliente 
                        //esta registrado en el sistema
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrio un error inesperado al momento de buscar el cliente " +
                                    "con el DUI ingresado: " + ex.Message);
                        }
                    }
                }
            }
            //En caso de que sea un nuevo cliente
            else if (rb_primera_vez.Checked == true)
            {
                //Verificacion del contenido de la form
                if(verificar_contenido2())
                {
                    //Insercion del nuevo cliente en la base de datos
                    string nombre = txtNombre.Text + " " + txtApellido;
                    DateTime date = dtp_fecha_nacimiento.Value;
                    string query1 = "INSERT INTO Cliente(cliente_id,nombre,telefono,correo,fecha_nacimiento) VALUES" +
                        "(@DUI,@nombre,@tele,@correo,@fecha)";
                    SqlCommand command1 = new SqlCommand(query1, conn);
                    command1.Parameters.AddWithValue("@DUI", txtDUI.Text);
                    command1.Parameters.AddWithValue("@nombre", nombre);
                    command1.Parameters.AddWithValue("@tele", txtTelefono.Text);
                    command1.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    command1.Parameters.AddWithValue("@fecha", date.ToString("MM-dd-yyyy"));
                    try
                    {
                        command1.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error inesperado al momento de registrar el cliente: " + ex.Message);
                    }
                    //Llamada a la funcion actualizar
                    actualizar(txtDUI.Text, txtCodigo_Libro.Text);
                }
            }
            else if (rbtn_reserva.Checked == true)
            {
                //Verificamos la validez del contenido
                if(verificar_contenido3())
                {
                    //Verificamos si el codigo de reserva deigitado existe
                    string query1 = "SELECT libro_id,cliente FROM Reserva WHERE reserva_id=@cod";
                    SqlCommand command1 = new SqlCommand(query1, conn);
                    command1.Parameters.AddWithValue("@cod", txtReserva.Text);
                    try
                    {
                        SqlDataReader reader1 = command1.ExecuteReader();
                        if(reader1.HasRows)
                        {
                            string cliente = "";
                            string id_libro = "";
                            while (reader1.Read())
                            {
                                id_libro = reader1[0].ToString();
                                cliente = reader1[1].ToString();
                            }
                            //Llamada a la funcion actualizar
                            actualizar(cliente, id_libro);
                        }
                        else
                        {
                            MessageBox.Show("El codigo de reserva no esta registrada");
                            txtReserva.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error inesperado al momento de buscar la reserva " +
                                "con el DUI ingresado: " + ex.Message);
                    }
                }
            }
            //Limpieza de los campos donde el usuario escribió
            txtApellido.Clear();
            txtCodigo_Libro.Clear();
            txtCorreo.Clear();
            txtDUI.Clear();
            txtNombre.Clear();
            txtReserva.Clear();
            txtTelefono.Clear();
        }
        //Funcion para verificar la disponibilidad del libro
        private bool verificar_disponibilidad(string cod)
        {
            bool continuar = true;
            string query = "SELECT disponible FROM LIBROS WHERE libro_id=@id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", txtCodigo_Libro.Text);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() != "disponible")
                    {
                        continuar = false;
                        MessageBox.Show("El libro cuyo codigo fue ingresado no se encuentra disponible");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al momento de confirmar la disponibiliad del libro: " + ex.Message);
            }
            return continuar;
        }
        //Las siguientes tres funciones son para verificar el contenido de la form en los tres diferentes casos
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
                    continuar= false;
                }
            }
            for (int i = 0; i < txtCodigo_Libro.Text.Length; i++)
            {
                if (!char.IsDigit(txtCodigo_Libro.Text[i]))
                    {
                        MessageBox.Show("Error el codigo del libro tiene que tener unicamente numeros");
                        continuar = false;
                    }
            }
            return continuar;
        }
        private bool verificar_contenido2()
        {
            bool continuar = verificar_contenido1(); //Se hace llamada a la primera funcion para acortar el codigo
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtCorreo.Text;
            string numero = txtTelefono.Text;
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Error: El formato del correo electrónico no es válido.");
                continuar = false;
            }
            if (!Regex.IsMatch(nombre, "^[a-zA-ZáéíóúÁÉÍÓÚ ]+$"))
            {
                MessageBox.Show("Error: El campo nombre solo acepta letras");
                continuar = false;
            }
            if (!Regex.IsMatch(apellido, "^[a-zA-ZáéíóúÁÉÍÓÚ ]+$"))
            {
                MessageBox.Show("Error: El campo apellido solo acepta letras");
                continuar = false;
            }
            for (int i = 0; i < numero.Length; i++)
            {
                if (!char.IsDigit(numero[i]))
                {
                    MessageBox.Show("Error: El campo telefono solo puede llevar numeros.");
                    continuar = false;
                }
            }
            return continuar;
        }
        private bool verificar_contenido3()
        {
            bool continuar = true;
            for(int i= 0; i<txtReserva.Text.Length;i++)
            {
                if (!char.IsDigit(txtReserva.Text[i]))
                {
                    MessageBox.Show("Error: El campo codigo de reserva solo puede llevar numeros.");
                    continuar = false;
                }
            }
            return continuar;
        }

        private void rbtn_reserva_CheckedChanged(object sender, EventArgs e)
        {
            //Se le muestra al usuario donde puede ingresar el codigo de reserva
            // y se deshabilitan las opciones no necesarias
            lbl_codigo_reserva.Show();
            txtReserva.Show();
            lbl_nombre.Enabled= false;
            lbl_telefono.Enabled= false;
            lbl_Dui.Enabled= false;
            lbl_Codigo_libro.Enabled= false;
            lbl_apellido.Enabled= false;
            lbl_fecha_nacimiento.Enabled= false;
            lbl_correo.Enabled= false;
            txtApellido.Enabled= false;
            txtCodigo_Libro.Enabled= false;
            txtCorreo.Enabled= false;
            txtDUI.Enabled= false;
            txtNombre.Enabled= false;
            txtTelefono.Enabled= false;
            dtp_fecha_nacimiento.Enabled = false;
        }

        private void rb_primera_vez_CheckedChanged(object sender, EventArgs e)
        {
            //Se le habilitan todas las opciones necesarias para ingresar un nuevo cliente
            txtDUI.Enabled = true;
            lbl_Dui.Enabled = true;
            lbl_Codigo_libro.Enabled = true;
            lbl_nombre.Enabled = true;
            lbl_telefono.Enabled = true;
            lbl_fecha_nacimiento.Enabled = true;
            lbl_Codigo_libro.Enabled = true;
            lbl_apellido.Enabled = true;
            lbl_correo.Enabled = true;
            txtApellido.Enabled = true;
            txtCodigo_Libro.Enabled = true;
            txtCorreo.Enabled = true;
            txtNombre.Enabled = true;
            dtp_fecha_nacimiento.Enabled = true;
            txtTelefono.Enabled = true;
        }
        //Funcion para actualizar la base de datos
        private void actualizar(string dui,string codigo_libro)
        {
            //Se ingresa la informacion del prestamo
            string query2 = "INSERT INTO Prestamos(libro_id,cliente,fecha_de_prestamo,empleado_atendiende) VALUES " +
                                            "(@idlibro,@dui,@fecha_hoy,@empleado)";
            SqlCommand command2 = new SqlCommand(query2, conn);
            command2.Parameters.AddWithValue("@idlibro", codigo_libro);
            command2.Parameters.AddWithValue("@dui", dui);
            command2.Parameters.AddWithValue("@fecha_hoy", DateTime.Now.ToString("MM-dd-yyyy"));
            command2.Parameters.AddWithValue("@empleado", usuario);
            try
            {
                //Se busca el costo de prestar este libro
                command2.ExecuteNonQuery();
                string query3 = "SELECT precio_renta FROM Libros WHERE libro_id = @Libroid";
                SqlCommand command3 = new SqlCommand(query3, conn);
                command3.Parameters.AddWithValue("@Libroid", codigo_libro);
                try
                {
                    SqlDataReader reader2 = command3.ExecuteReader();
                    while (reader2.Read())
                    {
                        decimal costo = decimal.Parse(reader2[0].ToString());
                        txtcosto.Text = Math.Round(costo,2).ToString();
                    }
                    string query4 = "SELECT prestamos_id FROM Prestamos WHERE cliente=@DUI";
                    SqlCommand command4 = new SqlCommand(query4, conn);
                    //Se busca el codigo de alquiler generado automaticamente
                    command4.Parameters.AddWithValue("@DUI", dui);
                    try
                    {
                        SqlDataReader reader3 = command4.ExecuteReader();
                        while (reader3.Read())
                        {
                            txt_codigo_alquiler.Text = reader3[0].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error inesperado al momento de presentar " +
                            "el codigo de alquiler: " + ex.Message);
                    }
                    //Se cambia el estado del libro a presteado
                    string query5 = "UPDATE Libros SET disponible = 'prestado' WHERE libro_id=@idlibro";
                    SqlCommand command5 = new SqlCommand(query5, conn);
                    command5.Parameters.AddWithValue("@idlibro", codigo_libro);
                    try
                    {
                        command5.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error inesperado al momento de actualizar " +
                            "el estado del libro prestado: " + ex.Message);
                    }
                    //Se calcula la fecha de devolucion y se le presenta al usuario
                    dtp_devolucion.Text = DateTime.Now.AddDays(14).ToShortDateString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error inesperado al momento de presentar el costo del prestamo: " +
                        ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado al momento de registar el prestamo: " + ex.Message);
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Collections;

namespace Log_In
{
    public partial class Alquilar_Libros : Form
    {
        //creacion de strin usuario donde se guardara la 
        //identificacion del usuario del programa
        private string usuario = "";
        //creacion de la conexion a la base de datos
        private SqlConnection conn;
        private string sCn;
        public Alquilar_Libros()
        {
            InitializeComponent();
            Conexion CnL = new Conexion();
            CnL.Conec();
            sCn = CnL.cadena;

            conn = new SqlConnection(sCn);
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Alquilar_Libros(string usuario_id)
        {
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
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Eventos cuando el usuario quiere generar su codigo de alquiler
        private void btn_generar_Click(object sender, EventArgs e)
        {
            //En el caso de que el cliente ya este registrado en el sistema
            if (rb_primera_vez.Checked == false && rbtn_reserva.Checked==false)
            {
                //Verificacion de la validez del contenido de la form
                if(verificar_contenido1())
                {
                    //Verificacion de la disponibilidad del libro
                    if (verificar_disponibilidad(txtCodigo_Libro.Text))
                    {
                        //Verificacion que el cliente este registrado en el sistema
                        string query1 = "SELECT [cliente_id] FROM Cliente WHERE [cliente_id] = @DUI";
                        SqlCommand command1 = new SqlCommand(query1, conn);
                        command1.Parameters.AddWithValue("@DUI", txtDUI.Text);
                        try
                        {
                            SqlDataReader reader = command1.ExecuteReader();
                            if (reader.HasRows) 
                            {
                                //Llamada a la funcion actualizar para actualizar la base de datos y mostrar la informacion 
                                //en la form
                                actualizar(txtDUI.Text, txtCodigo_Libro.Text);
                            }
                            else
                            {
                                MessageBox.Show("Cliente no registrado");
                                txtDUI.Text = "";
                            }
                        }
                        //Catch en caso de encontrar errores al momento de verificar si el cliente 
                        //esta registrado en el sistema
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrio un error inesperado al momento de buscar el cliente " +
                                    "con el DUI ingresado: " + ex.Message);
                        }
                    }
                }
            }
            //En caso de que sea un nuevo cliente
            else if (rb_primera_vez.Checked == true)
            {
                //Verificacion del contenido de la form
                if(verificar_contenido2())
                {
                    //Insercion del nuevo cliente en la base de datos
                    string nombre = txtNombre.Text + " " + txtApellido;
                    DateTime date = dtp_fecha_nacimiento.Value;
                    string query1 = "INSERT INTO Cliente(cliente_id,nombre,telefono,correo,fecha_nacimiento) VALUES" +
                        "(@DUI,@nombre,@tele,@correo,@fecha)";
                    SqlCommand command1 = new SqlCommand(query1, conn);
                    command1.Parameters.AddWithValue("@DUI", txtDUI.Text);
                    command1.Parameters.AddWithValue("@nombre", nombre);
                    command1.Parameters.AddWithValue("@tele", txtTelefono.Text);
                    command1.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    command1.Parameters.AddWithValue("@fecha", date.ToString("MM-dd-yyyy"));
                    try
                    {
                        command1.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error inesperado al momento de registrar el cliente: " + ex.Message);
                    }
                    //Llamada a la funcion actualizar
                    actualizar(txtDUI.Text, txtCodigo_Libro.Text);
                }
            }
            else if (rbtn_reserva.Checked == true)
            {
                //Verificamos la validez del contenido
                if(verificar_contenido3())
                {
                    //Verificamos si el codigo de reserva deigitado existe
                    string query1 = "SELECT libro_id,cliente FROM Reserva WHERE reserva_id=@cod";
                    SqlCommand command1 = new SqlCommand(query1, conn);
                    command1.Parameters.AddWithValue("@cod", txtReserva.Text);
                    try
                    {
                        SqlDataReader reader1 = command1.ExecuteReader();
                        if(reader1.HasRows)
                        {
                            string cliente = "";
                            string id_libro = "";
                            while (reader1.Read())
                            {
                                id_libro = reader1[0].ToString();
                                cliente = reader1[1].ToString();
                            }
                            //Llamada a la funcion actualizar
                            actualizar(cliente, id_libro);
                        }
                        else
                        {
                            MessageBox.Show("El codigo de reserva no esta registrada");
                            txtReserva.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error inesperado al momento de buscar la reserva " +
                                "con el DUI ingresado: " + ex.Message);
                    }
                }
            }
            //Limpieza de los campos donde el usuario escribió
            txtApellido.Clear();
            txtCodigo_Libro.Clear();
            txtCorreo.Clear();
            txtDUI.Clear();
            txtNombre.Clear();
            txtReserva.Clear();
            txtTelefono.Clear();
        }
        //Funcion para verificar la disponibilidad del libro
        private bool verificar_disponibilidad(string cod)
        {
            bool continuar = true;
            string query = "SELECT disponible FROM LIBROS WHERE libro_id=@id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", txtCodigo_Libro.Text);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() != "disponible")
                    {
                        continuar = false;
                        MessageBox.Show("El libro cuyo codigo fue ingresado no se encuentra disponible");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al momento de confirmar la disponibiliad del libro: " + ex.Message);
            }
            return continuar;
        }
        //Las siguientes tres funciones son para verificar el contenido de la form en los tres diferentes casos
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
                    continuar= false;
                }
            }
            for (int i = 0; i < txtCodigo_Libro.Text.Length; i++)
            {
                if (!char.IsDigit(txtCodigo_Libro.Text[i]))
                    {
                        MessageBox.Show("Error el codigo del libro tiene que tener unicamente numeros");
                        continuar = false;
                    }
            }
            return continuar;
        }
        private bool verificar_contenido2()
        {
            bool continuar = verificar_contenido1(); //Se hace llamada a la primera funcion para acortar el codigo
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtCorreo.Text;
            string numero = txtTelefono.Text;
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Error: El formato del correo electrónico no es válido.");
                continuar = false;
            }
            if (!Regex.IsMatch(nombre, "^[a-zA-ZáéíóúÁÉÍÓÚ ]+$"))
            {
                MessageBox.Show("Error: El campo nombre solo acepta letras");
                continuar = false;
            }
            if (!Regex.IsMatch(apellido, "^[a-zA-ZáéíóúÁÉÍÓÚ ]+$"))
            {
                MessageBox.Show("Error: El campo apellido solo acepta letras");
                continuar = false;
            }
            for (int i = 0; i < numero.Length; i++)
            {
                if (!char.IsDigit(numero[i]))
                {
                    MessageBox.Show("Error: El campo telefono solo puede llevar numeros.");
                    continuar = false;
                }
            }
            return continuar;
        }
        private bool verificar_contenido3()
        {
            bool continuar = true;
            for(int i= 0; i<txtReserva.Text.Length;i++)
            {
                if (!char.IsDigit(txtReserva.Text[i]))
                {
                    MessageBox.Show("Error: El campo codigo de reserva solo puede llevar numeros.");
                    continuar = false;
                }
            }
            return continuar;
        }

        private void rbtn_reserva_CheckedChanged(object sender, EventArgs e)
        {
            //Se le muestra al usuario donde puede ingresar el codigo de reserva
            // y se deshabilitan las opciones no necesarias
            lbl_codigo_reserva.Show();
            txtReserva.Show();
            lbl_nombre.Enabled= false;
            lbl_telefono.Enabled= false;
            lbl_Dui.Enabled= false;
            lbl_Codigo_libro.Enabled= false;
            lbl_apellido.Enabled= false;
            lbl_fecha_nacimiento.Enabled= false;
            lbl_correo.Enabled= false;
            txtApellido.Enabled= false;
            txtCodigo_Libro.Enabled= false;
            txtCorreo.Enabled= false;
            txtDUI.Enabled= false;
            txtNombre.Enabled= false;
            txtTelefono.Enabled= false;
            dtp_fecha_nacimiento.Enabled = false;
        }

        private void rb_primera_vez_CheckedChanged(object sender, EventArgs e)
        {
            //Se le habilitan todas las opciones necesarias para ingresar un nuevo cliente
            txtDUI.Enabled = true;
            lbl_Dui.Enabled = true;
            lbl_Codigo_libro.Enabled = true;
            lbl_nombre.Enabled = true;
            lbl_telefono.Enabled = true;
            lbl_fecha_nacimiento.Enabled = true;
            lbl_Codigo_libro.Enabled = true;
            lbl_apellido.Enabled = true;
            lbl_correo.Enabled = true;
            txtApellido.Enabled = true;
            txtCodigo_Libro.Enabled = true;
            txtCorreo.Enabled = true;
            txtNombre.Enabled = true;
            dtp_fecha_nacimiento.Enabled = true;
            txtTelefono.Enabled = true;
        }
        //Funcion para actualizar la base de datos
        private void actualizar(string dui,string codigo_libro)
        {
            //Se ingresa la informacion del prestamo
            string query2 = "INSERT INTO Prestamos(libro_id,cliente,fecha_de_prestamo,empleado_atendiende) VALUES " +
                                            "(@idlibro,@dui,@fecha_hoy,@empleado)";
            SqlCommand command2 = new SqlCommand(query2, conn);
            command2.Parameters.AddWithValue("@idlibro", codigo_libro);
            command2.Parameters.AddWithValue("@dui", dui);
            command2.Parameters.AddWithValue("@fecha_hoy", DateTime.Now.ToString("MM-dd-yyyy"));
            command2.Parameters.AddWithValue("@empleado", usuario);
            try
            {
                //Se busca el costo de prestar este libro
                command2.ExecuteNonQuery();
                string query3 = "SELECT precio_renta FROM Libros WHERE libro_id = @Libroid";
                SqlCommand command3 = new SqlCommand(query3, conn);
                command3.Parameters.AddWithValue("@Libroid", codigo_libro);
                try
                {
                    SqlDataReader reader2 = command3.ExecuteReader();
                    while (reader2.Read())
                    {
                        decimal costo = decimal.Parse(reader2[0].ToString());
                        txtcosto.Text = Math.Round(costo,2).ToString();
                    }
                    string query4 = "SELECT prestamos_id FROM Prestamos WHERE cliente=@DUI";
                    SqlCommand command4 = new SqlCommand(query4, conn);
                    //Se busca el codigo de alquiler generado automaticamente
                    command4.Parameters.AddWithValue("@DUI", dui);
                    try
                    {
                        SqlDataReader reader3 = command4.ExecuteReader();
                        while (reader3.Read())
                        {
                            txt_codigo_alquiler.Text = reader3[0].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error inesperado al momento de presentar " +
                            "el codigo de alquiler: " + ex.Message);
                    }
                    //Se cambia el estado del libro a presteado
                    string query5 = "UPDATE Libros SET disponible = 'prestado' WHERE libro_id=@idlibro";
                    SqlCommand command5 = new SqlCommand(query5, conn);
                    command5.Parameters.AddWithValue("@idlibro", codigo_libro);
                    try
                    {
                        command5.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error inesperado al momento de actualizar " +
                            "el estado del libro prestado: " + ex.Message);
                    }
                    //Se calcula la fecha de devolucion y se le presenta al usuario
                    dtp_devolucion.Text = DateTime.Now.AddDays(14).ToShortDateString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error inesperado al momento de presentar el costo del prestamo: " +
                        ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado al momento de registar el prestamo: " + ex.Message);
            }
        }
    }
}
>>>>>>> d7a5a40ee28cc31d040a0fe9224ae5e7c0545190
