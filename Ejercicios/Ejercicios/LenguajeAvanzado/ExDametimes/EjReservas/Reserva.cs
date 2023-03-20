using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExDametimes.EjReservas
{
    public class Reserva
    {
        public string NombreHuesped { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }

        public int Duracion()
        {
            var dias = FechaEntrada - FechaSalida;
            return dias.Days * -1;
        }
    }
}
