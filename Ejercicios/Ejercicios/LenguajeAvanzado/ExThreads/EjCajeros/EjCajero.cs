using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExThreads.EjCajeros
{
    internal class EjCajero
    {
        public void TiempoCajero()
        {
            Cajero cajero1 = new Cajero();
            cajero1.Nombre = "Juan";
            cajero1.TipoCajero = TipoCajeroEnum.VIP;
            cajero1.Estado = EstadoCajeroEnum.Disponible;

            Cajero cajero2 = new Cajero();
            cajero2.Nombre = "María";
            cajero2.TipoCajero = TipoCajeroEnum.Express;
            cajero2.Estado = EstadoCajeroEnum.Disponible;

            Console.WriteLine("Iniciando atención de clientes...");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Cliente {i} en espera...");
                Thread th1 = new Thread(new ThreadStart(cajero1.AtenderCliente));
                Thread th2 = new Thread(new ThreadStart(cajero2.AtenderCliente));

                if (cajero1.Estado == EstadoCajeroEnum.Disponible)
                {
                    cajero1.Estado = EstadoCajeroEnum.Ocupado;
                    Console.WriteLine($"Atendiendo cliente {i} en cajero {cajero1.Nombre} ({cajero1.TipoCajero})...");

                    th1.Start();

                    Console.WriteLine($"Cliente {i} atendido en cajero {cajero1.Nombre}");
                }
                else if (cajero2.Estado == EstadoCajeroEnum.Disponible)
                {
                    cajero2.Estado = EstadoCajeroEnum.Ocupado;
                    Console.WriteLine($"Atendiendo cliente {i} en cajero {cajero2.Nombre} ({cajero2.TipoCajero})...");

                    th2.Start();

                    Console.WriteLine($"Cliente {i} atendido en cajero {cajero2.Nombre}");
                }
                else
                {
                    Console.WriteLine("Todos los cajeros están ocupados. Por favor, espere...");
                    i--; // volver a intentar con el mismo cliente
                }
            }

            Console.WriteLine("Fin de atención de clientes. Gracias por su visita.");
            Console.ReadKey();
        }
    }
}
