using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.JuegoOca
{
    public class Tablero : Dado
    {
        private List<Casilla> tablero = new List<Casilla>();

        public Tablero() : base()
        {
            tablero.Add(new Casilla(TipoCasilla.Salida, "Salida"));
            tablero.Add(new Casilla(TipoCasilla.Nada, "Nada"));
            tablero.Add(new Casilla(TipoCasilla.Rio, "Rio"));
            tablero.Add(new Casilla(TipoCasilla.Oca, "Oca"));
            tablero.Add(new Casilla(TipoCasilla.Nada, "Nada"));
            tablero.Add(new Casilla(TipoCasilla.Rio, "Rio"));
            tablero.Add(new Casilla(TipoCasilla.Nada, "Nada"));
            tablero.Add(new Casilla(TipoCasilla.Oca, "Oca"));
            tablero.Add(new Casilla(TipoCasilla.Nada, "Nada"));
            tablero.Add(new Casilla(TipoCasilla.Nada, "Nada"));
            tablero.Add(new Casilla(TipoCasilla.Rio, "Rio"));
            tablero.Add(new Casilla(TipoCasilla.Oca, "Oca"));
            tablero.Add(new Casilla(TipoCasilla.Nada, "Nada"));
            tablero.Add(new Casilla(TipoCasilla.Nada, "Nada"));
            tablero.Add(new Casilla(TipoCasilla.Oca, "Oca"));
            tablero.Add(new Casilla(TipoCasilla.Rio, "Rio"));
            tablero.Add(new Casilla(TipoCasilla.Rio, "Rio"));
            tablero.Add(new Casilla(TipoCasilla.Nada, "Nada"));
            tablero.Add(new Casilla(TipoCasilla.Meta, "Meta"));
        }

        public string GetNombreCasilla(int posicion)
        {
            return tablero[posicion].GetNombreCasilla();
        }

        public int MayorTablero(int posicion)
        {
            if (posicion >= tablero.Count())
            {
                var cuenta = (tablero.Count()-1) - (posicion - (tablero.Count() - 1));
                return cuenta;
            }
            return posicion;
        }

        public TipoCasilla VerificarCasilla (int posicion)
        {
            
            return tablero[MayorTablero(posicion)].GetCasilla();
        }

        public int RioToRio(int posicion)
        {
            for(int i = posicion-1; i > 0; i--)
            {
                if (tablero[i].GetCasilla() == TipoCasilla.Rio)
                {
                    Console.WriteLine("De Rio en Rio");
                    return i;
                }
            }
            Console.WriteLine("No hay más casilla rio");
            return posicion;
        }

        public int OcoToOca(int posicion)
        {
            for (int i = posicion + 1; i < tablero.Count(); i++)
            {
                if (tablero[i].GetCasilla() == TipoCasilla.Oca)
                {
                    Console.WriteLine("De Oca en Oca");
                    return i;
                }
            }
            Console.WriteLine("No hay más casilla oca");
            return posicion;
        }
    }
}
