using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.RueletaDeLaSuerte
{
    public class Jugador : Ruleta
    {
        private string Nombre;
        private int PuntucacionTotal = 0;

        public Jugador(string nombre) : base() 
        {
            this.Nombre = nombre;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void Tirada(int cantidad)
        {
            base.Tirada(cantidad);
        }

        public int GetPuntos()
        {
            return base.GetPuntos();
        }

        public void SumarPuntosTotal()
        {
            PuntucacionTotal += base.GetPuntos();
        }
    }
}
