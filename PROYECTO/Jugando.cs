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
        public Jugando()
        {
            InitializeComponent();
            //Agregamos a las imagenes el fondo que usaran por arriba
            pbUNO.Image = Properties.Resources.BLANCO_01;
            pbDOS.Image = Properties.Resources.BLANCO_02;
            pbTRES.Image = Properties.Resources.BLANCO_03;
            pbCUATRO.Image = Properties.Resources.BLANCO_04;
            pbCINCO.Image = Properties.Resources.BLANCO_05;
            pbSEIS.Image = Properties.Resources.BLANCO_06;
            pbSIETE.Image = Properties.Resources.BLANCO_07;
            pbOCHO.Image = Properties.Resources.BLANCO_08;
            pbNUEVE.Image = Properties.Resources.BLANCO_09;
            pbDIEZ.Image = Properties.Resources.BLANCO_10;
            pbONCE.Image = Properties.Resources.BLANCO_11;
            pbDOCE.Image = Properties.Resources.BLANCO_12;
        }

    }
}
