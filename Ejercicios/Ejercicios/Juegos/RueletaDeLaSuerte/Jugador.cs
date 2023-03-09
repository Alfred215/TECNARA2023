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
        private TipoJugador Tipo = TipoJugador.Juega;

        public Jugador(string nombre) : base() 
        {
            this.Nombre = nombre;
        }

        #region Get
        public string GetNombre()
        {
            return Nombre;
        }

        public int GetPuntos()
        {
            return base.GetPuntos();
        }

        public int GetPuntosTotales()
        {
            return PuntucacionTotal;
        }

        public TipoJugador GetTipo()
        {
            return Tipo;
        }
        #endregion

        #region Acciones 
        public void Tirada(int cantidad)
        {
            base.Tirada(cantidad);
        }

        public void SumarPuntosTotal()
        {
            PuntucacionTotal += base.GetPuntos();
        }
        #endregion

        #region Set Tipo de jugador
        public void SetTipoJuega()
        {
            Tipo = TipoJugador.Juega;
        }

        public void SetTipoJugando()
        {
            Tipo = TipoJugador.Jugando;
        }

        public void SetTipoGana()
        {
            Tipo = TipoJugador.Ganador;
        }

        public void SetTipoEliminado()
        {
            Tipo = TipoJugador.Eliminado;
        }
        #endregion
    }
}
