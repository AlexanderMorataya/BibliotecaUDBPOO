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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Log_In
{
    public partial class AdministrarLibros : Form
    {
        private SqlConnection conn;
        private string sCn;
        public AdministrarLibros()
        {
            InitializeComponent();
            Conexion CnL = new Conexion();
            CnL.Conec();
            sCn = CnL.cadena;

            conn = new SqlConnection(sCn);
        }
        //funcion para limpir los campos y actualizar nuevo ID
        private void limpiar()
        {
            conn.Open();
            string query = "SELECT ISNULL(MAX(libro_id), 0) + 1 FROM Libros";
            SqlCommand command = new SqlCommand(query, conn);

            int nuevoID = (int)command.ExecuteScalar();
            txtId.Text = nuevoID.ToString();
            conn.Close();

            txtId.Text = nuevoID.ToString();
            txtTitulo.Clear();
            cbAutor.SelectedIndex = -1;
            txtGenero.Clear();
            dtpFecha.DataBindings.Clear();
            txtRenta.Clear();
            txtVenta.Clear();
            cbDisponible.SelectedIndex = -1;
        }
        //funcion para actualizar combobox de autores
        private void actualizarCB()
        {
            cbAutor.Items.Clear();
            conn.Open();
            string sqlQuery = "select * from Escritores";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbAutor.Items.Add(reader["nombre_escritor"].ToString());
            }
            reader.Close();
            conn.Close();
        }
        //funcion para actualizar los datos de datagriedview
        private void actualizar_grid(SqlConnection cnx)
        {
            string consulta = "select libro_id, precio_renta, precio_venta, nombre_libro, genero, year, Escritores.nombre_escritor, disponible from Libros join Escritores on Escritores.escritor_id=Libros.escritor_id";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvLibros.DataSource = dt;
        }
        //funcion para actualizar los datos del datagried view segun lo ingesado para el boton de buscar
        private void actualizar_grid(string consulta, SqlConnection cnx)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvLibros.DataSource = dt;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                
                int id = int.Parse(txtId.Text);
                string titulo = txtTitulo.Text;
                string genero = txtGenero.Text;
                string autor = cbAutor.Text;
                DateTime fecha = dtpFecha.Value;
                string fechaSql = fecha.ToString("yyyy-MM-dd HH:mm:ss");
                decimal precioV = Convert.ToDecimal(txtVenta.Text);
                decimal precioR = Convert.ToDecimal(txtRenta.Text);
                string disponible = cbDisponible.Text;

                string query = "SELECT escritor_id FROM Escritores WHERE nombre_escritor = @Autor";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Autor", autor);
                object resultado = command.ExecuteScalar();
                int idautor = (int)resultado;


                string insertar = String.Format("INSERT INTO Libros VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", id, precioV, precioR, titulo, genero, fechaSql, disponible, idautor);
                SqlCommand comando = new SqlCommand(insertar, conn);
                comando.Parameters.AddWithValue("@libro_id", id);
                comando.Parameters.AddWithValue("@precio_venta", precioV);
                comando.Parameters.AddWithValue("@precio_renta", precioR);
                comando.Parameters.AddWithValue("@nombre_libro", titulo);
                comando.Parameters.AddWithValue("@genero", genero);
                comando.Parameters.AddWithValue("@year", fechaSql);
                comando.Parameters.AddWithValue("@disponible", disponible);
                comando.Parameters.AddWithValue("@escritor_id", idautor);

                comando.ExecuteNonQuery();

                conn.Close();
                actualizarCB();
                limpiar();
                actualizar_grid(conn);
                MessageBox.Show("Libro ingresado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AdministrarLibros_Load(object sender, EventArgs e)
        {
            //se carga nuevo ID al cargar el formulario
            conn.Open();
            string query = "SELECT ISNULL(MAX(libro_id), 0) + 1 FROM Libros";
            SqlCommand command = new SqlCommand(query, conn);

            int nuevoID = (int)command.ExecuteScalar();
            txtId.Text = nuevoID.ToString();
            conn.Close();
            actualizarCB();
            limpiar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int id = int.Parse(txtId.Text);
                string titulo = txtTitulo.Text;
                string genero = txtGenero.Text;
                string autor = cbAutor.Text;
                DateTime fecha = dtpFecha.Value;
                string fechaSql = fecha.ToString("yyyy-MM-dd HH:mm:ss");
                decimal precioV = Convert.ToDecimal(txtVenta.Text);
                decimal precioR = Convert.ToDecimal(txtRenta.Text);
                string disponible = cbDisponible.Text;

                string query = "SELECT escritor_id FROM Escritores WHERE nombre_escritor = @Autor";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Autor", autor);
                object resultado = command.ExecuteScalar();
                int idautor = (int)resultado;

                SqlCommand comando = new SqlCommand("UPDATE Libros SET libro_id = @id, precio_venta = @precioV, precio_renta = @precioR, nombre_libro = @titulo, genero = @genero, year = @fechaSql, disponible = @disponible, escritor_id = @idautor WHERE libro_id = @id", conn);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@precioV", precioV);
                comando.Parameters.AddWithValue("@precioR", precioR);
                comando.Parameters.AddWithValue("@titulo", titulo);
                comando.Parameters.AddWithValue("@genero", genero);
                comando.Parameters.AddWithValue("@fechaSql", fechaSql);
                comando.Parameters.AddWithValue("@disponible", disponible);
                comando.Parameters.AddWithValue("@idautor", idautor);


                comando.ExecuteNonQuery();

                conn.Close();

                actualizar_grid(conn);
                actualizarCB();
                MessageBox.Show("Libro modificado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLibros.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtRenta.Text = row.Cells[1].Value.ToString();
                txtVenta.Text = row.Cells[2].Value.ToString();
                txtTitulo.Text = row.Cells[3].Value.ToString();
                txtGenero.Text = row.Cells[4].Value.ToString();
                dtpFecha.Value = DateTime.Parse(row.Cells[5].Value.ToString());
                cbAutor.Text = row.Cells[6].Value.ToString();
                cbDisponible.Text = row.Cells[7].Value.ToString();
            }
            actualizarCB();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            actualizar_grid(conn);
            actualizarCB();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            if (id != "")
            {
                try
                {
                    conn.Open();
                    string eliminar = String.Format("DELETE FROM Libros WHERE libro_id = '" + id + "'");
                    SqlCommand comando = new SqlCommand(eliminar, conn);
                    comando.ExecuteNonQuery();
                    actualizar_grid(conn);
                    MessageBox.Show("Libro eliminado exitosamente");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un libro a eliminar");
            }
            actualizarCB();
            limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            actualizarCB();
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string id = txtId.Text;
            string nombre = txtTitulo.Text;
            string buscar = String.Format("select libro_id, precio_renta, precio_venta, nombre_libro, genero, year, Escritores.nombre_escritor, disponible from Libros " +
                "join Escritores on Escritores.escritor_id=Libros.escritor_id WHERE libro_id = '{0}' OR " + " nombre_libro= '{1}'", id, nombre);
            actualizar_grid(buscar, conn);
            conn.Close();
            limpiar();
        }
    }
}
