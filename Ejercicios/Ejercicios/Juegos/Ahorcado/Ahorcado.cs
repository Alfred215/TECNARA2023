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
            Random rnd = new Random();
            Palabras palabras = new Palabras();
            Intentos intentos = new Intentos();

            var listPalabraAdivinar = palabras.GetPalabras();

            var palabraAdivinar = listPalabraAdivinar[rnd.Next(listPalabraAdivinar.Count())];

            char[] palabraAdivinarArreglo = palabraAdivinar.ToCharArray();

            intentos.Juego(palabraAdivinar,palabraAdivinarArreglo);

            Console.ReadKey();
        }

    }
}
