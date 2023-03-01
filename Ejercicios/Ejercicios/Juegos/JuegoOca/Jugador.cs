using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.JuegoOca
{
    public class Jugador : Tablero
    {
        private string nombre;
        private int casilla;

        public Jugador(string nomb) : base()
        {
            this.nombre = nomb;
            this.casilla = 0; 
        }

        public string GetCasilla()
        {
            return $"Casilla: {base.GetNombreCasilla(casilla)} Posición: {casilla}";
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void RealizarTirada()
        {
            casilla += base.Tirar();
            casilla = base.MayorTablero(casilla);
        }

        public bool VerificarCasilla()
        {
            var tipo = base.VerificarCasilla(casilla);
            switch (tipo)
            {
                case TipoCasilla.Oca:
                    casilla = base.OcoToOca(casilla);
                    break;
                case TipoCasilla.Rio:
                    casilla = base.RioToRio(casilla);
                    break;
                case TipoCasilla.Meta:
                    return true;
                default:
                    return false;
            }
            return false;
        }
    }
}
