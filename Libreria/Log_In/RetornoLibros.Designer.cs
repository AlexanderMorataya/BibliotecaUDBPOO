namespace Log_In
{
    partial class RetornoLibros
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
            this.btn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Alquiler
            // 
            this.lbl_Alquiler.Location = new System.Drawing.Point(61, 21);
            this.lbl_Alquiler.Size = new System.Drawing.Size(293, 39);
            this.lbl_Alquiler.Text = "Retorno de libros";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Location = new System.Drawing.Point(15, 472);
            this.lbl_nombre.Visible = false;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.Location = new System.Drawing.Point(15, 512);
            this.lbl_apellido.Visible = false;
            // 
            // lbl_correo
            // 
            this.lbl_correo.Location = new System.Drawing.Point(15, 552);
            this.lbl_correo.Visible = false;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.Location = new System.Drawing.Point(62, 414);
            this.lbl_telefono.Visible = false;
            // 
            // lbl_Dui
            // 
            this.lbl_Dui.Location = new System.Drawing.Point(62, 134);
            this.lbl_Dui.Size = new System.Drawing.Size(102, 18);
            this.lbl_Dui.Text = "DUI del cliente";
            // 
            // lbl_Codigo_libro
            // 
            this.lbl_Codigo_libro.Location = new System.Drawing.Point(62, 173);
            this.lbl_Codigo_libro.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(181, 473);
            this.txtNombre.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(181, 510);
            this.txtApellido.Visible = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(181, 550);
            this.txtCorreo.Visible = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(228, 412);
            this.txtTelefono.Visible = false;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(228, 133);
            // 
            // txtCodigo_Libro
            // 
            this.txtCodigo_Libro.Location = new System.Drawing.Point(228, 175);
            this.txtCodigo_Libro.Visible = false;
            // 
            // rbtn_reserva
            // 
            this.rbtn_reserva.Location = new System.Drawing.Point(65, 484);
            this.rbtn_reserva.Visible = false;
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(228, 547);
            // 
            // lbl_codigo_reserva
            // 
            this.lbl_codigo_reserva.Location = new System.Drawing.Point(62, 544);
            // 
            // txt_codigo_alquiler
            // 
            this.txt_codigo_alquiler.Location = new System.Drawing.Point(228, 176);
            this.txt_codigo_alquiler.ReadOnly = false;
            this.txt_codigo_alquiler.Size = new System.Drawing.Size(238, 17);
            this.txt_codigo_alquiler.TabIndex = 7;
            // 
            // txtcosto
            // 
            this.txtcosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.txtcosto.ForeColor = System.Drawing.Color.White;
            this.txtcosto.Location = new System.Drawing.Point(228, 215);
            this.txtcosto.Size = new System.Drawing.Size(238, 17);
            // 
            // lbl_codigo_alquiler
            // 
            this.lbl_codigo_alquiler.Location = new System.Drawing.Point(62, 174);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(483, 532);
            this.label2.Visible = false;
            // 
            // lbl_Costo
            // 
            this.lbl_Costo.Location = new System.Drawing.Point(62, 214);
            this.lbl_Costo.Size = new System.Drawing.Size(108, 18);
            this.lbl_Costo.Text = "Costo de mora";
            // 
            // dtp_devolucion
            // 
            this.dtp_devolucion.Location = new System.Drawing.Point(646, 540);
            this.dtp_devolucion.Visible = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cerrar.Location = new System.Drawing.Point(583, 21);
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_generar
            // 
            this.btn_generar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_generar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_generar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.btn_generar.Location = new System.Drawing.Point(788, 419);
            this.btn_generar.Text = "Registrar";
            // 
            // rb_primera_vez
            // 
            this.rb_primera_vez.Location = new System.Drawing.Point(512, 484);
            this.rb_primera_vez.Visible = false;
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(62, 443);
            this.lbl_fecha_nacimiento.Visible = false;
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(228, 443);
            this.dtp_fecha_nacimiento.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(504, 431);
            this.label1.Visible = false;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btn_registrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_registrar.Location = new System.Drawing.Point(514, 272);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(111, 44);
            this.btn_registrar.TabIndex = 28;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // RetornoLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 346);
            this.Controls.Add(this.btn_registrar);
            this.Name = "RetornoLibros";
            this.Text = "RetornoLibros";
            this.Controls.SetChildIndex(this.lbl_Alquiler, 0);
            this.Controls.SetChildIndex(this.lbl_nombre, 0);
            this.Controls.SetChildIndex(this.lbl_apellido, 0);
            this.Controls.SetChildIndex(this.lbl_correo, 0);
            this.Controls.SetChildIndex(this.lbl_telefono, 0);
            this.Controls.SetChildIndex(this.lbl_Dui, 0);
            this.Controls.SetChildIndex(this.lbl_Codigo_libro, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtCorreo, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.txtDUI, 0);
            this.Controls.SetChildIndex(this.txtCodigo_Libro, 0);
            this.Controls.SetChildIndex(this.rbtn_reserva, 0);
            this.Controls.SetChildIndex(this.lbl_codigo_reserva, 0);
            this.Controls.SetChildIndex(this.txtReserva, 0);
            this.Controls.SetChildIndex(this.lbl_Costo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lbl_codigo_alquiler, 0);
            this.Controls.SetChildIndex(this.txtcosto, 0);
            this.Controls.SetChildIndex(this.txt_codigo_alquiler, 0);
            this.Controls.SetChildIndex(this.dtp_devolucion, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_generar, 0);
            this.Controls.SetChildIndex(this.rb_primera_vez, 0);
            this.Controls.SetChildIndex(this.lbl_fecha_nacimiento, 0);
            this.Controls.SetChildIndex(this.dtp_fecha_nacimiento, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn_registrar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registrar;
    }
}