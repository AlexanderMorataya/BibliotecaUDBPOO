namespace Log_In
{
    partial class VenderLibros2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UsuarioEstado = new System.Windows.Forms.ComboBox();
            this.LIdLibro = new System.Windows.Forms.Label();
            this.LNombres = new System.Windows.Forms.Label();
            this.LApellidos = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LCorreo = new System.Windows.Forms.Label();
            this.LFechaNacimiento = new System.Windows.Forms.Label();
            this.LPrecioLibro = new System.Windows.Forms.Label();
            this.TIdLibro = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TApellidos = new System.Windows.Forms.TextBox();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.TCorreo = new System.Windows.Forms.TextBox();
            this.TPrecioLibro = new System.Windows.Forms.TextBox();
            this.TFechaNacimiento = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TPagar = new System.Windows.Forms.TextBox();
            this.LPagar = new System.Windows.Forms.Label();
            this.BHecho = new System.Windows.Forms.Button();
            this.BAtras = new System.Windows.Forms.Button();
            this.LIdCliente = new System.Windows.Forms.Label();
            this.LIdlibro2 = new System.Windows.Forms.Label();
            this.LPrecioLibro2 = new System.Windows.Forms.Label();
            this.LPagar2 = new System.Windows.Forms.Label();
            this.TIdLibro2 = new System.Windows.Forms.TextBox();
            this.TPrecioLibro2 = new System.Windows.Forms.TextBox();
            this.TPagar2 = new System.Windows.Forms.TextBox();
            this.TIdCliente = new System.Windows.Forms.TextBox();
            this.TDUI = new System.Windows.Forms.TextBox();
            this.LDUI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioEstado
            // 
            this.UsuarioEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsuarioEstado.FormattingEnabled = true;
            this.UsuarioEstado.Location = new System.Drawing.Point(268, 33);
            this.UsuarioEstado.Name = "UsuarioEstado";
            this.UsuarioEstado.Size = new System.Drawing.Size(198, 28);
            this.UsuarioEstado.TabIndex = 0;
            this.UsuarioEstado.SelectedIndexChanged += new System.EventHandler(this.UsuarioEstado_SelectedIndexChanged);
            // 
            // LIdLibro
            // 
            this.LIdLibro.AutoSize = true;
            this.LIdLibro.Location = new System.Drawing.Point(104, 126);
            this.LIdLibro.Name = "LIdLibro";
            this.LIdLibro.Size = new System.Drawing.Size(87, 20);
            this.LIdLibro.TabIndex = 1;
            this.LIdLibro.Text = "Id del Libro";
            // 
            // LNombres
            // 
            this.LNombres.AutoSize = true;
            this.LNombres.Location = new System.Drawing.Point(104, 176);
            this.LNombres.Name = "LNombres";
            this.LNombres.Size = new System.Drawing.Size(73, 20);
            this.LNombres.TabIndex = 2;
            this.LNombres.Text = "Nombres";
            // 
            // LApellidos
            // 
            this.LApellidos.AutoSize = true;
            this.LApellidos.Location = new System.Drawing.Point(104, 229);
            this.LApellidos.Name = "LApellidos";
            this.LApellidos.Size = new System.Drawing.Size(73, 20);
            this.LApellidos.TabIndex = 3;
            this.LApellidos.Text = "Apellidos";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(104, 281);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(71, 20);
            this.LTelefono.TabIndex = 4;
            this.LTelefono.Text = "Telefono";
            this.LTelefono.Visible = false;
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.Location = new System.Drawing.Point(440, 125);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(57, 20);
            this.LCorreo.TabIndex = 5;
            this.LCorreo.Text = "Correo";
            this.LCorreo.Visible = false;
            // 
            // LFechaNacimiento
            // 
            this.LFechaNacimiento.AutoSize = true;
            this.LFechaNacimiento.Location = new System.Drawing.Point(440, 176);
            this.LFechaNacimiento.Name = "LFechaNacimiento";
            this.LFechaNacimiento.Size = new System.Drawing.Size(137, 20);
            this.LFechaNacimiento.TabIndex = 6;
            this.LFechaNacimiento.Text = "Fecha Nacimineto";
            // 
            // LPrecioLibro
            // 
            this.LPrecioLibro.AutoSize = true;
            this.LPrecioLibro.Location = new System.Drawing.Point(440, 226);
            this.LPrecioLibro.Name = "LPrecioLibro";
            this.LPrecioLibro.Size = new System.Drawing.Size(117, 20);
            this.LPrecioLibro.TabIndex = 7;
            this.LPrecioLibro.Text = "Precio del Libro";
            // 
            // TIdLibro
            // 
            this.TIdLibro.Location = new System.Drawing.Point(222, 119);
            this.TIdLibro.Name = "TIdLibro";
            this.TIdLibro.ReadOnly = true;
            this.TIdLibro.Size = new System.Drawing.Size(142, 26);
            this.TIdLibro.TabIndex = 8;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(222, 176);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(142, 26);
            this.TNombre.TabIndex = 9;
            // 
            // TApellidos
            // 
            this.TApellidos.Location = new System.Drawing.Point(222, 223);
            this.TApellidos.Name = "TApellidos";
            this.TApellidos.Size = new System.Drawing.Size(142, 26);
            this.TApellidos.TabIndex = 10;
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(222, 278);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(142, 26);
            this.TTelefono.TabIndex = 11;
            this.TTelefono.TextChanged += new System.EventHandler(this.TTelefono_TextChanged);
            this.TTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TTelefono_KeyPress);
            // 
            // TCorreo
            // 
            this.TCorreo.Location = new System.Drawing.Point(583, 119);
            this.TCorreo.Name = "TCorreo";
            this.TCorreo.Size = new System.Drawing.Size(142, 26);
            this.TCorreo.TabIndex = 12;
            // 
            // TPrecioLibro
            // 
            this.TPrecioLibro.Location = new System.Drawing.Point(583, 226);
            this.TPrecioLibro.Name = "TPrecioLibro";
            this.TPrecioLibro.ReadOnly = true;
            this.TPrecioLibro.Size = new System.Drawing.Size(142, 26);
            this.TPrecioLibro.TabIndex = 13;
            this.TPrecioLibro.Visible = false;
            // 
            // TFechaNacimiento
            // 
            this.TFechaNacimiento.Location = new System.Drawing.Point(583, 176);
            this.TFechaNacimiento.Name = "TFechaNacimiento";
            this.TFechaNacimiento.Size = new System.Drawing.Size(142, 26);
            this.TFechaNacimiento.TabIndex = 14;
            this.TFechaNacimiento.TextChanged += new System.EventHandler(this.TFechaNacimiento_TextChanged);
            this.TFechaNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TFechaNacimiento_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TPagar
            // 
            this.TPagar.Location = new System.Drawing.Point(583, 279);
            this.TPagar.Name = "TPagar";
            this.TPagar.Size = new System.Drawing.Size(142, 26);
            this.TPagar.TabIndex = 16;
            this.TPagar.Visible = false;
            this.TPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TPagar_KeyPress);
            // 
            // LPagar
            // 
            this.LPagar.AutoSize = true;
            this.LPagar.Location = new System.Drawing.Point(440, 279);
            this.LPagar.Name = "LPagar";
            this.LPagar.Size = new System.Drawing.Size(64, 20);
            this.LPagar.TabIndex = 15;
            this.LPagar.Text = "Pagar $";
            // 
            // BHecho
            // 
            this.BHecho.Location = new System.Drawing.Point(583, 393);
            this.BHecho.Name = "BHecho";
            this.BHecho.Size = new System.Drawing.Size(123, 35);
            this.BHecho.TabIndex = 17;
            this.BHecho.Text = "Hecho";
            this.BHecho.UseVisualStyleBackColor = true;
            this.BHecho.Click += new System.EventHandler(this.BHecho_Click);
            // 
            // BAtras
            // 
            this.BAtras.Location = new System.Drawing.Point(108, 393);
            this.BAtras.Name = "BAtras";
            this.BAtras.Size = new System.Drawing.Size(123, 35);
            this.BAtras.TabIndex = 18;
            this.BAtras.Text = "Atras";
            this.BAtras.UseVisualStyleBackColor = true;
            // 
            // LIdCliente
            // 
            this.LIdCliente.AutoSize = true;
            this.LIdCliente.Location = new System.Drawing.Point(264, 179);
            this.LIdCliente.Name = "LIdCliente";
            this.LIdCliente.Size = new System.Drawing.Size(79, 20);
            this.LIdCliente.TabIndex = 19;
            this.LIdCliente.Text = "ID Cliente";
            this.LIdCliente.Visible = false;
            // 
            // LIdlibro2
            // 
            this.LIdlibro2.AutoSize = true;
            this.LIdlibro2.Location = new System.Drawing.Point(264, 119);
            this.LIdlibro2.Name = "LIdlibro2";
            this.LIdlibro2.Size = new System.Drawing.Size(90, 20);
            this.LIdlibro2.TabIndex = 20;
            this.LIdlibro2.Text = "ID del Libro";
            this.LIdlibro2.Visible = false;
            // 
            // LPrecioLibro2
            // 
            this.LPrecioLibro2.AutoSize = true;
            this.LPrecioLibro2.Location = new System.Drawing.Point(264, 226);
            this.LPrecioLibro2.Name = "LPrecioLibro2";
            this.LPrecioLibro2.Size = new System.Drawing.Size(117, 20);
            this.LPrecioLibro2.TabIndex = 21;
            this.LPrecioLibro2.Text = "Precio del Libro";
            this.LPrecioLibro2.Visible = false;
            // 
            // LPagar2
            // 
            this.LPagar2.AutoSize = true;
            this.LPagar2.Location = new System.Drawing.Point(264, 282);
            this.LPagar2.Name = "LPagar2";
            this.LPagar2.Size = new System.Drawing.Size(64, 20);
            this.LPagar2.TabIndex = 22;
            this.LPagar2.Text = "Pagar $";
            this.LPagar2.Visible = false;
            // 
            // TIdLibro2
            // 
            this.TIdLibro2.Location = new System.Drawing.Point(387, 119);
            this.TIdLibro2.Name = "TIdLibro2";
            this.TIdLibro2.ReadOnly = true;
            this.TIdLibro2.Size = new System.Drawing.Size(142, 26);
            this.TIdLibro2.TabIndex = 23;
            // 
            // TPrecioLibro2
            // 
            this.TPrecioLibro2.Location = new System.Drawing.Point(387, 220);
            this.TPrecioLibro2.Name = "TPrecioLibro2";
            this.TPrecioLibro2.ReadOnly = true;
            this.TPrecioLibro2.Size = new System.Drawing.Size(142, 26);
            this.TPrecioLibro2.TabIndex = 24;
            // 
            // TPagar2
            // 
            this.TPagar2.Location = new System.Drawing.Point(387, 278);
            this.TPagar2.Name = "TPagar2";
            this.TPagar2.Size = new System.Drawing.Size(142, 26);
            this.TPagar2.TabIndex = 25;
            this.TPagar2.Visible = false;
            this.TPagar2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.TPagar2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TPagar2_KeyPress);
            // 
            // TIdCliente
            // 
            this.TIdCliente.Location = new System.Drawing.Point(387, 173);
            this.TIdCliente.Name = "TIdCliente";
            this.TIdCliente.Size = new System.Drawing.Size(142, 26);
            this.TIdCliente.TabIndex = 26;
            this.TIdCliente.Visible = false;
            // 
            // TDUI
            // 
            this.TDUI.Location = new System.Drawing.Point(222, 331);
            this.TDUI.Name = "TDUI";
            this.TDUI.Size = new System.Drawing.Size(142, 26);
            this.TDUI.TabIndex = 28;
            this.TDUI.TextChanged += new System.EventHandler(this.TDUI_TextChanged);
            this.TDUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDUI_KeyPress);
            // 
            // LDUI
            // 
            this.LDUI.AutoSize = true;
            this.LDUI.Location = new System.Drawing.Point(104, 334);
            this.LDUI.Name = "LDUI";
            this.LDUI.Size = new System.Drawing.Size(38, 20);
            this.LDUI.TabIndex = 27;
            this.LDUI.Text = "DUI";
            this.LDUI.Visible = false;
            // 
            // VenderLibros2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TDUI);
            this.Controls.Add(this.LDUI);
            this.Controls.Add(this.TIdCliente);
            this.Controls.Add(this.TPagar2);
            this.Controls.Add(this.TPrecioLibro2);
            this.Controls.Add(this.TIdLibro2);
            this.Controls.Add(this.LPagar2);
            this.Controls.Add(this.LPrecioLibro2);
            this.Controls.Add(this.LIdlibro2);
            this.Controls.Add(this.LIdCliente);
            this.Controls.Add(this.BAtras);
            this.Controls.Add(this.BHecho);
            this.Controls.Add(this.TPagar);
            this.Controls.Add(this.LPagar);
            this.Controls.Add(this.TFechaNacimiento);
            this.Controls.Add(this.TPrecioLibro);
            this.Controls.Add(this.TCorreo);
            this.Controls.Add(this.TTelefono);
            this.Controls.Add(this.TApellidos);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.TIdLibro);
            this.Controls.Add(this.LPrecioLibro);
            this.Controls.Add(this.LFechaNacimiento);
            this.Controls.Add(this.LCorreo);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.LApellidos);
            this.Controls.Add(this.LNombres);
            this.Controls.Add(this.LIdLibro);
            this.Controls.Add(this.UsuarioEstado);
            this.Name = "VenderLibros2";
            this.Text = "VenderLibros2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UsuarioEstado;
        private System.Windows.Forms.Label LIdLibro;
        private System.Windows.Forms.Label LNombres;
        private System.Windows.Forms.Label LApellidos;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.Label LFechaNacimiento;
        private System.Windows.Forms.Label LPrecioLibro;
        private System.Windows.Forms.TextBox TIdLibro;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TApellidos;
        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.TextBox TCorreo;
        private System.Windows.Forms.TextBox TPrecioLibro;
        private System.Windows.Forms.TextBox TFechaNacimiento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BAtras;
        private System.Windows.Forms.Button BHecho;
        private System.Windows.Forms.TextBox TPagar;
        private System.Windows.Forms.Label LPagar;
        private System.Windows.Forms.TextBox TPagar2;
        private System.Windows.Forms.TextBox TPrecioLibro2;
        private System.Windows.Forms.TextBox TIdLibro2;
        private System.Windows.Forms.Label LPagar2;
        private System.Windows.Forms.Label LPrecioLibro2;
        private System.Windows.Forms.Label LIdlibro2;
        private System.Windows.Forms.Label LIdCliente;
        private System.Windows.Forms.TextBox TIdCliente;
        private System.Windows.Forms.TextBox TDUI;
        private System.Windows.Forms.Label LDUI;
    }
}