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
            Jugando jugando = new Jugando();
            //Mostrar ventana secundaria
           

            jugando.Show();
        }

        private void cmdAyuda_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Reglas del juego.\n1.-Regla");
            //MessageBox.Show("\n2.- ");
            //MessageBox.Show("\n3.- ");
            //MessageBox.Show("\n4.- ");
            //MessageBox.Show("\n5.- ");
            Reglas reglas = new Reglas();
            reglas.Show();

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
