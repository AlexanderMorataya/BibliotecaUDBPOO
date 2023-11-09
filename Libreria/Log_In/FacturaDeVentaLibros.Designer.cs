namespace Log_In
{
    partial class FacturaDeVentaLibros
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
            this.Nombre = new System.Windows.Forms.Label();
            this.NombreLibro = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.Recibido = new System.Windows.Forms.Label();
            this.Cambio = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.IdCliente = new System.Windows.Forms.Label();
            this.IdVenta = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(86, 166);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(73, 20);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre: ";
            // 
            // NombreLibro
            // 
            this.NombreLibro.AutoSize = true;
            this.NombreLibro.Location = new System.Drawing.Point(86, 327);
            this.NombreLibro.Name = "NombreLibro";
            this.NombreLibro.Size = new System.Drawing.Size(134, 20);
            this.NombreLibro.TabIndex = 1;
            this.NombreLibro.Text = "Nombre de Libro: ";
            this.NombreLibro.Click += new System.EventHandler(this.label2_Click);
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(491, 87);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(61, 20);
            this.Precio.TabIndex = 2;
            this.Precio.Text = "Precio: ";
            // 
            // Recibido
            // 
            this.Recibido.AutoSize = true;
            this.Recibido.Location = new System.Drawing.Point(491, 166);
            this.Recibido.Name = "Recibido";
            this.Recibido.Size = new System.Drawing.Size(79, 20);
            this.Recibido.TabIndex = 3;
            this.Recibido.Text = "Recibido: ";
            // 
            // Cambio
            // 
            this.Cambio.AutoSize = true;
            this.Cambio.Location = new System.Drawing.Point(491, 250);
            this.Cambio.Name = "Cambio";
            this.Cambio.Size = new System.Drawing.Size(71, 20);
            this.Cambio.TabIndex = 4;
            this.Cambio.Text = "Cambio: ";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(491, 327);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(62, 20);
            this.Fecha.TabIndex = 5;
            this.Fecha.Text = "Fecha: ";
            // 
            // IdCliente
            // 
            this.IdCliente.AutoSize = true;
            this.IdCliente.Location = new System.Drawing.Point(86, 250);
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Size = new System.Drawing.Size(106, 20);
            this.IdCliente.TabIndex = 6;
            this.IdCliente.Text = "Id de Cliente: ";
            // 
            // IdVenta
            // 
            this.IdVenta.AutoSize = true;
            this.IdVenta.Location = new System.Drawing.Point(86, 87);
            this.IdVenta.Name = "IdVenta";
            this.IdVenta.Size = new System.Drawing.Size(116, 20);
            this.IdVenta.TabIndex = 7;
            this.IdVenta.Text = "Id de la Venta: ";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(335, 382);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 34);
            this.Ok.TabIndex = 8;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // FacturaDeVentaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.IdVenta);
            this.Controls.Add(this.IdCliente);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Cambio);
            this.Controls.Add(this.Recibido);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.NombreLibro);
            this.Controls.Add(this.Nombre);
            this.Name = "FacturaDeVentaLibros";
            this.Text = "FacturaDeVentaLibros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label NombreLibro;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label Recibido;
        private System.Windows.Forms.Label Cambio;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label IdCliente;
        private System.Windows.Forms.Label IdVenta;
        private System.Windows.Forms.Button Ok;
    }
}