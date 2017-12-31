namespace JuegoVida
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.bIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lGeneracion = new System.Windows.Forms.Label();
            this.bParar = new System.Windows.Forms.Button();
            this.bSeguir = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 0;
            // 
            // bIniciar
            // 
            this.bIniciar.Location = new System.Drawing.Point(539, 51);
            this.bIniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(162, 35);
            this.bIniciar.TabIndex = 1;
            this.bIniciar.Text = "Iniciar";
            this.bIniciar.UseVisualStyleBackColor = true;
            this.bIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nº Células:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Generación";
            // 
            // lGeneracion
            // 
            this.lGeneracion.AutoSize = true;
            this.lGeneracion.Location = new System.Drawing.Point(634, 236);
            this.lGeneracion.Name = "lGeneracion";
            this.lGeneracion.Size = new System.Drawing.Size(51, 20);
            this.lGeneracion.TabIndex = 5;
            this.lGeneracion.Text = "label3";
            // 
            // bParar
            // 
            this.bParar.Location = new System.Drawing.Point(539, 96);
            this.bParar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bParar.Name = "bParar";
            this.bParar.Size = new System.Drawing.Size(162, 35);
            this.bParar.TabIndex = 1;
            this.bParar.Text = "Parar";
            this.bParar.UseVisualStyleBackColor = true;
            this.bParar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bSeguir
            // 
            this.bSeguir.Location = new System.Drawing.Point(539, 141);
            this.bSeguir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSeguir.Name = "bSeguir";
            this.bSeguir.Size = new System.Drawing.Size(162, 35);
            this.bSeguir.TabIndex = 1;
            this.bSeguir.Text = "Seguir";
            this.bSeguir.UseVisualStyleBackColor = true;
            this.bSeguir.Click += new System.EventHandler(this.bSeguir_click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(626, 190);
            this.maskedTextBox1.Mask = "999999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(738, 531);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lGeneracion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSeguir);
            this.Controls.Add(this.bParar);
            this.Controls.Add(this.bIniciar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lGeneracion;
        private System.Windows.Forms.Button bParar;
        private System.Windows.Forms.Button bSeguir;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

