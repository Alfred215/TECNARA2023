using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.OOP.Ejercicio1
{
    public class Ejercicio2
    {
        public void Ejercicio()
        {
            string[] opciones = { "1-Ingresar efectivo", "2-Retirar efectivo", "3-Listar todos los movimientos", "4-Listar los ingresos", "5-Listar las retiradas", "6-Ver saldo", "7-Salir" };

            Console.WriteLine("Nombre de la cuenta bancaria:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Número de la cuenta bancaria:");
            string numero = Console.ReadLine();

            Console.WriteLine("Saldo de la cuenta:");
            decimal saldo = Convert.ToDecimal(Console.ReadLine());

            CuentaBancaria cuenta = new CuentaBancaria(nombre, numero, saldo);

            int opcion = 6;
            do
            {
                Console.WriteLine("Que desea realizar: ");
                foreach(var accion in opciones)
                {
                    Console.WriteLine(accion);
                }
                opcion = Convert.ToInt32(Console.ReadLine())-1;
                Console.WriteLine();
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("¿Cuento quieres ingresar?");
                        decimal ingreso = Convert.ToDecimal(Console.ReadLine());
                        cuenta.IngrearDinero(ingreso);
                        break;
                    case 1:
                        Console.WriteLine("¿Cuento quieres retirar?");
                        decimal retirada = Convert.ToDecimal(Console.ReadLine());
                        cuenta.RetirarDinero(retirada);
                        break;
                    case 2:
                        var ingresosRetiradas = cuenta.TodosMovimientos();
                        Console.WriteLine("Movimientos => INGRESOS:");
                        foreach (var dinero in ingresosRetiradas)
                        {
                            if (dinero.Ingreso.HasValue)
                            {
                                Console.WriteLine(dinero.Ingreso);
                            }
                        }
                        Console.WriteLine();

                        Console.WriteLine("Movimientos => RETIRADAS:");
                        foreach (var dinero in ingresosRetiradas)
                        {
                            if (dinero.Retirada.HasValue)
                            {
                                Console.WriteLine(dinero.Retirada);
                            }
                        }
                        break;
                    case 3:
                        var ingresosList = cuenta.TodosIngresos();
                        Console.WriteLine("Movimientos => INGRESOS:");
                        foreach (var dinero in ingresosList)
                        {
                            Console.WriteLine(dinero);
                        }
                        break;
                    case 4:
                        var retiradasList = cuenta.TodosIngresos();
                        Console.WriteLine("Movimientos => RETIRADAS:");
                        foreach (var dinero in retiradasList)
                        {
                            Console.WriteLine(dinero);
                        }
                        break;
                    case 5:
                        Console.WriteLine(cuenta.VerSaldo());
                        break;

                }
                Console.WriteLine();
            } while (opcion != 6);

            Console.WriteLine("Has terminado.");
        }
    }
}
