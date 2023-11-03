namespace Log_In
{
    partial class Registro2
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
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCloseWindow = new System.Windows.Forms.Button();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnTypeUser_Admin = new System.Windows.Forms.Button();
            this.BtnTypeUser_Employee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtGetPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnMinimizeWindow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRegresarRg1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 12.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Registro";
            // 
            // BtnCloseWindow
            // 
            this.BtnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseWindow.FlatAppearance.BorderSize = 0;
            this.BtnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseWindow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCloseWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCloseWindow.Location = new System.Drawing.Point(348, 6);
            this.BtnCloseWindow.Name = "BtnCloseWindow";
            this.BtnCloseWindow.Size = new System.Drawing.Size(24, 23);
            this.BtnCloseWindow.TabIndex = 12;
            this.BtnCloseWindow.Text = "X";
            this.BtnCloseWindow.UseVisualStyleBackColor = true;
            this.BtnCloseWindow.Click += new System.EventHandler(this.BtnCloseWindow_Click);
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.TxtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtConfirmPassword.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TxtConfirmPassword.Location = new System.Drawing.Point(45, 424);
            this.TxtConfirmPassword.MaxLength = 12;
            this.TxtConfirmPassword.Multiline = true;
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(280, 25);
            this.TxtConfirmPassword.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(46, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Confirmar contraseña";
            // 
            // BtnTypeUser_Admin
            // 
            this.BtnTypeUser_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.BtnTypeUser_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTypeUser_Admin.FlatAppearance.BorderSize = 0;
            this.BtnTypeUser_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTypeUser_Admin.ForeColor = System.Drawing.Color.White;
            this.BtnTypeUser_Admin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnTypeUser_Admin.Location = new System.Drawing.Point(86, 516);
            this.BtnTypeUser_Admin.Name = "BtnTypeUser_Admin";
            this.BtnTypeUser_Admin.Size = new System.Drawing.Size(86, 23);
            this.BtnTypeUser_Admin.TabIndex = 18;
            this.BtnTypeUser_Admin.Text = "Administrador";
            this.BtnTypeUser_Admin.UseVisualStyleBackColor = false;
            this.BtnTypeUser_Admin.Click += new System.EventHandler(this.BtnTypeUser_Admin_Click);
            // 
            // BtnTypeUser_Employee
            // 
            this.BtnTypeUser_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.BtnTypeUser_Employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTypeUser_Employee.FlatAppearance.BorderSize = 0;
            this.BtnTypeUser_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTypeUser_Employee.ForeColor = System.Drawing.Color.White;
            this.BtnTypeUser_Employee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnTypeUser_Employee.Location = new System.Drawing.Point(205, 516);
            this.BtnTypeUser_Employee.Name = "BtnTypeUser_Employee";
            this.BtnTypeUser_Employee.Size = new System.Drawing.Size(86, 23);
            this.BtnTypeUser_Employee.TabIndex = 19;
            this.BtnTypeUser_Employee.Text = "Empleado";
            this.BtnTypeUser_Employee.UseVisualStyleBackColor = false;
            this.BtnTypeUser_Employee.Click += new System.EventHandler(this.BtnTypeUser_Employee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(120, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Escoge tu tipo de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(46, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Contraseña";
            // 
            // TxtGetPassword
            // 
            this.TxtGetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.TxtGetPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtGetPassword.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGetPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TxtGetPassword.Location = new System.Drawing.Point(45, 357);
            this.TxtGetPassword.MaxLength = 12;
            this.TxtGetPassword.Multiline = true;
            this.TxtGetPassword.Name = "TxtGetPassword";
            this.TxtGetPassword.Size = new System.Drawing.Size(280, 25);
            this.TxtGetPassword.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(46, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ingrese una contraseña para acceder al programa: ";
            // 
            // BtnMinimizeWindow
            // 
            this.BtnMinimizeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.BtnMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizeWindow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMinimizeWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMinimizeWindow.Location = new System.Drawing.Point(320, 6);
            this.BtnMinimizeWindow.Name = "BtnMinimizeWindow";
            this.BtnMinimizeWindow.Size = new System.Drawing.Size(22, 23);
            this.BtnMinimizeWindow.TabIndex = 23;
            this.BtnMinimizeWindow.Text = "—";
            this.BtnMinimizeWindow.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(11)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BtnMinimizeWindow);
            this.panel1.Controls.Add(this.BtnCloseWindow);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 36);
            this.panel1.TabIndex = 24;
            // 
            // BtnRegresarRg1
            // 
            this.BtnRegresarRg1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnRegresarRg1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegresarRg1.FlatAppearance.BorderSize = 0;
            this.BtnRegresarRg1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresarRg1.ForeColor = System.Drawing.Color.White;
            this.BtnRegresarRg1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnRegresarRg1.Location = new System.Drawing.Point(27, 609);
            this.BtnRegresarRg1.Name = "BtnRegresarRg1";
            this.BtnRegresarRg1.Size = new System.Drawing.Size(86, 23);
            this.BtnRegresarRg1.TabIndex = 24;
            this.BtnRegresarRg1.Text = "Regresar";
            this.BtnRegresarRg1.UseVisualStyleBackColor = false;
            this.BtnRegresarRg1.Click += new System.EventHandler(this.BtnRegresarRg1_Click);
            // 
            // Registro2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(375, 660);
            this.Controls.Add(this.BtnRegresarRg1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnTypeUser_Employee);
            this.Controls.Add(this.BtnTypeUser_Admin);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.TxtGetPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCloseWindow;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnTypeUser_Admin;
        private System.Windows.Forms.Button BtnTypeUser_Employee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtGetPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnMinimizeWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRegresarRg1;
    }
}