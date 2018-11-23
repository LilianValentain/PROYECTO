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
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdAyuda = new System.Windows.Forms.Button();
            this.cmdIniciarJuego = new System.Windows.Forms.Button();
            this.imagen_1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(513, 147);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 29);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdAyuda
            // 
            this.cmdAyuda.Location = new System.Drawing.Point(513, 99);
            this.cmdAyuda.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmdAyuda.Name = "cmdAyuda";
            this.cmdAyuda.Size = new System.Drawing.Size(75, 29);
            this.cmdAyuda.TabIndex = 5;
            this.cmdAyuda.Text = "Ayuda";
            this.cmdAyuda.UseVisualStyleBackColor = true;
            this.cmdAyuda.Click += new System.EventHandler(this.cmdAyuda_Click);
            // 
            // cmdIniciarJuego
            // 
            this.cmdIniciarJuego.Location = new System.Drawing.Point(513, 50);
            this.cmdIniciarJuego.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmdIniciarJuego.Name = "cmdIniciarJuego";
            this.cmdIniciarJuego.Size = new System.Drawing.Size(75, 47);
            this.cmdIniciarJuego.TabIndex = 4;
            this.cmdIniciarJuego.Text = "Iniciar Juego";
            this.cmdIniciarJuego.UseVisualStyleBackColor = true;
            this.cmdIniciarJuego.Click += new System.EventHandler(this.cmdIniciarJuego_Click);
            // 
            // imagen_1
            // 
            this.imagen_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagen_1.Image = global::PROYECTO.Properties.Resources.Logo_TecNM_2017;
            this.imagen_1.Location = new System.Drawing.Point(11, 7);
            this.imagen_1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.imagen_1.Name = "imagen_1";
            this.imagen_1.Size = new System.Drawing.Size(383, 234);
            this.imagen_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_1.TabIndex = 7;
            this.imagen_1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(425, 48);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(68, 23);
            this.txtNombre.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(630, 256);
            this.ControlBox = false;
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdAyuda);
            this.Controls.Add(this.cmdIniciarJuego);
            this.Controls.Add(this.imagen_1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEMORAMA TECNM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdAyuda;
        private System.Windows.Forms.Button cmdIniciarJuego;
        private System.Windows.Forms.PictureBox imagen_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

