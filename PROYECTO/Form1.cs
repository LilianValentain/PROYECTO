using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PROYECTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdIniciarJuego_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
            wplayer.URL = "Properties.Resources.mario.mp3";
            wplayer.controls.play();
            var nombre = "";
            nombre = txtNombre.Text;
            if (nombre != "")
            {

                Jugando jugando = new Jugando(nombre);
                //Mostrar ventana secundaria
                jugando.ShowDialog();
            }
        }

        private void cmdAyuda_Click(object sender, EventArgs e)
        {
            Reglas reglas = new Reglas();
            reglas.Show();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e){}
    }
}
