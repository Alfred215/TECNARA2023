using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.Ahorcado
{
    public class Ahorcado
    {
        public void gameAhorcado()
        {
            DibujarAhorcado dibujar = new DibujarAhorcado();
            Palabras palabras = new Palabras();
            Intentos intentos = new Intentos();

            var palabraAdivinar = palabras.GetPalabras();

            char[] palabraAdivinarArreglo = palabraAdivinar.ToCharArray();

            intentos.Juego(palabraAdivinar,palabraAdivinarArreglo);

            Console.ReadKey();
        }

    }
}
