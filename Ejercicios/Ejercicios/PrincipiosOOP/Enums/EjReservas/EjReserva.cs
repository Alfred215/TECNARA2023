using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Enums.EjReservas
{
    public class EjReserva
    {
        public EjReserva()
        {
            List<Reserva> listReserva = new List<Reserva>()
            {
                new Reserva(){NombreHuesped = "Pepito",FechaEntrada = new DateTime(2023,03,15), FechaSalida = new DateTime(2023,03,30)},
                new Reserva(){NombreHuesped = "Juanjo",FechaEntrada = new DateTime(2023,04,01), FechaSalida = new DateTime(2023,04,06)},
                new Reserva(){NombreHuesped = "Marta",FechaEntrada = new DateTime(2023,03,23), FechaSalida = new DateTime(2023,04,30)},
                new Reserva(){NombreHuesped = "Lucia",FechaEntrada = new DateTime(2023,03,14), FechaSalida = new DateTime(2023,07,02)},
            };

            foreach(var reserva in listReserva)
            {
                Console.WriteLine("{0} ha resrvado por {1} dias", reserva.NombreHuesped, reserva.Duracion());
            }
        }
    }
}
