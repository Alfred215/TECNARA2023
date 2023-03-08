using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Monedas
{
    public class EjMonedas
    {
        public EjMonedas() {
            Console.WriteLine("Introduce la cantidad de euros que deseas convertir.");
            double cantidadEnEuros = Convert.ToInt32(Console.ReadLine());
            Euro euro = new Euro();
            Dolar dolar = new Dolar();

            double cantidadEnDolares = CambioDeMoneda.realizarCambio(cantidadEnEuros, euro, dolar);

            Console.WriteLine("{0} euros equivalen a {1} dólares", cantidadEnEuros, cantidadEnDolares);
        }
    }
}
