namespace Log_In
{
    partial class VenderLibros
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
            this.TBBuscarLibros = new System.Windows.Forms.TextBox();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBBuscarLibros
            // 
            this.TBBuscarLibros.Location = new System.Drawing.Point(174, 21);
            this.TBBuscarLibros.Name = "TBBuscarLibros";
            this.TBBuscarLibros.Size = new System.Drawing.Size(338, 26);
            this.TBBuscarLibros.TabIndex = 0;
            this.TBBuscarLibros.Text = "Escribe el nombre del libro...";
            this.TBBuscarLibros.TextChanged += new System.EventHandler(this.TBBuscarLibros_TextChanged);
            this.TBBuscarLibros.MouseEnter += new System.EventHandler(this.TBBuscarLibros_MouseEnter);
            // 
            // ResultPanel
            // 
            this.ResultPanel.AutoScroll = true;
            this.ResultPanel.Location = new System.Drawing.Point(36, 83);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(730, 355);
            this.ResultPanel.TabIndex = 1;
            this.ResultPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ResultPanel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VenderLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.TBBuscarLibros);
            this.Name = "VenderLibros";
            this.Text = "VenderLibros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBBuscarLibros;
        private System.Windows.Forms.Panel ResultPanel;
        private System.Windows.Forms.Button button1;
    }
}