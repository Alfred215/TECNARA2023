using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExFicheros.Agenda
{
    internal class EjTaskManager
    {
        public EjTaskManager()
        {
            TaskManager taskManager = new TaskManager();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Menú principal:");
                Console.WriteLine("1. Crear nueva tarea");
                Console.WriteLine("2. Ver tareas");
                Console.WriteLine("3. Marcar tarea como completada");
                Console.WriteLine("4. Salir");

                Console.Write("Elige una opción: ");
                string option = Console.ReadLine();
                Console.WriteLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Nombre de la tarea: ");
                        string taskName = Console.ReadLine();
                        taskManager.AddTask(taskName);
                        Console.WriteLine("Tarea creada.");
                        break;
                    case "2":
                        taskManager.ListTasks();
                        break;
                    case "3":
                        Console.Write("Índice de la tarea completada: ");
                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            taskManager.MarkAsComplete(index);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del programa.");
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}
