using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.JuegoOca
{
    public class Casilla
    {
        private TipoCasilla TipoCasilla { get; set; }
        private string Nombre { get; set; }

        public Casilla(TipoCasilla tipo, string nombre)
        {
            TipoCasilla = tipo;
            Nombre = nombre;
        }

        public TipoCasilla GetCasilla()
        {
            return TipoCasilla;
        }

        public string GetNombreCasilla()
        {
            return Nombre;
        }
    }
}
