using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Log_In
{
    public partial class LibrosPrestados : Form
    {
        SqlConnection conn;
        string sCn;
        public LibrosPrestados()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            conexion.Conec();
            sCn = conexion.cadena;
            conn = new SqlConnection(sCn);

        }

        private void LibrosPrestados_Load(object sender, EventArgs e)
        {
            string[] columnas = { "Libro", "Genero", "Año", "Escritor", "Pais", "Fecha del Prestamo", "Fecha de entrega", "Clienta" };
            foreach(string x in columnas) 
            {
                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = x;
                dataGridView1.Columns.Add(columna);
            }

            try
            {
                conn.Open();
                string query = "select nombre_libro, genero, year, nombre_escritor, pais, fecha_de_prestamo, fecha_entrega,  nombre as nombre_cliente from Escritores inner join libros on Escritores.escritor_id = Libros.escritor_id inner join Prestamos on Libros.libro_id = Prestamos.prestamos_id inner join Cliente on Prestamos.cliente = Cliente.cliente_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string nombre_libro = reader["nombre_libro"].ToString();
                        string genero = reader["genero"].ToString();
                        string year = reader["year"].ToString();
                        string nombre_escritor = reader["nombre_escritor"].ToString();
                        string pais = reader["pais"].ToString();
                        string fecha_prestamo = reader["fecha_de_prestamo"].ToString();
                        string fecha_entrega = reader["fecha_entrega"].ToString();
                        string nombre_cliente = reader["nombre_cliente"].ToString();
                        dataGridView1.Rows.Add(nombre_libro, genero, year, nombre_escritor, pais, fecha_prestamo, fecha_entrega, nombre_cliente);
                    }
                }
                else
                {
                    MessageBox.Show("No hay prestamos aun");
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }

        }
    }
}
