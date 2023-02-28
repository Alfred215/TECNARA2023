using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjemploClase.Ejemplo_Herencia
{
    public class EjercicioHerenciaTrabajador
    {

        static List<Trabajador> trabajadores = new List<Trabajador>();

        public void EjercicioHerenciaTrabajadorCode()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1- Introducción de datos");
                Console.WriteLine("2- Mostrar datos introducidos");
                Console.WriteLine("3- Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        IntroducirDatos();
                        break;
                    case 2:
                        MostrarDatos();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Seleccione otra opción.");
                        break;
                }

            } while (opcion != 3);
        }

        static void IntroducirDatos()
        {
            Console.WriteLine("INTRODUCCIÓN DE DATOS");
            Console.Write("DNI: ");
            string dni = Console.ReadLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellidos: ");
            string apellidos = Console.ReadLine();
            Console.Write("Salario: ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Fecha de contratación (dd/mm/yyyy): ");
            DateTime fechaContratacion = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            //Trabajador trabajador = new Trabajador()
            //{
            //    DNI = dni,
            //    Nombre = nombre,
            //    Apellidos = apellidos,
            //    Salario = salario,
            //    FechaContratacion = fechaContratacion
            //};

            trabajadores.Add(new Trabajador(dni, nombre, apellidos, salario, fechaContratacion));

            Console.WriteLine("Datos introducidos correctamente.");
        }

        static void MostrarDatos()
        {
            Console.WriteLine("DATOS INTRODUCIDOS");
            Console.WriteLine("DNI\tNombre\tApellidos\tSalario\tFecha de contratación");

            foreach (Trabajador trabajador in trabajadores)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", trabajador.DNI, trabajador.Nombre, trabajador.Apellidos, trabajador.Salario, trabajador.FechaContratacion.ToString("dd/MM/yyyy"));
            }
        }
    }
}
