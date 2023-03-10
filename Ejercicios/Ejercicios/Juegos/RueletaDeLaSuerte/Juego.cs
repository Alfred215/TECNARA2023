using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.RueletaDeLaSuerte
{
    public class Juego
    {
        List<Jugador> jugadores = new List<Jugador>();

        public Juego()
        {
            //Introducimos la cantidad de jugadores que van a jugar
            Console.WriteLine("Cuantos jugadores son: ");
            var cantJugadores = Int32.Parse(Console.ReadLine());
            List<Jugador> jugadores = new List<Jugador>();

            //Introducimos los nombres de los jugadores
            for (int i = 0; i < cantJugadores; i++)
            {
                Console.WriteLine("Dime tu nombre jugador {0}", i + 1);
                jugadores.Add(new Jugador(Console.ReadLine()));
            }

            //Empieza la ronda
            new Ronda(jugadores);

            foreach(var jugador in jugadores)
            {
                Console.WriteLine("Jugador => {0} tiene {1} en total", jugador.GetNombre(), jugador.GetPuntosTotales());
            }
        }
    }
}
