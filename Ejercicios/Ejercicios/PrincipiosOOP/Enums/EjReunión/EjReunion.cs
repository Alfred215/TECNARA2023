using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Enums.EjReunión
{
    public class EjReunion
    {
        public EjReunion() {

            DateTime horaInicio = DateTime.Parse("10:00 AM");
            TimeSpan duracionReunion = TimeSpan.FromHours(2);
            DateTime horaFin = horaInicio.Add(duracionReunion);

            Reunion reunion = new Reunion();

            List<Disponibilidad> horariosDisponibilidad = new List<Disponibilidad>();
            List<DisponibilidadCompleta> disponibilidad = new List<DisponibilidadCompleta>
            {
                new DisponibilidadCompleta(){
                    Participante = "Juan", 
                    Horario = new List<(DateTime, DateTime)>()
                    {
                        (DateTime.Parse("9:00 AM"), DateTime.Parse("12:00 PM")),
                        (DateTime.Parse("2:00 PM"), DateTime.Parse("5:00 PM"))
                    }
                },
                new DisponibilidadCompleta(){
                    Participante = "María",
                    Horario = new List<(DateTime, DateTime)>()
                    {
                        (DateTime.Parse("9:00 AM"), DateTime.Parse("12:00 PM"))
                    }
                },
                new DisponibilidadCompleta(){
                    Participante = "Carlos",
                    Horario = new List<(DateTime, DateTime)>()
                    {
                        (DateTime.Parse("10:00 AM"), DateTime.Parse("1:00 PM")),
                        (DateTime.Parse("3:00 PM"), DateTime.Parse("5:00 PM"))
                    }
                },
                new DisponibilidadCompleta(){
                    Participante = "Ana",
                    Horario = new List<(DateTime, DateTime)>()
                    {
                        (DateTime.Parse("9:00 AM"), DateTime.Parse("11:00 AM")),
                    (DateTime.Parse("1:00 PM"), DateTime.Parse("3:00 PM"))
                    }
                },
            };

            horariosDisponibilidad = reunion.CrearHorariosDisponibles(disponibilidad, horariosDisponibilidad);

            var (intervaloInicio, intervaloFin) = reunion.IntervaloTiempo(horariosDisponibilidad, horaInicio, horaFin);

            TimeSpan duracionIntervalo = intervaloFin - intervaloInicio;
            if (duracionIntervalo < duracionReunion)
            {
                Console.WriteLine("No se puede agendar la reunión en ese horario.");
            }
            else
            {
                DateTime horaFinReunion = intervaloInicio.Add(duracionReunion);
                Console.WriteLine("La reunión puede realizarse de {0} a {1}.", horaInicio.ToString("h:mm tt"), horaFinReunion.ToString("h:mm tt"));
            }
        }
    }
}
