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
    public partial class VenderLibros : Form
    {
        private string sCn;
        private SqlConnection conn;
        public VenderLibros()
        {
            InitializeComponent();
            Conexion CnL = new Conexion();
            CnL.Conec();
            sCn = CnL.cadena;

            conn = new SqlConnection(sCn);
            try { conn.Open(); }
            catch {
                MessageBox.Show("Ocurrio un error");
            }
            global.couldBeClosed= false;
        }

        private void TBBuscarLibros_MouseEnter(object sender, EventArgs e)
        {
            TBBuscarLibros.Text = TBBuscarLibros.Text;
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

        private void ResultPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            global.nombre_libro = label.Text;
            string id_libro = label.Tag.ToString().Split(' ')[0].Trim();
            float precioLibro = float.Parse(label.Tag.ToString().Split(' ')[1].Trim());
            global.id_libro = id_libro;
            global.precio = precioLibro;
            VenderLibros2 venderLibros2 = new VenderLibros2();
            venderLibros2.Show();

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
                        label.Tag = reader["libro_id"].ToString() +" "+ reader["precio_venta"];
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
                label.AutoSize= true;
                label.Location = new Point(10, 10);
                ResultPanel.Controls.Add(label);
            }
        }
    }
    public class global
    {
        public static string id_libro; //
        public static float precio;//
        public static string nombre_libro;//
        public static string nombre;//
        public static string id_cliente;//
        public static string total;//
        public static string cambio;//
        public static string id_venta;
        public static bool couldBeClosed= false;
    }
}

