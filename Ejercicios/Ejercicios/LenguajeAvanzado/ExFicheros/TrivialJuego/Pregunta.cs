using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExFicheros.TrivialJuego
{
    public class Pregunta
    {
        public string Enunciado { get; set; }
        public string[] Opciones { get; set; }
        public string Respuesta { get; set; }
       
        public Pregunta(string enunciado, string[] opciones, string correcta)
        {
            Enunciado = enunciado;
            Opciones = opciones;
            Respuesta = correcta;
        }

       
    }

    public class Jugador
    {
        public string Nombre { get; set; }
        public int PreguntasCorrectas { get; set; }
        public Jugador(string nombre)
        {
            Nombre = nombre;
            PreguntasCorrectas = 0;
        }
    }

}
