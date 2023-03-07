using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Paquetes
{
    class Envio
    {
        public List<Paquete> paquetes = new List<Paquete>();

        public void AgregarPaquete(Paquete paquete)
        {
            paquetes.Add(paquete);
        }

        public void CalcularCostoEnvio()
        {
            double costoTotal = 0;

            foreach (Paquete paquete in paquetes)
            {
                costoTotal += paquete.CostoEnvio;
            }

            Console.WriteLine("Costo total del envío: ${0}", costoTotal);
        }
    }
}
