using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Enums.EjDiasLaborales
{
    public class EjDiasLaborales
    {
        public EjDiasLaborales()
        {
            Console.WriteLine("Como se llama la empresa: ");
            var empresa = Console.ReadLine();
            Console.WriteLine("Qué día entraste? (yyyy/MM/dd): ");
            var fechaEntrada = Console.ReadLine();
            Console.WriteLine("Qué día te fuiste (yyyy/MM/dd): ");
            var fechaSalida = Console.ReadLine();

            DiasLaborales dias = new DiasLaborales() 
            {
                NombreEmpresa = empresa, 
                FechaEntrada = new DateTime(Convert.ToInt32(fechaEntrada.Split('/')[0]), Convert.ToInt32(fechaEntrada.Split('/')[1]), Convert.ToInt32(fechaEntrada.Split('/')[2])), 
                FechaSalida = new DateTime(Convert.ToInt32(fechaSalida.Split('/')[0]), Convert.ToInt32(fechaSalida.Split('/')[1]), Convert.ToInt32(fechaSalida.Split('/')[2]))
            };

            dias.GetDiasLaborales();
        }
    }
}
