using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExDametimes.EjEventos
{
    public class EjEvento
    {
        public EjEvento()
        {
            List<Evento> events = new List<Evento>()
        {
            new Evento() {Nombre = "Carrera Pouplar", Fecha = new DateTime(2023,03,23), TipoEvento = TypeEvent.Carrera},
            new Evento() {Nombre = "Mercadillo", Fecha = new DateTime(2023,03,28),TipoEvento = TypeEvent.Medieval},
            new Evento() {Nombre = "KiddKeo", Fecha = new DateTime(2023,03,16), TipoEvento = TypeEvent.Concierto},
        };

            foreach (var evento in events)
            {
                evento.EsProximo();
            }
        }
    }
}
