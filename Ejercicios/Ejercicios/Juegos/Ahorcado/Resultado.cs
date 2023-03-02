using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.Ahorcado
{
    public class Resultado
    {
        public void Result(int letrasCorrectas, string palabraAdivinar, DibujarAhorcado dibujar, int intentos)
        {
            // Mostrar el resultado del juego
            if (letrasCorrectas == palabraAdivinar.Length)
            {
                Console.WriteLine("¡Felicidades! Adivinaste la palabra \"" + palabraAdivinar + "\"");
            }
            else
            {
                Console.WriteLine("¡Lo siento! La palabra era \"" + palabraAdivinar + "\"");
                Console.WriteLine(dibujar.Dibujar(intentos));
            }
        }
    }
}
