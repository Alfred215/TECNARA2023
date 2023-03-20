using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExDametimes.EjReunión
{
    public class Disponibilidad
    {
        public string Participante { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }

        public Disponibilidad(string participante, DateTime inicio, DateTime fin)
        {
            Participante = participante;
            Inicio = inicio;
            Fin = fin;
        }
    }

    public class DisponibilidadCompleta
    {
        public string Participante { get; set; }

        public List<(DateTime, DateTime)> Horario { get; set; }
    }
}
