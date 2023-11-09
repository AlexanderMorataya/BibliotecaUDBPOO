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
    public partial class VentanaAdmin : Form
    {
        private SqlConnection conn;
        private string sCn;
        public VentanaAdmin()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            conexion.Conec();

            sCn = conexion.cadena;
            conn = new SqlConnection(sCn);
        }
        //PROGRAMACION DE CARGA DEL PROGRAMA
        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            GraficoSeleccionar(seleccion);
            CbFiltro.SelectedIndex = 0;
        }

        //PROGRAMACION DE BOTONBES Y TEXTBOX
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        private void BtnLibros_Click(object sender, EventArgs e)
        {
            seleccion = 1;
            CbFiltro.SelectedIndex = 0;
            GraficoSeleccionar(seleccion);
        }

        private void BtnEscritores_Click(object sender, EventArgs e)
        {
            seleccion = 2;
            CbFiltro.SelectedIndex = 0;
            GraficoSeleccionar(seleccion);
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            seleccion = 3;
            CbFiltro.SelectedIndex = 0;
            GraficoSeleccionar(seleccion);
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            seleccion = 4;
            CbFiltro.SelectedIndex = 0;
            GraficoSeleccionar(seleccion);
        }

        private void BtnAdministrarAutores_Click(object sender, EventArgs e)
        {
            AdministrarAutores form = new AdministrarAutores();
            form.ShowDialog();
        }

        private void BtnAdministrarLibros_Click(object sender, EventArgs e)
        {
            AdministrarLibros form = new AdministrarLibros();
            form.ShowDialog();
        }

        private void BtnGanancias_Click(object sender, EventArgs e)
        {
            AdministrarGanancias form = new AdministrarGanancias();
            form.ShowDialog();
        }

        private void BtnCloseProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //METODOS UTILIZADOS POR EL PROGRAMA
        private int seleccion = 1;
        private void GraficoSeleccionar(int select)
        {
            if(select == 1)
            {
                PbLibros.BackColor = Color.White;
                PbEscritores.BackColor = Color.Transparent;
                PbEmpleados.BackColor = Color.Transparent;
                PbClientes.BackColor = Color.Transparent;
                CbFiltro.Items.Clear();
                CbFiltro.Items.Add("ID");
                CbFiltro.Items.Add("Nombre");
                CbFiltro.Items.Add("Genero");
                CbFiltro.Items.Add("Autor");
            }
            else if(select == 2)
            {
                PbLibros.BackColor = Color.Transparent;
                PbEscritores.BackColor = Color.White;
                PbEmpleados.BackColor = Color.Transparent;
                PbClientes.BackColor = Color.Transparent;
                CbFiltro.Items.Clear();
                CbFiltro.Items.Add("ID");
                CbFiltro.Items.Add("Nombre");
                CbFiltro.Items.Add("Pais");
                CbFiltro.Items.Add("Nacimiento");
            }
            else if(select == 3)
            {
                PbLibros.BackColor = Color.Transparent;
                PbEscritores.BackColor = Color.Transparent;
                PbEmpleados.BackColor = Color.White;
                PbClientes.BackColor = Color.Transparent;
                CbFiltro.Items.Clear();
                CbFiltro.Items.Add("ID");
                CbFiltro.Items.Add("Nombre");
                CbFiltro.Items.Add("DUI");
                CbFiltro.Items.Add("Posicion");
            }
            else if(select == 4)
            {
                PbLibros.BackColor = Color.Transparent;
                PbEscritores.BackColor = Color.Transparent;
                PbEmpleados.BackColor = Color.Transparent;
                PbClientes.BackColor = Color.White;
                CbFiltro.Items.Clear();
                CbFiltro.Items.Add("ID");
                CbFiltro.Items.Add("Nombre");
                CbFiltro.Items.Add("Correo");
            }
        }       

        //PROGRAMACION DE COMPORTAMIENTOS Y EVENTOS DE PROGRAMAS
        private void BtnGanancias_MouseHover(object sender, EventArgs e)
        {
            PbAdministrarGanancias.BackColor = Color.FromArgb(118, 58, 99);
        }
        private void BtnGanancias_MouseLeave(object sender, EventArgs e)
        {
            PbAdministrarGanancias.BackColor = Color.Transparent;
        }
        private void BtnAdministrarAutores_MouseHover(object sender, EventArgs e)
        {
            PbAdministrarAutores.BackColor = Color.FromArgb(118, 58, 99);
        }
        private void BtnAdministrarAutores_MouseLeave(object sender, EventArgs e)
        {
            PbAdministrarAutores.BackColor = Color.Transparent;
        }
        private void BtnAdministrarLibros_MouseHover(object sender, EventArgs e)
        {
            PbAdministrarLibros.BackColor = Color.FromArgb(118, 58, 99);
        }
        private void BtnAdministrarLibros_MouseLeave(object sender, EventArgs e)
        {
            PbAdministrarLibros.BackColor = Color.Transparent;
        }


    }
}
