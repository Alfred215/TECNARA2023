using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.Ahorcado
{
    public class Palabras
    {
        public string GetPalabras()
        {
            List<string> palabras = new List<string>()
            {
                "programacion",
                "computadora",
                "tecnologia",
                "videojuegos",
                "internet"
            };

            Random random = new Random();
            return palabras[random.Next(palabras.Count)];
        }
        
    }
}
