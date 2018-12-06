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
        //Aquí se crean las variables y los arreglos necesarios para acomodar las imágenes y asignar
        //las cartas random.
        //Bitmap: Un mapa de bits es un objeto utilizado
        //para trabajar con imágenes definidas por datos de píxeles.
        //Random: Representa un generador de números pseudoaleatorios, que es un dispositivo
        //que produce una secuencia de números que cumplen ciertos requisitos estadísticos
        //para la aleatoriedad.
        //En vez de hacer diferentes clases para los métodos, optamos por crear todos los métodos en 
        //este apartado.

        int contador_igual = 0;
        int elegida = 0;
        int jugadas = 0;
        int oportunidades = 4;
        int conta_acertada = 0;
        int[] asignadas = new int[5];
        PictureBox[] seleccionado = new PictureBox[5];
        Bitmap[] select = new Bitmap[2];
        Bitmap[] img = new Bitmap[5];
        Bitmap[] posicion = new Bitmap[12];
       
        Random asignar = new Random();
        Bitmap img_defecto = new Bitmap(PROYECTO.Properties.Resources.img_default);
      
        
        
        
        public Jugando(string nombre)
        {


            InitializeComponent();

            Form1 jugador = new Form1();

            lblJugador.Text = nombre;
            
        }

        public void revolver()
        {

            asignadas[0] = 0;
            asignadas[1] = 0;
            asignadas[2] = 0;
            asignadas[3] = 0;
            asignadas[4] = 0;

            img[0] = PROYECTO.Properties.Resources.equis;
            img[1] = PROYECTO.Properties.Resources.sistemas;
            img[2] = PROYECTO.Properties.Resources.quimica;
            img[3] = PROYECTO.Properties.Resources.industrial;
            img[4] = PROYECTO.Properties.Resources.nanotec;

            posicion[asignar.Next(8)] = img[0];

            for (int i = 0; i < 9; i++)
            {
                if (posicion[i] != img[0])
                {
                    do
                    {
                        elegida = asignar.Next(1, 5);
                    } while (asignadas[elegida] == 2);
                    posicion[i] = img[elegida];
                    asignadas[elegida]++;
                }

            }
        }
        public void bloquear()
        {
            img_1.Enabled = false;
            img_2.Enabled = false;
            img_3.Enabled = false;
            img_4.Enabled = false;
            img_5.Enabled = false;
            img_6.Enabled = false;
            img_7.Enabled = false;
            img_8.Enabled = false;
            img_9.Enabled = false;
        }
        public void encender()
        {
            img_1.Enabled = true;
            img_2.Enabled = true;
            img_3.Enabled = true;
            img_4.Enabled = true;
            img_5.Enabled = true;
            img_6.Enabled = true;
            img_7.Enabled = true;
            img_8.Enabled = true;
            img_9.Enabled = true;

        }
        public void evaluador()
        {

            if (oportunidades == 0) { bloquear(); MessageBox.Show("Perdiste tus oportunidades", "Perdiste", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                this.jugadas = jugadas + 1;
                contador_igual++;
                Njugadas.Text = Convert.ToString(jugadas);
                conta_oportunidades.Text = Convert.ToString(oportunidades);
                if (contador_igual == 3)
                {

                    seleccionado[3].Enabled = true;
                    seleccionado[4].Enabled = true;



                    seleccionado[3].BackgroundImage = img_defecto;
                    seleccionado[3].BackgroundImageLayout = ImageLayout.Stretch;
                    seleccionado[4].BackgroundImage = img_defecto;
                    seleccionado[4].BackgroundImageLayout = ImageLayout.Stretch;

                    contador_igual = 1;
                }
                if (seleccionado[0] != null && seleccionado[1] != null)
                {

                    if (select[0] == select[1])
                    {
                        conta_acertada++;
                        seleccionado[0].Enabled = false;
                        seleccionado[1].Enabled = false;

                        seleccionado[0] = null;
                        seleccionado[1] = null;
                        contador_igual = 0;
                        if (conta_acertada == 4) { bloquear(); MessageBox.Show("Acertaste a todas las imagenes !!!!!"); }

                    }
                    else
                    {
                        seleccionado[3] = seleccionado[0];
                        seleccionado[4] = seleccionado[1];
                        seleccionado[0] = null;
                        seleccionado[1] = null;
                        oportunidades--;
                        conta_oportunidades.Text = Convert.ToString(oportunidades);

                    }
                }

            }

        }
        public void iniciar()
        {

            jugadas = 0;
            seleccionado[0] = null;
            seleccionado[1] = null;

            img_1.BackgroundImage = PROYECTO.Properties.Resources.img_default;
            img_1.BackgroundImageLayout = ImageLayout.Stretch;
            img_2.BackgroundImage = PROYECTO.Properties.Resources.img_default;
            img_2.BackgroundImageLayout = ImageLayout.Stretch;
            img_3.BackgroundImage = PROYECTO.Properties.Resources.img_default;
            img_3.BackgroundImageLayout = ImageLayout.Stretch;
            img_4.BackgroundImage = PROYECTO.Properties.Resources.img_default;
            img_4.BackgroundImageLayout = ImageLayout.Stretch;
            img_5.BackgroundImage = PROYECTO.Properties.Resources.img_default;
            img_5.BackgroundImageLayout = ImageLayout.Stretch;
            img_6.BackgroundImage = PROYECTO.Properties.Resources.img_default;
            img_6.BackgroundImageLayout = ImageLayout.Stretch;
            img_7.BackgroundImage = PROYECTO.Properties.Resources.img_default;
            img_7.BackgroundImageLayout = ImageLayout.Stretch;
            img_8.BackgroundImage = PROYECTO.Properties.Resources.img_default;
            img_8.BackgroundImageLayout = ImageLayout.Stretch;
            img_9.BackgroundImage = PROYECTO.Properties.Resources.img_default;
            img_9.BackgroundImageLayout = ImageLayout.Stretch;

            for (int i = 0; i < posicion.Length; i++)
            {
                posicion[i] = img_defecto;

            }
        }

        private void Jugando_Load(object sender, EventArgs e)
        {

            iniciar();
            revolver();
        }
    
        private void btnReinciar_Click(object sender, EventArgs e)
        {
            iniciar();
            revolver();
            encender();
            Njugadas.Text = "0";
            seleccionado[0] = null;
            seleccionado[1] = null;
            contador_igual = 0;
            oportunidades = 4;
            conta_acertada = 0;
            conta_oportunidades.Text = Convert.ToString(oportunidades);
        }


        private void btnSalir_Click(object sender, EventArgs e)
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
    
        private void img_1_Click_1(object sender, EventArgs e)
        {
                  
            img_1.Enabled = false;
            img_1.BackgroundImage = posicion[0];
            img_1.BackgroundImageLayout = ImageLayout.Stretch;

            if (posicion[0] == img[0])
            {
                bloquear();
                MessageBox.Show("Perdiste porque te salió una X");
            }
            else
            {

                if (seleccionado[0] == null)
                {
                    seleccionado[0] = img_1;
                    select[0] = posicion[0];
                }
                else
                {
                    seleccionado[1] = img_1;
                    select[1] = posicion[0];
                }
                evaluador();
            }
        }
        private void img_2_Click_1(object sender, EventArgs e)
        {
            img_2.Enabled = false;
            img_2.BackgroundImage = posicion[1];
            img_2.BackgroundImageLayout = ImageLayout.Stretch;

            if (posicion[1] == img[0])
            {
                bloquear();
                MessageBox.Show("Perdiste porque te salió una X");
            }
            else
            {
                if (seleccionado[0] == img_2)/////////cambio
                {
                    seleccionado[0] = img_2;
                    select[0] = posicion[1];
                }
                else
                {
                    seleccionado[1] = img_2;
                    select[1] = posicion[1];
                }
                evaluador();
            }
        }

        private void img_3_Click_1(object sender, EventArgs e)
        {
            img_3.Enabled = false;
            img_3.BackgroundImage = posicion[2];
            img_3.BackgroundImageLayout = ImageLayout.Stretch;

            if (posicion[2] == img[0])
            {
                bloquear();
                MessageBox.Show("Perdiste porque te salió una X");
            }
            else
            {
                if (seleccionado[0] == null)
                {
                    seleccionado[0] = img_3;
                    select[0] = posicion[2];
                }
                else
                {
                    seleccionado[1] = img_3;
                    select[1] = posicion[2];
                }
                evaluador();
            }
        }
        private void img_4_Click_1(object sender, EventArgs e)
        {
            img_4.Enabled = false;
            img_4.BackgroundImage = posicion[3];
            img_4.BackgroundImageLayout = ImageLayout.Stretch;

            if (posicion[3] == img[0])
            {
                bloquear();
                MessageBox.Show("Perdiste porque te salió una X");
            }
            else
            {
                if (seleccionado[0] == null)
                {
                    seleccionado[0] = img_4;
                    select[0] = posicion[3];
                }
                else
                {
                    seleccionado[1] = img_4;
                    select[1] = posicion[3];
                }
                evaluador();
            }
        }

        private void img_5_Click_1(object sender, EventArgs e)
        {

            img_5.Enabled = false;
            img_5.BackgroundImage = posicion[4];
            img_5.BackgroundImageLayout = ImageLayout.Stretch;

            if (posicion[4] == img[0])
            {
                bloquear();
                MessageBox.Show("Perdiste porque te salió una X");
            }
            else
            {
                if (seleccionado[0] == null)
                {
                    seleccionado[0] = img_5;
                    select[0] = posicion[4];
                }
                else
                {
                    seleccionado[1] = img_5;
                    select[1] = posicion[4];
                }
                evaluador();
            }
        }
        private void img_6_Click_1(object sender, EventArgs e)
        {
            img_6.Enabled = false;
            img_6.BackgroundImage = posicion[5];
            img_6.BackgroundImageLayout = ImageLayout.Stretch;

            if (posicion[5] == img[0])
            {
                bloquear();
                MessageBox.Show("Perdiste porque te salió una X");
            }
            else
            {
                if (seleccionado[0] == null)
                {
                    seleccionado[0] = img_6;
                    select[0] = posicion[5];
                }
                else
                {
                    seleccionado[1] = img_6;
                    select[1] = posicion[5];
                }
                evaluador();
            }
        }

        private void img_7_Click_1(object sender, EventArgs e)
        {
            img_7.Enabled = false;
            img_7.BackgroundImage = posicion[6];
            img_7.BackgroundImageLayout = ImageLayout.Stretch;

            if (posicion[6] == img[0])
            {
                bloquear();
                MessageBox.Show("Perdiste porque te salió una X");
            }
            else
            {
                if (seleccionado[0] == null)
                {
                    seleccionado[0] = img_7;
                    select[0] = posicion[6];
                }
                else
                {
                    seleccionado[1] = img_7;
                    select[1] = posicion[6];
                }
                evaluador();
            }
        }
        private void img_8_Click_1(object sender, EventArgs e)
        {
            img_8.Enabled = false;
            img_8.BackgroundImage = posicion[7];
            img_8.BackgroundImageLayout = ImageLayout.Stretch;

            if (posicion[7] == img[0])
            {
                bloquear();
                MessageBox.Show("Perdiste porque te salió una X");
            }
            else
            {
                if (seleccionado[0] == null)
                {
                    seleccionado[0] = img_8;
                    select[0] = posicion[7];
                }
                else
                {
                    seleccionado[1] = img_8;
                    select[1] = posicion[7];
                }
                evaluador();
            }
        }


        private void img_9_Click_1(object sender, EventArgs e)
        {
            img_9.Enabled = false;
            img_9.BackgroundImage = posicion[8];
            img_9.BackgroundImageLayout = ImageLayout.Stretch;

            if (posicion[8] == img[0])
            {
                bloquear();
                MessageBox.Show("Perdiste porque te salió una X");
            }
            else
            {
                if (seleccionado[0] == null)
                {
                    seleccionado[0] = img_9;
                    select[0] = posicion[8];
                }
                else
                {
                    seleccionado[1] = img_9;
                    select[1] = posicion[8];
                }
                evaluador();
            }
        }

        private void cmdAyuda_Click(object sender, EventArgs e)
        {
            //instanciamos la forma de las reglas para el boton de ayuda
            Reglas reglas = new Reglas();
            //llamamos el metodo de showdialog el cual muestra la ventana o forma hehehe
            reglas.ShowDialog();
        }
    }

        
    }

