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
            Console.WriteLine("Cuantos jugadores son: ");
            var cantJugadores = Int32.Parse(Console.ReadLine());
            List<Jugador> jugadores = new List<Jugador>();
            bool fin = false;

            for(int i = 0; i < cantJugadores; i++)
            {
                Console.WriteLine("Dime tu nombre jugador {0}", i+1);
                jugadores.Add(new Jugador(Console.ReadLine()));
            }

            while (!fin){
                foreach(var jugador in jugadores) 
                {
                    Console.WriteLine("\nEs tu turno: {0} ", jugador.GetNombre());
                    Console.WriteLine("{0}", jugador.GetCasilla());
                    jugador.RealizarTirada();
                    if (jugador.VerificarCasilla()){
                        fin = true;
                        Console.WriteLine("{0}", jugador.GetCasilla());
                        Console.WriteLine("_____________________________________");
                        Console.WriteLine("\nJugador {0} ha ganado la partida.",jugador.GetNombre());
                        break;
                    }
                    Console.WriteLine("{0}", jugador.GetCasilla());
                    Console.WriteLine("_____________________________________");
                }
            }

        }
    }
}
