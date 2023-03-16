using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Enums.EjReunión
{
    public class Reunion
    {
        public List<Disponibilidad> CrearHorariosDisponibles(List<DisponibilidadCompleta> disponibilidad, List<Disponibilidad> horariosDisponibilidad)
        {
            foreach (var item in disponibilidad)
            {
                string participante = item.Participante;
                foreach (var horario in item.Horario)
                {
                    DateTime inicio = horario.Item1;
                    DateTime fin = horario.Item2;
                    horariosDisponibilidad.Add(new Disponibilidad(participante, inicio, fin));
                }
            }

            return horariosDisponibilidad;
        }

        public (DateTime, DateTime) IntervaloTiempo(List<Disponibilidad> horariosDisponibilidad, DateTime horaInicio, DateTime horaFin)
        {
            DateTime intervaloInicio = horaInicio;
            DateTime intervaloFin = horaFin;

            foreach (var horario in horariosDisponibilidad)
            {
                if (horario.Inicio > intervaloInicio)
                {
                    intervaloInicio = horario.Inicio;
                }
                if (horario.Fin < intervaloFin)
                {
                    intervaloFin = horario.Fin;
                }
            }

            return (intervaloInicio, intervaloFin);
        }

    }
}
