using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_In
{
    public partial class FacturaDeVentaLibros : Form
    {
        public FacturaDeVentaLibros()
        {
            InitializeComponent();
            IdVenta.Text += global.id_venta;
            Nombre.Text += global.nombre;
            IdCliente.Text += global.id_cliente;
            NombreLibro.Text += global.nombre_libro;
            Precio.Text += global.precio;
            Recibido.Text += global.total;
            Cambio.Text += global.cambio;
            DateTime fecha= DateTime.Now;
            Fecha.Text += fecha.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            global.couldBeClosed = true;
            this.Close();
        }
    }
}
