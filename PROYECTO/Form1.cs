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
        public int Tamanio_Columnas_Filas { get; set; }
        public int Movimientos { get; set; }
        public int Cantidad_de_cartas_volteadas { get; set; }

    
        //parametros de como se va a ver 
        int TamanioColumnasFilas = 4;
        int Movimientos = 0;
        int CantidadDeCartasVolteadas = 0;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionada;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        int CartaActual = 0;

        public Form1()
        {
            InitializeComponent();
            iniciarJuego();
        }

        public void iniciarJuego()
        {
            //lblRecord.Text = "0";
            //CantidadDeCartasVolteadas = 0;
            //Movimientos = 0;
            //Panel_1.Controls.Clear();

            //CartasEnumeradas = new List<string>();
            //CartasRevueltas = new List<string>();
            //CartasSeleccionada = new ArrayList();

        }

        private void cmdReinicio_Click(object sender, EventArgs e)
        {

        }


    }
}
