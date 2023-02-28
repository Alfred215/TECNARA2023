using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjemploClase.Ejemplo_Static
{
    public class BancoStatic
    {
        public static double DineroCompartido { get; set; }
        public double SaldoIndividual { get; set; }

        public BancoStatic(double saldoInicial)
        {
            SaldoIndividual = saldoInicial;
            DineroCompartido += saldoInicial;
        }

        public void Depositar(double cantidad)
        {
            SaldoIndividual += cantidad;
            DineroCompartido += cantidad;
        }

        public void Retirar(double cantidad)
        {
            SaldoIndividual -= cantidad;
            DineroCompartido -= cantidad;
        }
    }
}
