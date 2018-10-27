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
            this.paneljuego = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdReinicio = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblDijito = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // paneljuego
            // 
            this.paneljuego.Location = new System.Drawing.Point(12, 12);
            this.paneljuego.Name = "paneljuego";
            this.paneljuego.Size = new System.Drawing.Size(422, 308);
            this.paneljuego.TabIndex = 1;
            // 
            // cmdReinicio
            // 
            this.cmdReinicio.Location = new System.Drawing.Point(463, 12);
            this.cmdReinicio.Name = "cmdReinicio";
            this.cmdReinicio.Size = new System.Drawing.Size(111, 23);
            this.cmdReinicio.TabIndex = 0;
            this.cmdReinicio.Text = "&Reinicio de juego";
            this.cmdReinicio.UseVisualStyleBackColor = true;
            this.cmdReinicio.Click += new System.EventHandler(this.cmdReinicio_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(459, 55);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(72, 20);
            this.lblRecord.TabIndex = 2;
            this.lblRecord.Text = "Record:";
            // 
            // lblDijito
            // 
            this.lblDijito.AutoSize = true;
            this.lblDijito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijito.Location = new System.Drawing.Point(537, 55);
            this.lblDijito.Name = "lblDijito";
            this.lblDijito.Size = new System.Drawing.Size(19, 20);
            this.lblDijito.TabIndex = 3;
            this.lblDijito.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 332);
            this.Controls.Add(this.lblDijito);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.cmdReinicio);
            this.Controls.Add(this.paneljuego);
            this.Name = "Form1";
            this.Text = "Memorama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel paneljuego;
        private System.Windows.Forms.Button cmdReinicio;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblDijito;
        private System.Windows.Forms.Timer timer1;
    }
}

