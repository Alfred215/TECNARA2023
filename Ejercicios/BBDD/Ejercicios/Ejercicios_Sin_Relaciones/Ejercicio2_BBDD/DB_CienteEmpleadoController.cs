using Ejercicios.BBDD.Ejercicios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios.Ejercicio2_BBDD
{
    public class DB_CienteEmpleadoController
    {
        DB_ClienteEmpleadoServicio service;

        public DB_CienteEmpleadoController(dbContextEjercicios _db) 
        {
            service = new DB_ClienteEmpleadoServicio(_db);
            IniciarMenu();
        }

        public void IniciarMenu()
        {
            int accion = 0;
            do
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("1- Crear o Editar Cliente");
                Console.WriteLine("2- Crear o Editar Empleado");
                Console.WriteLine("3- Listar Clientes");
                Console.WriteLine("4- Listar Empleados");
                Console.WriteLine("5- Eliminar Cliente");
                Console.WriteLine("6- Eliminar Empleado");
                Console.WriteLine("7- Calcular Coste");
                Console.WriteLine("8- Salir");
                Console.ResetColor();

                accion = Convert.ToInt32(Console.ReadLine());

                switch (accion)
                {
                    case 1:
                        service.AddEdit_CLI(CreateCliente());
                        Console.Clear();
                        break;
                    case 2:
                        service.AddEdit_EMP(CreateEmpleado());
                        Console.Clear();
                        break;
                    case 3:
                        service.GetList_CLI();
                        break;
                    case 4:
                        service.GetList_EMP();
                        break;
                    case 5:
                        Console.Write("¿Qué CLIENTE quieres eliminar?");
                        service.Delete_CLI(Convert.ToInt32(Console.ReadLine()));
                        Console.Clear();
                        break;
                    case 6:
                        Console.Write("¿Qué EMPLEADO quieres eliminar?");
                        service.Delete_EMP(Convert.ToInt32(Console.ReadLine()));
                        Console.Clear();
                        break;
                    case 7:
                        Console.Write("Escribe el Id del CLIENTE para calcular coste:");
                        service.CalcularCoste(Convert.ToInt32(Console.ReadLine()));
                        break;
                    default:
                        break;

                }
                
            } while (accion != 8 && accion < 8);
        }

        public Empleado CreateEmpleado()
        {
            Empleado empleado = new Empleado();

            Console.WriteLine("Id:");
            empleado.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre:");
            empleado.Nombre = Console.ReadLine();
            Console.WriteLine("Puesto:");
            empleado.Puesto = Console.ReadLine();
            Console.WriteLine("Empresa:");
            empleado.Empresa = Console.ReadLine();
            Console.WriteLine("Hora de entrada: (hh:mm:ss)");
            var horaEntrada = Console.ReadLine().Split(":");
            empleado.HoraEntrada = new TimeSpan(Convert.ToInt32(horaEntrada[0]), Convert.ToInt32(horaEntrada[1]), Convert.ToInt32(horaEntrada[2]));
            Console.WriteLine("Hora de salida: (hh:mm:ss)");
            var horaSalida = Console.ReadLine().Split(":");
            empleado.HoraSalida = new TimeSpan(Convert.ToInt32(horaSalida[0]), Convert.ToInt32(horaSalida[1]), Convert.ToInt32(horaSalida[2]));
            Console.WriteLine("Precio de la hora:");
            empleado.PrecioPorHora = Convert.ToInt32(Console.ReadLine());

            return empleado;
        }

        public Cliente CreateCliente()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Id:");
            cliente.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre:");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Saldo:");
            cliente.Saldo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Horas de servicio:");
            cliente.HoraDeServicio = Convert.ToInt32(Console.ReadLine());

            return cliente;
        }
    }
}
