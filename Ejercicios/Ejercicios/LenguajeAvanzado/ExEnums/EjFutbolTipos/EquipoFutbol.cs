using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExEnums.EjFutbolTipos
{
    public class EquipoFutbol
    {
        public string Nombre { get; set; }
        public string País { get; set; }
        public int PartidosGanados { get; set; }
        public int PartidosEmpatados { get; set; }
        public LigaEnum Liga { get; set; }

        public int CalcularPuntosLiga()
        {
            return PartidosGanados * 3 + PartidosEmpatados * 2;
        }
    }

    public enum LigaEnum
    {
        PremierLeague,
        LaLiga,
        SerieA,
        Bundesliga,
        Ligue1
    }
}
