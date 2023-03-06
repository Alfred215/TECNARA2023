using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Pago
{
    public abstract class MetodoDePago
    {
        public string Nombre { get; set; }

        public abstract void RealizarPago(double monto);
    }

    public class TarjetaDeCredito : MetodoDePago
    {
        public string NumeroDeTarjeta { get; set; }

        public override void RealizarPago(double monto)
        {
            Console.WriteLine($"Se ha realizado un pago de {monto} dólares con tarjeta de crédito");
        }
    }

    public class PayPal : MetodoDePago
    {
        public string DireccionDeCorreoElectronico { get; set; }

        public override void RealizarPago(double monto)
        {
            Console.WriteLine($"Se ha realizado un pago de {monto} dólares con PayPal");
        }
    }
}
