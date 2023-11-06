namespace Log_In
{
    partial class ReservarLibros
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
            this.button1 = new System.Windows.Forms.Button();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.TBBuscarLibros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultPanel
            // 
            this.ResultPanel.AutoScroll = true;
            this.ResultPanel.Location = new System.Drawing.Point(35, 79);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(730, 355);
            this.ResultPanel.TabIndex = 4;
            // 
            // TBBuscarLibros
            // 
            this.TBBuscarLibros.Location = new System.Drawing.Point(173, 17);
            this.TBBuscarLibros.Name = "TBBuscarLibros";
            this.TBBuscarLibros.Size = new System.Drawing.Size(338, 26);
            this.TBBuscarLibros.TabIndex = 3;
            this.TBBuscarLibros.Text = "Escribe el nombre del libro...";
            this.TBBuscarLibros.TextChanged += new System.EventHandler(this.TBBuscarLibros_TextChanged);
            // 
            // ReservarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.TBBuscarLibros);
            this.Name = "ReservarLibros";
            this.Text = "ReservarLibros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel ResultPanel;
        private System.Windows.Forms.TextBox TBBuscarLibros;
    }
}