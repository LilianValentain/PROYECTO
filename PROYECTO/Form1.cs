﻿using System;
using System.Windows.Forms;
//Libreria para reproducir musica
using WMPLib;

namespace PROYECTO
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer sonido;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void cmdIniciarJuego_Click(object sender, EventArgs e)
        {
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
            try
            {
             DialogResult resultado = MessageBox.Show("¿Deseas salir del juego?", "Ventana de salida",
                 MessageBoxButtons.YesNo);

             if (resultado == DialogResult.Yes)
             {
                 Application.Exit();
             }
             else
             {

             }
              
            }
            catch (Exception)
            {
                
                throw;
            }
            
            
          //  Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //si no pasa nada
            try
            {
                //si sonido es igual a nada
                if (sonido == null)
                {
                    //creamos memoria para el objeto
                    sonido = new WindowsMediaPlayer();
                    //agregamos la ubicacion de donde se encuentra(path=flujo de archivo :v) si se profe xd
                    sonido.URL = Application.StartupPath + @"\mp3\mario.mp3";
                    //metemos en la config que se repita
                    sonido.settings.setMode("loop", true);
                    //lo reproducimos
                    sonido.controls.play();

                }
            }
            //si sale mal nos dira algo
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
