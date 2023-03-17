using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Enums.EjDiasLaborales
{
    public class DiasLaborales
    {
        public string NombreEmpresa { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }

        public void GetDiasLaborales()
        {

            int dia = 1;
            int diasLaborables = 0;

            for(DateTime date = FechaEntrada; date < FechaSalida; date = date.AddDays(1))
            {
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasLaborables++;
                }
            }

            //DateTime fecha = FechaEntrada;
            //do
            //{
            //    int diasEnMes = DateTime.DaysInMonth(fecha.Year, fecha.Month);
            //    for (int i = 0; i <= diasEnMes; i++)
            //    {
            //        fecha = FechaEntrada.AddDays(dia);
            //        if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday && FechaEntrada.AddDays(dia) < FechaSalida)
            //        {
            //            diasLaborables++;
            //        }
            //        dia++;
            //    }
            //} while (FechaEntrada.AddDays(dia) <= FechaSalida);

            Console.WriteLine("Has estado en la empresa {0}, {1} dias laborales", NombreEmpresa, diasLaborables);
        }
    }
}
