using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Paquetes
{
    class Paquete
    {
        public double PesoMaximo { get; set; }
        public double CostoEnvio { get; set; }
        public string Descripcion { get; set; }

        public Paquete(double pesoMaximo, double costoEnvio, string descripcion)
        {
            PesoMaximo = pesoMaximo;
            CostoEnvio = costoEnvio;
            Descripcion = descripcion;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Descripción: {Descripcion}\n" +
                              $"Peso máximo permitido: {PesoMaximo} kg\n" +
                              $"Costo de envío: ${CostoEnvio}\n");
        }
    }

    class PaquetePequeño : Paquete
    {
        public PaquetePequeño() : base(1, 10, "Paquete pequeño") { }
    }

    class PaqueteMediano : Paquete
    {
        public PaqueteMediano() : base(5, 25, "Paquete mediano") { }
    }

    class PaqueteGrande : Paquete
    {
        public PaqueteGrande() : base(10, 50, "Paquete grande") { }
    }
}
