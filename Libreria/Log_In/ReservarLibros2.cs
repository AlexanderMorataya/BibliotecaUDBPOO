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
    public partial class ReservarLibros2 : Form
    {
        private string sCn;
        private SqlConnection conn;
        public ReservarLibros2()
        {
            InitializeComponent();
            Conexion CnL = new Conexion();
            CnL.Conec();
            sCn = CnL.cadena;
            conn = new SqlConnection(sCn);
            UsuarioEstado.Items.Add("Tiene Usuaio");
            UsuarioEstado.Items.Add("No Tiene Usuaio");
            MakeAllNotVisible();
        }
        private void makeIdUserVisible()
        {
            TIdLibro2.Visible = true;
            TIdLibro2.Text = Glo.libroId;
            TIdCliente.Visible = true;
            TPagar2.Visible = true;
            TPrecioLibro2.Visible = true;
            LIdCliente.Visible = true;
            LIdlibro2.Visible = true;
            LPagar2.Visible = true;
            LPrecioLibro2.Visible = true;
            LFechaReserva.Visible = true;
            TPrecioLibro2.Text = "5";
            TFechaReserva.Visible = true;
            BHecho.Visible = true;
        }
        private void MakeAllNotVisible()
        {
            LIdLibro.Visible = false;
            LNombres.Visible = false;
            LApellidos.Visible = false;
            LTelefono.Visible = false;
            LCorreo.Visible = false;
            LFechaNacimiento.Visible = false;
            LPrecioLibro.Visible = false;
            LPagar.Visible = false;
            LIdlibro2.Visible = false;
            LIdCliente.Visible = false;
            LPagar2.Visible = false;
            LPrecioLibro2.Visible = false;
            LDUI.Visible = false;
            LFechaReserva.Visible = false;
            LFechaReserva2.Visible = false;
            //
            TIdLibro.Visible = false;
            TNombre.Visible = false;
            TApellidos.Visible = false;
            TCorreo.Visible = false;
            TTelefono.Visible = false;
            TFechaNacimiento.Visible = false;
            TPrecioLibro.Visible = false;
            TPagar.Visible = false;
            TIdLibro2.Visible = false;
            TIdCliente.Visible = false;
            TPagar2.Visible = false;
            TPrecioLibro2.Visible = false;
            TDUI.Visible = false;
            TFechaReserva.Visible = false;
            TFechaReserva2.Visible = false;
            //
            BHecho.Visible = false;
        }
        private void makeRegisterUserVisible()
        {
            LIdLibro.Visible = true;
            LNombres.Visible = true;
            LApellidos.Visible = true;
            LTelefono.Visible = true;
            LCorreo.Visible = true;
            LFechaNacimiento.Visible = true;
            LPrecioLibro.Visible = true;
            LPagar.Visible = true;
            LDUI.Visible = true;
            TFechaReserva2.Visible = true;
            LFechaReserva2.Visible = true;
            //
            TIdLibro.Visible = true;
            TIdLibro.Text = Glo.libroId;
            TNombre.Visible = true;
            TApellidos.Visible = true;
            TTelefono.Visible = true;
            TCorreo.Visible = true;
            TPrecioLibro.Visible = true;
            TPrecioLibro.Text = "5";
            TFechaNacimiento.Visible = true;
            TPagar.Visible = true;
            TDUI.Visible = true;
            //
            BHecho.Visible = true;
        }
        private bool isFieldEmpty()
        {
            bool validation = true;
            if (TNombre.Text == "")
            {
                errorProvider1.SetError(TNombre, "Ingrese Nombres");
                validation = false;
            }
            if (TApellidos.Text == "")
            {
                errorProvider1.SetError(TApellidos, "Ingrese Nombres");
                validation = false;
            }
            if (TFechaNacimiento.Text == "")
            {
                errorProvider1.SetError(TFechaNacimiento, "Ingrese Fecha de Nacimineto");
                validation = false;
            }
            else
            {
                try
                {
                    string[] fecha = TFechaNacimiento.Text.Split('/');
                    if (fecha.Length == 3)
                    {
                        DateTime fechaNacimiento = new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0]));
                        DateTime fechaActual = DateTime.Now;
                        int edad = fechaActual.Year - fechaNacimiento.Year;

                        if (fechaNacimiento.Month > fechaActual.Month ||
                            (fechaNacimiento.Month == fechaActual.Month && fechaNacimiento.Day > fechaActual.Day))
                        {
                            edad--;
                        }
                        if (edad < 18 && edad >= 0)
                        {
                            errorProvider1.SetError(TFechaNacimiento, "Usted debe ser mayor de edad");
                            validation = false;
                        }
                        if (edad < 0)
                        {
                            errorProvider1.SetError(TFechaNacimiento, "fecha de nacimmiento no valida");
                            validation = false;
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(TFechaNacimiento, "Fecha incompleta");
                        validation = false;
                    }
                }
                catch
                {
                    errorProvider1.SetError(TFechaNacimiento, "Ingrese una fecha de nacimiento valida");
                }

            }
            if (TCorreo.Text == "")
            {
                errorProvider1.SetError(TCorreo, "Ingrese Correo");
                validation = false;
            }
            if (TTelefono.Text == "")
            {
                errorProvider1.SetError(TTelefono, "Ingrese Numero de Telefono");
                validation = false;
            }
            if (TTelefono.Text.Length != 9)
            {
                errorProvider1.SetError(TTelefono, "Numero de telefono no Valido");
                validation = false;
            }
            if (TDUI.Text == "")
            {
                errorProvider1.SetError(TDUI, "Ingrese DUI");
                validation = false;
            }
            if (TDUI.Text.Length != 10)
            {
                errorProvider1.SetError(TDUI, "Numero de DUI no Valido");
                validation = false;
            }
            if (TPagar.Text == "")
            {
                errorProvider1.SetError(TPagar, "Ingrese Un monto");
                validation = false;
            }
            if (TFechaReserva2.Text == "")
            {
                errorProvider1.SetError(TFechaReserva2, "Ingrese una fecha");
            }
            else
            {
                try
                {
                    string[] fecha = TFechaReserva2.Text.Split('/');
                    DateTime fechaReserva = new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0]));
                    DateTime fechaActual = DateTime.Now;
                    int years = fechaReserva.Year - fechaActual.Year;
                    if (fechaActual.Day < fechaReserva.Day && fechaActual.Month <= fechaReserva.Month && fechaActual.Year <= fechaReserva.Year ||
                        fechaActual.Day >= fechaReserva.Day && fechaActual.Month < fechaReserva.Month && fechaActual.Year <= fechaReserva.Year ||
                        fechaActual.Day >= fechaReserva.Day && fechaActual.Month >= fechaReserva.Month && fechaActual.Year < fechaReserva.Year)
                    {

                    }
                    else
                    {
                        errorProvider1.SetError(TFechaReserva2, "Fecha de reserva no valida");
                        validation = false;
                    }
                }
                catch
                {
                    errorProvider1.SetError(TFechaReserva2, "Fecha de reserva no valida");
                    validation = false;
                }
            }
            return validation;

        }

        int back = 0;
        private void TFechaNacimiento_TextChanged(object sender, EventArgs e)
        {
            if (TFechaNacimiento.Text.Length == 2 && back < 1)
            {
                TFechaNacimiento.Text += "/";
                TFechaNacimiento.SelectionStart = TFechaNacimiento.Text.Length;
            }
            if (TFechaNacimiento.Text.Length == 2 && back == 3 || TFechaNacimiento.Text.Length == 2 && back > 3)
            {
                back = 2;
            }
            if (back == 2 && TFechaNacimiento.Text.Length == 3)
            {
                string text = TFechaNacimiento.Text.Substring(0, 2) + "/" + TFechaNacimiento.Text.Substring(2);
                TFechaNacimiento.Text = text;
                TFechaNacimiento.SelectionStart = TFechaNacimiento.Text.Length;
                back = 3;
            }
            if (back < 1 && TFechaNacimiento.Text.Length == 3)
            {
                back = 3;
            }
            //
            if (TFechaNacimiento.Text.Length == 5 && back < 4)
            {
                TFechaNacimiento.Text += "/";
                TFechaNacimiento.SelectionStart = TFechaNacimiento.Text.Length;
            }
            if (TFechaNacimiento.Text.Length == 5 && back == 6)
            {
                back = 5;
            }
            if (back == 5 && TFechaNacimiento.Text.Length == 6)
            {
                string text = TFechaNacimiento.Text.Substring(0, 5) + "/" + TFechaNacimiento.Text.Substring(5);
                TFechaNacimiento.Text = text;
                TFechaNacimiento.SelectionStart = TFechaNacimiento.Text.Length;
                back = 3;
            }
            if (back < 4 && TFechaNacimiento.Text.Length == 6)
            {
                back = 6;
            }
        }

        private void UsuarioEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UsuarioEstado.SelectedIndex == 1)
            {
                MakeAllNotVisible();
                makeRegisterUserVisible();
            }
            if (UsuarioEstado.SelectedIndex == 0)
            {
                MakeAllNotVisible();
                makeIdUserVisible();
            }
        }

        private void BHecho_Click(object sender, EventArgs e)
        {
            if (UsuarioEstado.SelectedIndex == 1)
            {
                if (isFieldEmpty())
                {
                    global.nombre = TNombre.Text + " " + TApellidos.Text;
                    global.id_cliente = TDUI.Text;
                    global.cambio = cambio();

                    if (global.cambio != "")
                    {

                        global.total = TPagar.Text;
                        Glo.fechaReserva = TFechaReserva2.Text;
                        global.id_venta = getIdFactura();
                        FacturaReservaLibros facturaReservaLibros = new FacturaReservaLibros();
                        facturaReservaLibros.ShowDialog();

                        try
                        {
                            conn.Open();
                            string query = $"insert into cliente (cliente_id, nombre, telefono, correo, fecha_nacimiento) Values({global.id_cliente}, '{global.nombre}', '{TTelefono.Text}', '{TCorreo}', '{TFechaNacimiento.Text.Split('/')[2].Trim()}-{TFechaNacimiento.Text.Split('/')[1].Trim()}-{TFechaNacimiento.Text.Split('/')[0].Trim()}')";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            conn.Close();
                            try
                            {
                                conn.Open();
                                query = $"insert into reserva(reserva_id, fecha_reserva, libro_id, cliente, precio) values({global.id_venta}, {TFechaReserva2},{global.id_libro},'{global.id_cliente}',{global.precio})";
                                cmd = new SqlCommand(query, conn);
                                SqlDataReader reader2 = cmd.ExecuteReader();
                                conn.Close();
                                if (global.couldBeClosed)
                                {
                                    this.Close();
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Ocurrion un error");
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Ocurrio un error");
                        }

                    }


                }
            }
            if (UsuarioEstado.SelectedIndex == 0)
            {
                if (isDataCorrect())
                {
                    try
                    {
                        conn.Open();
                        string query = $"select nombre from cliente where cliente_id = '{TIdCliente.Text}'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                global.id_cliente = TIdCliente.Text;
                                global.id_venta = getIdFactura();
                                global.nombre = reader["nombre"].ToString();
                                global.total = TPagar2.Text;
                                Glo.fechaReserva = TFechaReserva.Text;
                                global.cambio = (float.Parse(TPagar2.Text) - float.Parse(TPrecioLibro2.Text)).ToString();
                                FacturaReservaLibros facturaReservaLibros = new FacturaReservaLibros();
                                facturaReservaLibros.ShowDialog();
                                conn.Close();
                                try
                                {
                                    conn.Open();
                                    query = $"insert into reserva(reserva_id, fecha_reserva, libro_id, cliente, precio) values({global.id_venta}, {TFechaReserva},{global.id_libro},'{global.id_cliente}',{global.precio})";
                                    cmd = new SqlCommand(query, conn);
                                    SqlDataReader reader2 = cmd.ExecuteReader();
                                    conn.Close();
                                    if (global.couldBeClosed)
                                    {
                                        this.Close();
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Ocurrion un error");
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario no existe");
                        }


                    }
                    catch
                    {
                        MessageBox.Show("Ocurrio un error");
                    }
                }
            }
        }
        private bool isDataCorrect()
        {
            bool estado = true;
            if (TIdCliente.Text == "")
            {
                errorProvider1.SetError(TIdCliente, "Ingrese su id de cliente");
                estado = false;
            }
            if (TPagar2.Text == "")
            {
                errorProvider1.SetError(TPagar2, "Ingrese un Monto");
                estado = false;
            }
            else
            {
                float precio = float.Parse(TPrecioLibro2.Text);
                float monto = float.Parse(TPagar2.Text);
                if (monto < precio)
                {
                    errorProvider1.SetError(TPagar2, "Monto insuficiente");
                    estado = false;
                }
            }
            if(TFechaReserva.Text == "")
            {
                errorProvider1.SetError(TFechaReserva, "Ingrese una fecha");
                estado=false;
            }
            else
            {
                try
                {
                    string[] fecha = TFechaReserva.Text.Split('/');
                    DateTime fechaReserva = new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0]));
                    DateTime fechaActual = DateTime.Now;
                    if (fechaActual.Day < fechaReserva.Day && fechaActual.Month <= fechaReserva.Month&& fechaActual.Year <= fechaReserva.Year ||
                        fechaActual.Day >= fechaReserva.Day && fechaActual.Month < fechaReserva.Month && fechaActual.Year <= fechaReserva.Year ||
                        fechaActual.Day >= fechaReserva.Day && fechaActual.Month >= fechaReserva.Month && fechaActual.Year < fechaReserva.Year) {
                    
                    }
                    else
                    {
                        errorProvider1.SetError(TFechaReserva, "Fecha de reserva no valida");
                        estado= false;
                    }
                }
                catch
                {
                    errorProvider1.SetError(TFechaReserva, "Fecha de reserva no valida");
                    estado = false;
                }
            }
            return estado;
        }
        private string getIdFactura()
        {
            string factura = "";
            int numero = 0;
            try
            {
                conn.Open();
                string query = "select count(reserva_id) as numero from Reserva";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        numero = int.Parse(reader["numero"].ToString());
                    }
                }
                else
                {
                    numero = 0;
                }
                conn.Close();
                factura = (numero + 1).ToString();
            }
            catch
            {
                MessageBox.Show("Ocuurio un error");
            }
            return factura;
        }
        private string cambio()
        {
            string cambio = "";
            float precio = float.Parse(TPrecioLibro.Text);
            float pago = float.Parse(TPagar.Text);
            if (pago < precio)
            {
                errorProvider1.SetError(TPagar, "Monto Insuficiente");

            }
            else
            {
                cambio = (pago - precio).ToString();
            }
            return cambio;
        }

        private void TPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TPagar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && TDUI.Text.Length == 10)
            {
                e.Handled = true;
            }
        }
        int duiCount = 0;
        private void TDUI_TextChanged(object sender, EventArgs e)
        {
            if (TDUI.Text.Length == 8 && duiCount == 0)
            {
                TDUI.Text += '-';
                TDUI.SelectionStart = TDUI.Text.Length;
                duiCount = 1;
            }
            if (TDUI.Text.Length == 8 && duiCount == 1)
            {
                duiCount = 2;
            }
            if (TDUI.Text.Length == 9 && duiCount == 2)
            {
                TDUI.Text = TDUI.Text.Substring(0, 8) + '-' + TDUI.Text.Substring(8);
                TDUI.SelectionStart = TDUI.Text.Length;
                duiCount = 1;
            }
        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && TTelefono.Text.Length == 9)
            {
                e.Handled = true;
            }

        }
        int countTelefono = 0;
        private void TTelefono_TextChanged(object sender, EventArgs e)
        {
            if (TTelefono.Text.Length == 4 && countTelefono == 0)
            {
                TTelefono.Text += '-';
                TTelefono.SelectionStart = TTelefono.Text.Length;
                countTelefono = 1;
            }
            if (TTelefono.Text.Length == 4 && countTelefono == 1)
            {
                countTelefono = 2;
            }
            if (TTelefono.Text.Length == 5 && countTelefono == 2)
            {
                TTelefono.Text = TTelefono.Text.Substring(0, 4) + '-' + TTelefono.Text.Substring(4);
                TTelefono.SelectionStart = TTelefono.Text.Length;
                countTelefono = 1;
            }
        }

        private void TFechaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && TFechaNacimiento.Text.Length == 10)
            {
                e.Handled = true;
            }

        }

        private void LFechaReserva_Click(object sender, EventArgs e)
        {

        }
        int back2=0;
        private void TFechaReserva2_TextChanged(object sender, EventArgs e)
        {
            if (TFechaReserva2.Text.Length == 2 && back2 < 1)
            {
                TFechaReserva2.Text += "/";
                TFechaReserva2.SelectionStart = TFechaReserva2.Text.Length;
            }
            if (TFechaReserva2.Text.Length == 2 && back2 == 3 || TFechaReserva2.Text.Length == 2 && back2 > 3)
            {
                back2 = 2;
            }
            if (back2 == 2 && TFechaReserva2.Text.Length == 3)
            {
                string text = TFechaReserva2.Text.Substring(0, 2) + "/" + TFechaReserva2.Text.Substring(2);
                TFechaReserva2.Text = text;
                TFechaReserva2.SelectionStart = TFechaReserva2.Text.Length;
                back2 = 3;
            }
            if (back2 < 1 && TFechaReserva2.Text.Length == 3)
            {
                back2 = 3;
            }
            //
            if (TFechaReserva2.Text.Length == 5 && back2 < 4)
            {
                TFechaReserva2.Text += "/";
                TFechaReserva2.SelectionStart = TFechaReserva2.Text.Length;
            }
            if (TFechaReserva2.Text.Length == 5 && back2 == 6)
            {
                back2 = 5;
            }
            if (back2 == 5 && TFechaReserva2.Text.Length == 6)
            {
                string text = TFechaReserva2.Text.Substring(0, 5) + "/" + TFechaReserva2.Text.Substring(5);
                TFechaReserva2.Text = text;
                TFechaReserva2.SelectionStart = TFechaReserva2.Text.Length;
                back2 = 3;
            }
            if (back2 < 4 && TFechaReserva2.Text.Length == 6)
            {
                back2 = 6;
            }
        }

        private void TFechaReserva2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && TFechaReserva2.Text.Length == 10)
            {
                e.Handled = true;
            }
        }

        private void TFechaReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && TFechaReserva.Text.Length == 10)
            {
                e.Handled = true;
            }
        }

        int back1 =0;
        private void TFechaReserva_TextChanged(object sender, EventArgs e)
        {
            if (TFechaReserva.Text.Length == 2 && back1 < 1)
            {
                TFechaReserva.Text += "/";
                TFechaReserva.SelectionStart = TFechaReserva.Text.Length;
            }
            if (TFechaReserva.Text.Length == 2 && back1 == 3 || TFechaReserva.Text.Length == 2 && back1 > 3)
            {
                back1 = 2;
            }
            if (back1 == 2 && TFechaReserva.Text.Length == 3)
            {
                string text = TFechaReserva.Text.Substring(0, 2) + "/" + TFechaReserva.Text.Substring(2);
                TFechaReserva.Text = text;
                TFechaReserva.SelectionStart = TFechaReserva.Text.Length;
                back1 = 3;
            }
            if (back1 < 1 && TFechaReserva.Text.Length == 3)
            {
                back1 = 3;
            }
            //
            if (TFechaReserva.Text.Length == 5 && back1 < 4)
            {
                TFechaReserva.Text += "/";
                TFechaReserva.SelectionStart = TFechaReserva.Text.Length;
            }
            if (TFechaReserva.Text.Length == 5 && back1 == 6)
            {
                back1 = 5;
            }
            if (back1 == 5 && TFechaReserva.Text.Length == 6)
            {
                string text = TFechaReserva.Text.Substring(0, 5) + "/" + TFechaReserva.Text.Substring(5);
                TFechaReserva.Text = text;
                TFechaReserva.SelectionStart = TFechaReserva.Text.Length;
                back1 = 3;
            }
            if (back1 < 4 && TFechaReserva.Text.Length == 6)
            {
                back1 = 6;
            }
        }
    }
}
