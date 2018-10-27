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
            this.PanelJuego = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdReinicio = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PanelJuego
            // 
            this.PanelJuego.Location = new System.Drawing.Point(12, 12);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(422, 308);
            this.PanelJuego.TabIndex = 1;
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
            this.lblRecord.Location = new System.Drawing.Point(509, 74);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(19, 20);
            this.lblRecord.TabIndex = 2;
            this.lblRecord.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Record:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.cmdReinicio);
            this.Controls.Add(this.PanelJuego);
            this.Name = "Form1";
            this.Text = "Memorama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.FlowLayoutPanel PanelJuego;
        private System.Windows.Forms.Button cmdReinicio;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

