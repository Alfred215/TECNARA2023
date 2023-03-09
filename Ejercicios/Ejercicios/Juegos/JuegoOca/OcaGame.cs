using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.JuegoOca
{
    public class OcaGame
    {
        public void Ejercutar()
        {
            //Pide cuantos jugadores va a jugar
            Console.WriteLine("Cuantos jugadores son: ");
            var cantJugadores = Int32.Parse(Console.ReadLine());
            List<Jugador> jugadores = new List<Jugador>();

            //Pide los nombres de los jugadores
            for(int i = 0; i < cantJugadores; i++)
            {
                Console.WriteLine("Dime tu nombre jugador {0}", i+1);
                jugadores.Add(new Jugador(Console.ReadLine()));
            }

            //Inicia la clase de rondas
            new Rondas(jugadores);
            
        }
    }
}
