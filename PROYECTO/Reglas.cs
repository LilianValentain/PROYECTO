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
    public partial class Reglas : Form
    {
        public Reglas()
        {
            InitializeComponent();
        }

        private void Reglas_Load(object sender, EventArgs e)
        {
           
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Ierxh9kg1UE");
        }
    }
}
