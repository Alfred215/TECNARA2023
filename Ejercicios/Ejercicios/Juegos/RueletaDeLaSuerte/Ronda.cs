﻿using Ejercicios.Juegos.JuegoOca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.RueletaDeLaSuerte
{
    public class Ronda : Tablero
    {
        public Ronda(List<Jugador> jugadores) : base()
        {
            bool ronda = true;
            do
            {
                foreach (var jugador in jugadores)
                {
                    jugador.SetTipojugador(TipoJugador.Jugando);

                    //Bucle para que si el jugador acierta, siga jugando
                    while(jugador.GetTipo() == TipoJugador.Jugando)
                    {
                        //Bucle para pedir opción
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("\n{0} =>", jugador.GetNombre());
                            Console.WriteLine("Tus puntos => {0}", jugador.GetPuntos());
                            base.ImprimirFrase();

                            Console.WriteLine("\nEscoge una acción: \n1-Decir letra \n2-Comprar Vocal (100 puntos) \n3-Resolver");
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
                        Console.Clear();
                        Console.WriteLine("Has ganado la ronda {0}", jugador.GetNombre());
                        jugador.SumarPuntosTotal();
                        ronda = false;
                        break;
                    }

                    Console.WriteLine("El turno pasa al siguiente jugador");
                    Console.ReadKey();
                }
            } while (ronda);
        }
    }
}
