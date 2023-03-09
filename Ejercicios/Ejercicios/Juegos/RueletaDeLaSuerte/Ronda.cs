using Ejercicios.Juegos.JuegoOca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.RueletaDeLaSuerte
{
    public class Ronda : Tablero
    {
        public Ronda( List<Jugador> jugadores) : base()
        {

            do
            {
                foreach (var jugador in jugadores)
                {
                    jugador.SetTipoJugando();

                    //Bucle para que si el jugador acierta, siga jugando
                    while(jugador.GetTipo() == TipoJugador.Jugando)
                    {
                        //Bucle para pedir opción
                        while (true)
                        {
                            Console.WriteLine("\n{0} =>", jugador.GetNombre());
                            base.ImprimirFrase();

                            Console.WriteLine("\nEscoge una acción: \n1-Decir letra \n2-Comprar Vocal (100 puntos) \n 3-Resolver");
                            if(base.Acciones(Convert.ToInt32(Console.ReadLine()), jugador))
                            {
                                break;
                            }
                        }

                        Console.WriteLine("Tus puntos en esta ronda son: {0}", jugador.GetPuntos());
                        Console.WriteLine("________________________________________________________");
                        Console.ReadKey();
                    }

                    if(jugador.GetTipo() == TipoJugador.Ganador)
                    {
                        jugador.SumarPuntosTotal();
                    }
                }

            } while (true);
        }
    }
}
