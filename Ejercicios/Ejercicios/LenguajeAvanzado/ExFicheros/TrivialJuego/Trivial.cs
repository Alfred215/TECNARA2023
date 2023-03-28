using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExFicheros.TrivialJuego
{
    public class Trivial
    {
        public Trivial()
        {
            List<Pregunta> preguntas = CargarPreguntas("../../../LenguajeAvanzado/ExFicheros/TrivialJuego/preguntas.txt");

            Console.Write("Ingresa tu nombre: ");
            string nombreJugador = Console.ReadLine();

            Jugador jugador = new Jugador(nombreJugador);

            for (int i = 0; i < preguntas.Count; i++)
            {
                Console.WriteLine(preguntas[i].Enunciado);
                foreach (var op in preguntas[i].Opciones)
                {
                    Console.WriteLine(op.ToString());
                }
                Console.Write("Tu respuesta: ");

                string respuesta = Console.ReadLine().ToUpper();
                if (respuesta == preguntas[i].Respuesta)
                {
                    Console.WriteLine("¡Correcto!");
                    jugador.PreguntasCorrectas++;
                }
                else
                {
                    Console.WriteLine("Incorrecto. La respuesta correcta era " + preguntas[i].Respuesta);
                }

                Console.WriteLine(); 
            }

            Console.WriteLine("Has acertado " + jugador.PreguntasCorrectas + " preguntas de " + preguntas.Count + ".");
            Console.ReadLine(); 

        }

        public List<Pregunta> CargarPreguntas(string rutaArchivo)
        {
            List<Pregunta> preguntas = new List<Pregunta>();
            string[] lines = File.ReadAllLines(rutaArchivo);

            for (int i = 0; i < lines.Length; i = i + 7)
            {
                string textoPregunta = lines[i];
                string[] op = { lines[i + 1], lines[i + 2], lines[i + 3], lines[i + 4] };
                string resp = lines[5].Split(":")[1].Trim().ToUpper();

                preguntas.Add(new Pregunta(textoPregunta, op, resp));
            }

            return preguntas;
        }
    }
}
