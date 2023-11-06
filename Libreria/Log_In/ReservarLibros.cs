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
    public partial class ReservarLibros : Form
    {
        private string sCn;
        private SqlConnection conn;
        public ReservarLibros()
        {
            InitializeComponent();
            Conexion CnL = new Conexion();
            CnL.Conec();
            sCn = CnL.cadena;
            conn = new SqlConnection(sCn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string query = $"select nombre_libro, libro_id, precio_venta from Libros where nombre_libro like '%{TBBuscarLibros.Text}%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                ResultPanel.Controls.Clear();
                int y = 10;
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string libroNombre = reader["nombre_libro"].ToString();

                        Label label = new Label();
                        label.Text = libroNombre;
                        label.AutoSize = true;
                        label.Tag = reader["libro_id"].ToString() + " " + reader["precio_venta"];
                        label.Click += Label_Click;
                        label.Location = new Point(10, y);
                        ResultPanel.Controls.Add(label);

                        y += label.Height + 5;
                    }

                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No se encontraron libros");
                }

            }
            catch
            {
                Label label = new Label();
                label.Text = "No se encontraron libros";
                label.AutoSize = true;
                label.Location = new Point(10, 10);
                ResultPanel.Controls.Add(label);
            }

        }

        private void TBBuscarLibros_TextChanged(object sender, EventArgs e)
        {
            if (TBBuscarLibros.Text.Length >= 3)
            {
                try
                {

                    string query = $"select nombre_libro, libro_id, precio_venta from Libros where nombre_libro like '%{TBBuscarLibros.Text}%'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    ResultPanel.Controls.Clear();
                    int y = 10;

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string libroNombre = reader["nombre_libro"].ToString();

                            Label label = new Label();
                            label.Text = libroNombre;
                            label.AutoSize = true;
                            label.Click += Label_Click;
                            label.Tag = reader["libro_id"].ToString() + " " + reader["precio_venta"];
                            label.Location = new Point(10, y);
                            ResultPanel.Controls.Add(label);

                            y += label.Height + 5;

                        }

                        reader.Close();


                    }

                    else
                    {
                        MessageBox.Show("No se encontraron Resultados");
                    }
                }

                catch
                {
                    Label label = new Label();
                    label.Text = "No se encontraron libros";
                    label.AutoSize = true;
                    label.Location = new Point(10, 10);
                    ResultPanel.Controls.Add(label);
                    conn.Close();
                    conn.Open();
                }
            }
            else
            {
                ResultPanel.Controls.Clear();
            }
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Glo.NombreLibro = label.Text;
            string id_libro = label.Tag.ToString().Split(' ')[0].Trim();
            float precioLibro = float.Parse(label.Tag.ToString().Split(' ')[1].Trim());
            Glo.libroId = id_libro;
            global.precio = precioLibro;
            ReservarLibros2 reservarLibros2 = new ReservarLibros2();
            reservarLibros2.Show();

        }
    }
    public class Glo
    {
        public static string NombreLibro;
        public static string libroId;
        public static string fechaReserva;
    }
}
