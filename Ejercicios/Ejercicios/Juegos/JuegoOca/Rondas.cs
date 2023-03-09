using Ejercicios.Juegos.RueletaDeLaSuerte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.JuegoOca
{
    public class Rondas
    {
        bool fin = false;

        public Rondas(List<Jugador> jugadores)
        {
            while (!fin)
            {
                foreach (var jugador in jugadores)
                {
                    Console.WriteLine("\nEs tu turno: {0} ", jugador.GetNombre());
                    Console.WriteLine("{0}", jugador.GetCasilla());
                    jugador.RealizarTirada();
                    if (jugador.VerificarCasilla())
                    {
                        fin = true;
                        Console.WriteLine("{0}", jugador.GetCasilla());
                        Console.WriteLine("_____________________________________");
                        Console.WriteLine("\nJugador {0} ha ganado la partida.", jugador.GetNombre());
                        break;
                    }
                    Console.WriteLine("{0}", jugador.GetCasilla());
                    Console.WriteLine("_____________________________________");
                }
            }
        }
    }
}
