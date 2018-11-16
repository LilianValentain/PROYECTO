using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PROYECTO
{
    //Metodos donde a cada carta se le asigará una posicion
    public class Carta
    {

        
        int[] asignadas = new int[6];
        int elegida = 0;
        Random Jugando = new Random();
        Bitmap[] img = new Bitmap[6];
        Bitmap[] posicion = new Bitmap[12];

        public void revolver_cartas() 
        //Reorganiza las posiciones de las imagenes en el array de posiciones
        {

            asignadas[0] = 0;
            asignadas[1] = 0;
            asignadas[2] = 0;
            asignadas[3] = 0;
            asignadas[4] = 0;
            asignadas[5] = 0;
            asignadas[6] = 0;



            img[0] = PROYECTO.Properties.Resources.ARRIBA_01;
            img[1] = PROYECTO.Properties.Resources.ARRIBA_02;
            img[2] = PROYECTO.Properties.Resources.ARRIBA_03;
            img[3] = PROYECTO.Properties.Resources.ARRIBA_04;
            img[4] = PROYECTO.Properties.Resources.ARRIBA_05;
            img[5] = PROYECTO.Properties.Resources.ARRIBA_06;

            /////////////////////////////////////////////
            /*
             * asigna las cartas de forma aleatoria
             * si la posicion ya esta con la imagen del comodin se la salta
             */
            for (int i = 0; i < 12; i++)
            {
                if (posicion[i] != img[0])
                {
                    do
                    {
                        elegida = Jugando.Next(1, 6);
                    } while (asignadas[elegida] == 2);
                    posicion[i] = img[elegida];
                    asignadas[elegida]++;
                }

            }
        }
    }
}
