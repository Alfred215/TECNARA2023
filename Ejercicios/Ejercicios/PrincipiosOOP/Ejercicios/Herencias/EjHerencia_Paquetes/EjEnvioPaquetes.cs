using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Paquetes
{
    public class EjEnvioPaquetes
    {
        public void EjercicioEnvioPaquetes()
        {
            Envio envio = new Envio();

            PaquetePequeño pp1 = new PaquetePequeño();
            PaquetePequeño pp2 = new PaquetePequeño();
            PaqueteMediano pm1 = new PaqueteMediano();

            envio.AgregarPaquete(pp1);
            envio.AgregarPaquete(pp2);
            envio.AgregarPaquete(pm1);

            Console.WriteLine("Información de los paquetes:");

            foreach (Paquete paquete in envio.paquetes)
            {
                paquete.MostrarInformacion();
                Console.WriteLine();
            }

            envio.CalcularCostoEnvio();
        }
    }
}
