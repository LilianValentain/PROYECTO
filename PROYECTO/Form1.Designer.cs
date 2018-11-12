namespace PROYECTO
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdAyuda = new System.Windows.Forms.Button();
            this.cmdIniciarJuego = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(262, 262);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdAyuda
            // 
            this.cmdAyuda.Location = new System.Drawing.Point(262, 233);
            this.cmdAyuda.Name = "cmdAyuda";
            this.cmdAyuda.Size = new System.Drawing.Size(75, 23);
            this.cmdAyuda.TabIndex = 5;
            this.cmdAyuda.Text = "Ayuda";
            this.cmdAyuda.UseVisualStyleBackColor = true;
            this.cmdAyuda.Click += new System.EventHandler(this.cmdAyuda_Click);
            // 
            // cmdIniciarJuego
            // 
            this.cmdIniciarJuego.Location = new System.Drawing.Point(262, 204);
            this.cmdIniciarJuego.Name = "cmdIniciarJuego";
            this.cmdIniciarJuego.Size = new System.Drawing.Size(75, 23);
            this.cmdIniciarJuego.TabIndex = 4;
            this.cmdIniciarJuego.Text = "Iniciar Juego";
            this.cmdIniciarJuego.UseVisualStyleBackColor = true;
            this.cmdIniciarJuego.Click += new System.EventHandler(this.cmdIniciarJuego_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 297);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdAyuda);
            this.Controls.Add(this.cmdIniciarJuego);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Memorama";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdAyuda;
        private System.Windows.Forms.Button cmdIniciarJuego;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

