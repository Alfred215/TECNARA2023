using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Enums.EjFutbolTipos
{
    public class EjEquipoFutbol
    {
        public void EjEquipos()
        {
            // Creamos varios objetos de tipo EquipoFutbol
            var equipos = new List<EquipoFutbol>
            {
            new EquipoFutbol { Nombre = "Real Madrid", País = "España", Liga = LigaEnum.LaLiga, PartidosGanados=9, PartidosEmpatados=2 },
            new EquipoFutbol { Nombre = "Barcelona", País = "España", Liga = LigaEnum.LaLiga, PartidosGanados=6, PartidosEmpatados=7 },
            new EquipoFutbol { Nombre = "Juventus", País = "Italia", Liga = LigaEnum.SerieA, PartidosGanados=2, PartidosEmpatados=3 },
            new EquipoFutbol { Nombre = "Bayern Munich", País = "Alemania", Liga = LigaEnum.Bundesliga, PartidosGanados=12, PartidosEmpatados=8 },
            new EquipoFutbol { Nombre = "PSG", País = "Francia", Liga = LigaEnum.Ligue1, PartidosGanados=4, PartidosEmpatados=10 }
            };

            // Calculamos los puntos de cada equipo en la liga LaLiga
            var equiposLaLiga = equipos
             .Where(e => e.Liga == LigaEnum.LaLiga)
             .OrderByDescending(e => e.CalcularPuntosLiga())
             .ToList();

            // Mostramos los equipos de LaLiga ordenados por puntos en consola
            Console.WriteLine("Equipos de LaLiga ordenados por puntos:");
            foreach (var equipo in equiposLaLiga)
            {
                Console.WriteLine($"Nombre: {equipo.Nombre}");
                Console.WriteLine($"Puntos: {equipo.CalcularPuntosLiga()}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
