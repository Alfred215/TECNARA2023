using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.Ahorcado
{
    public class DibujarAhorcado
    {
        public string Dibujar(int intentos)
        {
            // Dibujo del ahorcado
            string[] dibujo = {
                "   _____",
                "   |   |",
                "   |   " + (intentos > 0 ? "O" : ""),
                "   |  " + (intentos > 1 ? "/" : " ") + (intentos > 2 ? "|" : "") + (intentos > 3 ? "\\" : ""),
                "   |  " + (intentos > 4 ? "/" : "") + " " + (intentos > 5 ? "\\" : ""),
                "___|___"
                };

            // Unir las líneas del dibujo en un solo string
            return string.Join("\n", dibujo);
        }
    }
}
