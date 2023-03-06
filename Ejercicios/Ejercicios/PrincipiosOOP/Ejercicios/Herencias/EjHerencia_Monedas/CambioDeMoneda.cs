using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Monedas
{
    public class CambioDeMoneda
    {
        public static double realizarCambio(double cantidad, Divisa divisaOrigen, Divisa divisaDestino)
        {
            double cantidadEnDolares = divisaOrigen.convertir(cantidad, new Dolar());
            double cantidadEnDestino = divisaDestino.convertir(cantidadEnDolares, divisaDestino);

            return cantidadEnDestino;
        }
    }
}
