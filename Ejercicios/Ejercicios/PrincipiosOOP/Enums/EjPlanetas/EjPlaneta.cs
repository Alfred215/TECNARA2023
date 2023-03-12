using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Enums.EjPlanetas
{
    public class EjPlaneta
    {
        public void EjCalcularTempPlaneta()
        {
            Planeta tierra = new Planeta
            {
                Nombre = "Tierra",
                DistanciaSol = 149600000,
                TipoAtmosfera = TipoAtmosferaPlaneta.AtmosferaRespirable
            };

            double temperaturaTierra = tierra.CalcularTemperatura(tierra.DistanciaSol);
            Console.WriteLine($"La temperatura promedio en {tierra.Nombre} es de {temperaturaTierra} grados Celsius.");

        }
    }
}
