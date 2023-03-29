using Ejercicios.BBDD.Ejercicios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios.Ejercicio2_BBDD
{
    public class Ejercicio2_BBDD
    {
        Metodos2_BBDD metodos;
        dbContextEjercicios db;
        public Ejercicio2_BBDD(dbContextEjercicios _db) 
        {
            db = _db;
            metodos = new Metodos2_BBDD(db);
            Consultas();
        }

        public void Consultas()
        {
            int accion = 0;
            do
            {
                Console.WriteLine("\n1-Crear o Editar Cliente \n2-Crear o Editar Empleado \n3-Listar Clientes \n4-Listar Empleados \n5-Eliminar Cliente \n6-Eliminar Empleado \n7-Calcular Coste \n8-Salir");
                accion = Convert.ToInt32(Console.ReadLine());

                switch (accion)
                {
                    case 1:
                        metodos.AddEdit(CreateCliente());
                        Console.Clear();
                        break;
                    case 2:
                        metodos.AddEdit(CreateEmpleado());
                        Console.Clear();
                        break;
                    case 3:
                        metodos.GetListClient();
                        break;
                    case 4:
                        metodos.GetListEmpleado();
                        break;
                    case 5:
                        Console.WriteLine("Que Cliente quieres eliminar:");
                        metodos.DeleteClient(Convert.ToInt32(Console.ReadLine()));
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Que Cliente quieres eliminar:");
                        metodos.Delete(Convert.ToInt32(Console.ReadLine()));
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("Id del cliente para calcular coste:");
                        metodos.CalcularCoste(Convert.ToInt32(Console.ReadLine()));
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
