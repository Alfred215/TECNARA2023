using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Pago
{
    public class EjPago
    {
        public void EjercicioPago()
        {
            TarjetaDeCredito tarjeta = new TarjetaDeCredito();
            tarjeta.Nombre = "Visa";
            tarjeta.NumeroDeTarjeta = "1234567890";

            PayPal paypal = new PayPal();
            paypal.Nombre = "PayPal";
            paypal.DireccionDeCorreoElectronico = "ejemplo@paypal.com";

            CarritoDeCompras carrito = new CarritoDeCompras();
            carrito.AgregarProducto("Cocacola");
            carrito.AgregarProducto("Fanta naranja");

            carrito.SeleccionarMetodoDePago(tarjeta);
            carrito.ProcesarPago(100.0); 
            // Imprime "Se ha realizado un pago de 100 dólares con tarjeta de crédito"

            carrito.SeleccionarMetodoDePago(paypal);
            carrito.ProcesarPago(50.0); 
            // Imprime "Se ha realizado un pago de 50 dólares con PayPal"

        }
    }
}
