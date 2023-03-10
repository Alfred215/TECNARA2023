using Ejercicios.Juegos.JuegoOca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.RueletaDeLaSuerte
{
    public class Tablero : Frase
    {
        Regex regexLetras = new Regex("[aeiou]");

        public Tablero() : base()
        {
            
        }
        
        public bool Acciones(int opcion, Jugador jugador)
        {
            switch (opcion)
            {
                case 1:
                    var letraC = EscribeLetra();

                    if(regexLetras.IsMatch(letraC.ToLower())) 
                    {
                        Console.WriteLine("No puedes escribir una vocal.");
                        return true;
                    }

                    int cantLetras = base.ComprobarLetra(letraC);

                    if(cantLetras <= 0) 
                    {
                        jugador.SetTipoJuega();
                        return true;
                    }
                    jugador.Tirada(cantLetras);

                    return true;

                case 2:

                    if(jugador.GetPuntos() >= 100)
                    {
                        var letraV = EscribeLetra();

                        if (!regexLetras.IsMatch(letraV.ToLower()))
                        {
                            Console.WriteLine("No puedes escribir una consonante.");
                            return true;
                        }

                        if (base.ComprarVocal(letraV))
                        {
                            jugador.SetTipoJuega();
                            return true;

                        }

                        jugador.RestarCompra();
                        return true;
                    }

                    Console.WriteLine("Tienes que tener más de 100 puntos para poder comprar vocales");
                    return true;

                case 3:
                    Console.WriteLine("Escribe la frase para resolver: ");
                    var frase = Console.ReadLine();

                    if (base.Resolver(frase)){
                        jugador.SetTipoGana();
                        return true;
                    }

                    jugador.SetTipoEliminado();
                    return true;

                default:
                    Console.WriteLine("Escribe una opción valida");
                    return false;
            }
        }

        public string EscribeLetra()
        {
            Console.WriteLine("Escribe una letra: ");
            return Console.ReadLine();
        }

        public override void ImprimirFrase()
        {
            Console.WriteLine("\nFrase de la Ronda");
            base.ImprimirFrase();
            Console.WriteLine("\nLetras introducidas: {0}", base.GetLetrasIntroducidas());
            Console.WriteLine("Vocales compradas: {0}", base.GetVocalesCompradas());
        }
    }
}
