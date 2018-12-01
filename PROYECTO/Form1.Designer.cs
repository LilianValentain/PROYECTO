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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagen_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSalir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(532, 168);
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
            this.cmdAyuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAyuda.Location = new System.Drawing.Point(532, 214);
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
            this.cmdIniciarJuego.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdIniciarJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciarJuego.Location = new System.Drawing.Point(532, 114);
            this.cmdIniciarJuego.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmdIniciarJuego.Name = "cmdIniciarJuego";
            this.cmdIniciarJuego.Size = new System.Drawing.Size(75, 47);
            this.cmdIniciarJuego.TabIndex = 4;
            this.cmdIniciarJuego.Text = "Iniciar Juego";
            this.cmdIniciarJuego.UseVisualStyleBackColor = true;
            this.cmdIniciarJuego.Click += new System.EventHandler(this.cmdIniciarJuego_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(410, 177);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(108, 34);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PROYECTO.Properties.Resources.gifs_animados_galgos_4655716;
            this.pictureBox1.Location = new System.Drawing.Point(34, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // imagen_1
            // 
            this.imagen_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagen_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagen_1.Image = global::PROYECTO.Properties.Resources.Logo_TecNM_2017;
            this.imagen_1.Location = new System.Drawing.Point(325, 114);
            this.imagen_1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.imagen_1.Name = "imagen_1";
            this.imagen_1.Size = new System.Drawing.Size(81, 55);
            this.imagen_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_1.TabIndex = 7;
            this.imagen_1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::PROYECTO.Properties.Resources._47148353_448922305512290_4335681288158576640_n;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(629, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.cmdIniciarJuego;
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(630, 260);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdAyuda);
            this.Controls.Add(this.cmdIniciarJuego);
            this.Controls.Add(this.imagen_1);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEMORAMA TECNM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

