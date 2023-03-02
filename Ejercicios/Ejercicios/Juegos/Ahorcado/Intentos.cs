using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.Ahorcado
{
    public class Intentos
    {
        public void Juego(string palabraAdivinar, char[] palabraAdivinarArray)
        {
            DibujarAhorcado dibujar = new DibujarAhorcado();
            Resultado resultado = new Resultado();


            char[] letrasAdivinadas = new char[palabraAdivinar.Length];
            for (int i = 0; i < letrasAdivinadas.Length; i++)
            {
                letrasAdivinadas[i] = '_';
            }

            int intentos = 0;
            int letrasCorrectas = 0;

            while (letrasCorrectas < palabraAdivinar.Length && intentos < 6)
            {
                Console.WriteLine("Palabra: " + string.Join(" ", letrasAdivinadas));

                Console.WriteLine(dibujar.Dibujar(intentos));

                Console.Write("Adivina una letra: ");
                char letra = char.Parse(Console.ReadLine());
                var letrasfalladas = "";

                bool letraAdivinada = false;
                for (int i = 0; i < palabraAdivinarArray.Length; i++)
                {
                    if (palabraAdivinarArray[i] == letra)
                    {
                        letrasAdivinadas[i] = letra;
                        letraAdivinada = true;
                        letrasCorrectas++;
                    }
                    else
                    {
                        letrasfalladas += letra;
                    }
                }

                if (!letraAdivinada)
                {
                    intentos++;
                    Console.WriteLine("Esa letra no está en la palabra. Te quedan " + (6 - intentos) + " intentos.");
                }
            }

            resultado.Result(letrasCorrectas, palabraAdivinar, dibujar, intentos);
        }
    }
}
