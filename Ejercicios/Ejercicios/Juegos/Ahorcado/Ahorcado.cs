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
            // Lista de palabras para adivinar
            List<string> palabras = new List<string>()
            {
                "programacion",
                "computadora",
                "tecnologia",
                "videojuegos",
                "internet"
            };

            // Escoger una palabra aleatoria de la lista
            Random random = new Random();
            string palabraAdivinar = palabras[random.Next(palabras.Count)];

            // Convertir la palabra adivinar en un arreglo de caracteres
            char[] palabraAdivinarArreglo = palabraAdivinar.ToCharArray();

            // Inicializar el arreglo de letras adivinadas
            char[] letrasAdivinadas = new char[palabraAdivinar.Length];
            for (int i = 0; i < letrasAdivinadas.Length; i++)
            {
                letrasAdivinadas[i] = '_';
            }

            // Inicializar el número de intentos y letras adivinadas
            int intentos = 0;
            int letrasCorrectas = 0;

            // Loop principal del juego
            while (letrasCorrectas < palabraAdivinar.Length && intentos < 6)
            {
                // Mostrar las letras adivinadas hasta el momento
                Console.WriteLine("Palabra: " + string.Join(" ", letrasAdivinadas));

                // Mostrar el dibujo del ahorcado
                Console.WriteLine(DibujarAhorcado(intentos));

                // Pedir al usuario que adivine una letra
                Console.Write("Adivina una letra: ");
                char letra = char.Parse(Console.ReadLine());

                // Verificar si la letra adivinada está en la palabra
                bool letraAdivinada = false;
                for (int i = 0; i < palabraAdivinarArreglo.Length; i++)
                {
                    if (palabraAdivinarArreglo[i] == letra)
                    {
                        letrasAdivinadas[i] = letra;
                        letraAdivinada = true;
                        letrasCorrectas++;
                    }
                }

                // Si la letra no está en la palabra, aumentar el número de intentos
                if (!letraAdivinada)
                {
                    intentos++;
                    Console.WriteLine("Esa letra no está en la palabra. Te quedan " + (6 - intentos) + " intentos.");
                }
            }

            // Mostrar el resultado del juego
            if (letrasCorrectas == palabraAdivinar.Length)
            {
                Console.WriteLine("¡Felicidades! Adivinaste la palabra \"" + palabraAdivinar + "\"");
            }
            else
            {
                Console.WriteLine("¡Lo siento! La palabra era \"" + palabraAdivinar + "\"");
                Console.WriteLine(DibujarAhorcado(intentos));
            }

            Console.ReadKey();
        }

        static string DibujarAhorcado(int intentos)
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
