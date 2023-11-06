namespace Log_In
{
    partial class VentanaAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PbAdministrarLibros = new System.Windows.Forms.PictureBox();
            this.PbAdministrarAutores = new System.Windows.Forms.PictureBox();
            this.PbAdministrarGanancias = new System.Windows.Forms.PictureBox();
            this.BtnAdministrarLibros = new System.Windows.Forms.Label();
            this.BtnAdministrarAutores = new System.Windows.Forms.Label();
            this.BtnGanancias = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCloseProgram = new System.Windows.Forms.Button();
            this.BtnLibros = new System.Windows.Forms.Label();
            this.BtnEscritores = new System.Windows.Forms.Label();
            this.BtnEmpleados = new System.Windows.Forms.Label();
            this.BtnClientes = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbFiltro = new System.Windows.Forms.ComboBox();
            this.DgvInformacion = new System.Windows.Forms.DataGridView();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.PbClientes = new System.Windows.Forms.PictureBox();
            this.PbEmpleados = new System.Windows.Forms.PictureBox();
            this.PbEscritores = new System.Windows.Forms.PictureBox();
            this.PbLibros = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAdministrarLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAdministrarAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAdministrarGanancias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEscritores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.label1.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administracion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(11)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.PbAdministrarLibros);
            this.panel1.Controls.Add(this.PbAdministrarAutores);
            this.panel1.Controls.Add(this.PbAdministrarGanancias);
            this.panel1.Controls.Add(this.BtnAdministrarLibros);
            this.panel1.Controls.Add(this.BtnAdministrarAutores);
            this.panel1.Controls.Add(this.BtnGanancias);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 675);
            this.panel1.TabIndex = 5;
            // 
            // PbAdministrarLibros
            // 
            this.PbAdministrarLibros.Location = new System.Drawing.Point(24, 396);
            this.PbAdministrarLibros.Name = "PbAdministrarLibros";
            this.PbAdministrarLibros.Size = new System.Drawing.Size(213, 4);
            this.PbAdministrarLibros.TabIndex = 6;
            this.PbAdministrarLibros.TabStop = false;
            // 
            // PbAdministrarAutores
            // 
            this.PbAdministrarAutores.Location = new System.Drawing.Point(24, 351);
            this.PbAdministrarAutores.Name = "PbAdministrarAutores";
            this.PbAdministrarAutores.Size = new System.Drawing.Size(213, 4);
            this.PbAdministrarAutores.TabIndex = 5;
            this.PbAdministrarAutores.TabStop = false;
            // 
            // PbAdministrarGanancias
            // 
            this.PbAdministrarGanancias.Location = new System.Drawing.Point(24, 306);
            this.PbAdministrarGanancias.Name = "PbAdministrarGanancias";
            this.PbAdministrarGanancias.Size = new System.Drawing.Size(213, 4);
            this.PbAdministrarGanancias.TabIndex = 4;
            this.PbAdministrarGanancias.TabStop = false;
            // 
            // BtnAdministrarLibros
            // 
            this.BtnAdministrarLibros.AutoSize = true;
            this.BtnAdministrarLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdministrarLibros.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministrarLibros.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtnAdministrarLibros.Location = new System.Drawing.Point(25, 370);
            this.BtnAdministrarLibros.Name = "BtnAdministrarLibros";
            this.BtnAdministrarLibros.Size = new System.Drawing.Size(53, 27);
            this.BtnAdministrarLibros.TabIndex = 3;
            this.BtnAdministrarLibros.Text = "Libros";
            this.BtnAdministrarLibros.Click += new System.EventHandler(this.BtnAdministrarLibros_Click);
            this.BtnAdministrarLibros.MouseLeave += new System.EventHandler(this.BtnAdministrarLibros_MouseLeave);
            this.BtnAdministrarLibros.MouseHover += new System.EventHandler(this.BtnAdministrarLibros_MouseHover);
            // 
            // BtnAdministrarAutores
            // 
            this.BtnAdministrarAutores.AutoSize = true;
            this.BtnAdministrarAutores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdministrarAutores.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministrarAutores.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtnAdministrarAutores.Location = new System.Drawing.Point(25, 325);
            this.BtnAdministrarAutores.Name = "BtnAdministrarAutores";
            this.BtnAdministrarAutores.Size = new System.Drawing.Size(64, 27);
            this.BtnAdministrarAutores.TabIndex = 2;
            this.BtnAdministrarAutores.Text = "Autores";
            this.BtnAdministrarAutores.Click += new System.EventHandler(this.BtnAdministrarAutores_Click);
            this.BtnAdministrarAutores.MouseLeave += new System.EventHandler(this.BtnAdministrarAutores_MouseLeave);
            this.BtnAdministrarAutores.MouseHover += new System.EventHandler(this.BtnAdministrarAutores_MouseHover);
            // 
            // BtnGanancias
            // 
            this.BtnGanancias.AutoSize = true;
            this.BtnGanancias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGanancias.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGanancias.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtnGanancias.Location = new System.Drawing.Point(25, 280);
            this.BtnGanancias.Name = "BtnGanancias";
            this.BtnGanancias.Size = new System.Drawing.Size(77, 27);
            this.BtnGanancias.TabIndex = 1;
            this.BtnGanancias.Text = "Ganancias";
            this.BtnGanancias.Click += new System.EventHandler(this.BtnGanancias_Click);
            this.BtnGanancias.MouseLeave += new System.EventHandler(this.BtnGanancias_MouseLeave);
            this.BtnGanancias.MouseHover += new System.EventHandler(this.BtnGanancias_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(61, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tech Library";
            // 
            // BtnCloseProgram
            // 
            this.BtnCloseProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseProgram.FlatAppearance.BorderSize = 0;
            this.BtnCloseProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseProgram.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCloseProgram.Location = new System.Drawing.Point(1043, 5);
            this.BtnCloseProgram.Name = "BtnCloseProgram";
            this.BtnCloseProgram.Size = new System.Drawing.Size(20, 20);
            this.BtnCloseProgram.TabIndex = 10;
            this.BtnCloseProgram.Text = "X";
            this.BtnCloseProgram.UseVisualStyleBackColor = true;
            this.BtnCloseProgram.Click += new System.EventHandler(this.BtnCloseProgram_Click);
            // 
            // BtnLibros
            // 
            this.BtnLibros.AutoSize = true;
            this.BtnLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLibros.Font = new System.Drawing.Font("Dubai", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLibros.ForeColor = System.Drawing.Color.White;
            this.BtnLibros.Location = new System.Drawing.Point(350, 93);
            this.BtnLibros.Name = "BtnLibros";
            this.BtnLibros.Size = new System.Drawing.Size(57, 29);
            this.BtnLibros.TabIndex = 11;
            this.BtnLibros.Text = "Libros";
            this.BtnLibros.Click += new System.EventHandler(this.BtnLibros_Click);
            // 
            // BtnEscritores
            // 
            this.BtnEscritores.AutoSize = true;
            this.BtnEscritores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEscritores.Font = new System.Drawing.Font("Dubai", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEscritores.ForeColor = System.Drawing.Color.White;
            this.BtnEscritores.Location = new System.Drawing.Point(448, 93);
            this.BtnEscritores.Name = "BtnEscritores";
            this.BtnEscritores.Size = new System.Drawing.Size(82, 29);
            this.BtnEscritores.TabIndex = 12;
            this.BtnEscritores.Text = "Escritores";
            this.BtnEscritores.Click += new System.EventHandler(this.BtnEscritores_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.AutoSize = true;
            this.BtnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmpleados.Font = new System.Drawing.Font("Dubai", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleados.ForeColor = System.Drawing.Color.White;
            this.BtnEmpleados.Location = new System.Drawing.Point(572, 93);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(89, 29);
            this.BtnEmpleados.TabIndex = 13;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.AutoSize = true;
            this.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClientes.Font = new System.Drawing.Font("Dubai", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.Color.White;
            this.BtnClientes.Location = new System.Drawing.Point(693, 93);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(69, 29);
            this.BtnClientes.TabIndex = 14;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscar.Font = new System.Drawing.Font("Dubai", 10F);
            this.TxtBuscar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TxtBuscar.Location = new System.Drawing.Point(323, 147);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(534, 25);
            this.TxtBuscar.TabIndex = 15;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // CbFiltro
            // 
            this.CbFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.CbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbFiltro.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFiltro.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CbFiltro.FormattingEnabled = true;
            this.CbFiltro.Location = new System.Drawing.Point(896, 147);
            this.CbFiltro.Name = "CbFiltro";
            this.CbFiltro.Size = new System.Drawing.Size(120, 26);
            this.CbFiltro.TabIndex = 16;
            // 
            // DgvInformacion
            // 
            this.DgvInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInformacion.Location = new System.Drawing.Point(323, 222);
            this.DgvInformacion.Name = "DgvInformacion";
            this.DgvInformacion.Size = new System.Drawing.Size(693, 391);
            this.DgvInformacion.TabIndex = 17;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtnMinimizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMinimizar.Location = new System.Drawing.Point(1015, 4);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(22, 21);
            this.BtnMinimizar.TabIndex = 24;
            this.BtnMinimizar.Text = "—";
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            // 
            // PbClientes
            // 
            this.PbClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.PbClientes.Location = new System.Drawing.Point(698, 116);
            this.PbClientes.Name = "PbClientes";
            this.PbClientes.Size = new System.Drawing.Size(60, 4);
            this.PbClientes.TabIndex = 21;
            this.PbClientes.TabStop = false;
            // 
            // PbEmpleados
            // 
            this.PbEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.PbEmpleados.Location = new System.Drawing.Point(577, 116);
            this.PbEmpleados.Name = "PbEmpleados";
            this.PbEmpleados.Size = new System.Drawing.Size(78, 4);
            this.PbEmpleados.TabIndex = 20;
            this.PbEmpleados.TabStop = false;
            // 
            // PbEscritores
            // 
            this.PbEscritores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.PbEscritores.Location = new System.Drawing.Point(453, 116);
            this.PbEscritores.Name = "PbEscritores";
            this.PbEscritores.Size = new System.Drawing.Size(73, 4);
            this.PbEscritores.TabIndex = 19;
            this.PbEscritores.TabStop = false;
            // 
            // PbLibros
            // 
            this.PbLibros.BackColor = System.Drawing.Color.White;
            this.PbLibros.Location = new System.Drawing.Point(354, 116);
            this.PbLibros.Name = "PbLibros";
            this.PbLibros.Size = new System.Drawing.Size(47, 4);
            this.PbLibros.TabIndex = 18;
            this.PbLibros.TabStop = false;
            // 
            // VentanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1070, 675);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.PbClientes);
            this.Controls.Add(this.PbEmpleados);
            this.Controls.Add(this.PbEscritores);
            this.Controls.Add(this.PbLibros);
            this.Controls.Add(this.DgvInformacion);
            this.Controls.Add(this.CbFiltro);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.BtnEmpleados);
            this.Controls.Add(this.BtnEscritores);
            this.Controls.Add(this.BtnLibros);
            this.Controls.Add(this.BtnCloseProgram);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaAdmin";
            this.Load += new System.EventHandler(this.VentanaAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAdministrarLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAdministrarAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAdministrarGanancias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEscritores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCloseProgram;
        private System.Windows.Forms.Label BtnLibros;
        private System.Windows.Forms.Label BtnEscritores;
        private System.Windows.Forms.Label BtnEmpleados;
        private System.Windows.Forms.Label BtnClientes;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.ComboBox CbFiltro;
        private System.Windows.Forms.Label BtnAdministrarLibros;
        private System.Windows.Forms.Label BtnAdministrarAutores;
        private System.Windows.Forms.Label BtnGanancias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PbAdministrarGanancias;
        private System.Windows.Forms.DataGridView DgvInformacion;
        private System.Windows.Forms.PictureBox PbAdministrarLibros;
        private System.Windows.Forms.PictureBox PbAdministrarAutores;
        private System.Windows.Forms.PictureBox PbLibros;
        private System.Windows.Forms.PictureBox PbEscritores;
        private System.Windows.Forms.PictureBox PbEmpleados;
        private System.Windows.Forms.PictureBox PbClientes;
        private System.Windows.Forms.Button BtnMinimizar;
    }
}