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
            Console.WriteLine("Cuantos jugadores son: ");
            var cantJugadores = Int32.Parse(Console.ReadLine());
            List<Jugador> jugadores = new List<Jugador>();

            for (int i = 0; i < cantJugadores; i++)
            {
                Console.WriteLine("Dime tu nombre jugador {0}", i + 1);
                jugadores.Add(new Jugador(Console.ReadLine()));
            }

            new Ronda(jugadores);
        }
    }
}
