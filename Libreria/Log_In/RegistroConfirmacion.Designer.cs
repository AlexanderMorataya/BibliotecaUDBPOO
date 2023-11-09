namespace Log_In
{
    partial class RegistroConfirmacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCloseWindow = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LbTipoUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(11)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.BtnCloseWindow);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 40);
            this.panel1.TabIndex = 0;
            // 
            // BtnCloseWindow
            // 
            this.BtnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseWindow.FlatAppearance.BorderSize = 0;
            this.BtnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseWindow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCloseWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCloseWindow.Location = new System.Drawing.Point(298, 9);
            this.BtnCloseWindow.Name = "BtnCloseWindow";
            this.BtnCloseWindow.Size = new System.Drawing.Size(24, 23);
            this.BtnCloseWindow.TabIndex = 13;
            this.BtnCloseWindow.Text = "X";
            this.BtnCloseWindow.UseVisualStyleBackColor = true;
            this.BtnCloseWindow.Click += new System.EventHandler(this.BtnCloseWindow_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 12.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(5, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Registro";
            // 
            // LbTipoUsuario
            // 
            this.LbTipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.LbTipoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LbTipoUsuario.Font = new System.Drawing.Font("Dubai", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTipoUsuario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LbTipoUsuario.Location = new System.Drawing.Point(0, 65);
            this.LbTipoUsuario.Name = "LbTipoUsuario";
            this.LbTipoUsuario.Size = new System.Drawing.Size(325, 29);
            this.LbTipoUsuario.TabIndex = 1;
            this.LbTipoUsuario.Text = "texto de prueba";
            this.LbTipoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.label1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Esta seguro de los datos que desea ingresar?";
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnRegister.Location = new System.Drawing.Point(120, 149);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(86, 23);
            this.BtnRegister.TabIndex = 22;
            this.BtnRegister.Text = "Ingresar";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // RegistroConfirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(325, 200);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbTipoUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroConfirmacion";
            this.Text = "RegistroConfirmacion";
            this.Load += new System.EventHandler(this.RegistroConfirmacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCloseWindow;
        private System.Windows.Forms.TextBox LbTipoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRegister;
    }
}