using System;
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
    public partial class Jugando : Form
    {
        byte[] pares = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
        List<PictureBox> lista = new List<PictureBox>();
        int indiceTmp = 0;
        private PictureBox temporal = null;
        bool estado;

        public Jugando(string nombre)
        {
            InitializeComponent();
            //Agregamos a las imagenes el fondo que usaran por arriba
            pbUNO.Image = Properties.Resources.BLANCO_01;       lista.Add(pbUNO);
            pbDOS.Image = Properties.Resources.BLANCO_02;       lista.Add(pbDOS);
            pbTRES.Image = Properties.Resources.BLANCO_03;      lista.Add(pbTRES);
            pbCUATRO.Image = Properties.Resources.BLANCO_04;    lista.Add(pbCUATRO);
            pbCINCO.Image = Properties.Resources.BLANCO_05;     lista.Add(pbCINCO);
            pbSEIS.Image = Properties.Resources.BLANCO_06;      lista.Add(pbSEIS);
            pbSIETE.Image = Properties.Resources.BLANCO_07;     lista.Add(pbSIETE);
            pbOCHO.Image = Properties.Resources.BLANCO_08;      lista.Add(pbOCHO);
            pbNUEVE.Image = Properties.Resources.BLANCO_09;     lista.Add(pbNUEVE);
            pbDIEZ.Image = Properties.Resources.BLANCO_10;      lista.Add(pbDIEZ);
            pbONCE.Image = Properties.Resources.BLANCO_11;      lista.Add(pbONCE);
            pbDOCE.Image = Properties.Resources.BLANCO_12;      lista.Add(pbDOCE);

            lblJugador.Text = nombre;
        }

        private void pbUNO_Click(object sender, EventArgs e)
        {
            voltear(pbUNO, 0);
        }

        private void pbDOS_Click(object sender, EventArgs e)
        {
            voltear(pbDOS, 1);
        }

        private void pbTRES_Click(object sender, EventArgs e)
        {
            voltear(pbTRES, 2);
        }

        private void pbCUATRO_Click(object sender, EventArgs e)
        {
            voltear(pbCUATRO, 3);
        }

        private void pbCINCO_Click(object sender, EventArgs e)
        {
            voltear(pbCINCO, 4);
        }

        private void pbSEIS_Click(object sender, EventArgs e)
        {
            voltear(pbSEIS, 5);
        }

        private void pbSIETE_Click(object sender, EventArgs e)
        {
            voltear(pbSIETE, 6);
        }

        private void pbOCHO_Click(object sender, EventArgs e)
        {
            voltear(pbOCHO, 7);
        }

        private void pbNUEVE_Click(object sender, EventArgs e)
        {
            voltear(pbNUEVE, 8);
        }

        private void pbDIEZ_Click(object sender, EventArgs e)
        {
            voltear(pbDIEZ, 9);
        }

        private void pbONCE_Click(object sender, EventArgs e)
        {
            voltear(pbONCE, 10);
        }

        private void pbDOCE_Click(object sender, EventArgs e)
        {
            voltear(pbDOCE, 11);
        }

        private void voltear(PictureBox pb, int i)
        {
            switch (pares[i])
            {
                case 0: pb.Image = Properties.Resources.ARRIBA_01; break;
                case 1: pb.Image = Properties.Resources.ARRIBA_02; break;
                case 2: pb.Image = Properties.Resources.ARRIBA_03; break;
                case 3: pb.Image = Properties.Resources.ARRIBA_04; break;
                case 4: pb.Image = Properties.Resources.ARRIBA_05; break;
                case 5: pb.Image = Properties.Resources.ARRIBA_06; break;  
            }
            pb.Update();
            if (!estado)
            {
                estado = true;
                indiceTmp = i;
                temporal = pb;
                temporal.Enabled = false;

            }
        }
    }
}
