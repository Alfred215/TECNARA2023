using Ejercicios.OOP.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjemploClase.Ejemplo_Static
{
    public class Ejemplo_Static
    {
        // Crear varias instancias de la clase BancoStatic
        BancoStatic cuenta1 = new BancoStatic(100.00);
        BancoStatic cuenta2 = new BancoStatic(200.00);
        BancoStatic cuenta3 = new BancoStatic(300.00);

        double total = BancoStatic.DineroCompartido;

        public void ComprobarStatic()
        { 
            // Realizar algunas transacciones en las cuentas
            cuenta1.Depositar(50.00);
            cuenta2.Retirar(25.00);
            cuenta3.Depositar(100.00);

            // Imprimir el saldo y el total de dinero en cada cuenta
            Console.WriteLine("Saldo de cuenta 1: " + cuenta1.SaldoIndividual);
            Console.WriteLine("Total de dinero en todas las cuentas: " + BancoStatic.DineroCompartido);

            Console.WriteLine("Saldo de cuenta 2: " + cuenta2.SaldoIndividual);
            Console.WriteLine("Total de dinero en todas las cuentas: " + BancoStatic.DineroCompartido);

            Console.WriteLine("Saldo de cuenta 3: " + cuenta3.SaldoIndividual);
            Console.WriteLine("Total de dinero en todas las cuentas: " + BancoStatic.DineroCompartido);

            Console.ReadKey();
        }
    }
}
