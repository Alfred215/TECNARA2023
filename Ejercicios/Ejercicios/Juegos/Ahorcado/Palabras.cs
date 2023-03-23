using Ejercicios.LenguajeAvanzado.ExFicheros.TrivialJuego;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.Ahorcado
{
    public class Palabras
    {
        public List<string> GetPalabras()
        {
            List<string> palabras = new List<string>();
            string[] lines = File.ReadAllLines("../../../Juegos/ExFicheros/Ahorcado/palabras.txt");

            foreach(var line in lines)
            {
                palabras.Add(line);
            }

            return palabras;
        }
    }
}
