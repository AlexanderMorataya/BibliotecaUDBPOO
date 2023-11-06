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
    public partial class AdministrarGanancias : Form
    {
        private SqlConnection conn;
        private string sCn;
        public AdministrarGanancias()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            conexion.Conec();

            sCn = conexion.cadena;
            conn = new SqlConnection(sCn);
        }
        //PROGRAMACION DE CARGA DE PROGRAMA
        private void AdministrarGanancias_Load(object sender, EventArgs e)
        {
            CbMes.Items.Clear();
            CbMes.Items.Add("Enero");
            CbMes.Items.Add("Febrero");
            CbMes.Items.Add("Marzo");
            CbMes.Items.Add("Abril");
            CbMes.Items.Add("Mayo");
            CbMes.Items.Add("Junio");
            CbMes.Items.Add("Julio");
            CbMes.Items.Add("Agosto");
            CbMes.Items.Add("Septiembre");
            CbMes.Items.Add("Octubre");
            CbMes.Items.Add("Noviembre");
            CbMes.Items.Add("Diciembre");
            CbTransaccion.Items.Clear();
            CbTransaccion.Items.Add("Ventas");
            CbTransaccion.Items.Add("Alquileres");
            CbTransaccion.Items.Add("Reservas");

        }

        //PROGRAMACION DE BOTONES
        private void BtnCloseProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnCargarDatos_Click(object sender, EventArgs e)
        {

        }
        private void BtnRestrablecer_Click(object sender, EventArgs e)
        {
            CbMes.SelectedItem = null;
            CbTransaccion.SelectedItem = null;
        }

        //METODOS UTILIZADOS POR EL PROGRAMA
        private void CargarDgv()
        {

        }

        private void CargarVentas(string mes)
        {

        }


    }
}
