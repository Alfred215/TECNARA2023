using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExDametimes.EjEventos
{
    public class Evento
    {
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public TypeEvent TipoEvento { get; set; }

        public void EsProximo()
        {
            DateTime fechaActual = DateTime.Now;

            if ((Fecha - fechaActual).Days < 7)
            {
                Console.WriteLine("En el evento {0} hay menos de 7 dias ({1} dias) y es de tipo {2}", Nombre, (Fecha - fechaActual).Days, TipoEvento);
            }
            else
            {
                Console.WriteLine("En el evento {0} hay más de 7 dias ({1} dias) y es de tipo {2}", Nombre, (Fecha - fechaActual).Days, TipoEvento);
            }
        }
    }

    public enum TypeEvent
    {
        Concierto = 0,
        Medieval = 1,
        Carrera = 2,
    }
}
