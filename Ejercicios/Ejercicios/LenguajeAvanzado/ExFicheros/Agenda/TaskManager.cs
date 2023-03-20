using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExFicheros.Agenda
{
    public class TaskManager
    {
        string filename;
        List<Task> tasks = new List<Task>();

        public TaskManager()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..");
            string fullpath = Path.GetFullPath(path);
            string realPath = Path.Combine(fullpath, $"LenguajeAvanzado\\ExFicheros\\Agenda");
            filename = Path.Combine(realPath, "tasks.txt"); 

            LoadTasks();
        }

        public void AddTask(string name)
        {
            tasks.Add(new Task(name));
            SaveTasks();
        }

        public void ListTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No hay tareas pendientes.");
            }
            else
            {
                Console.WriteLine("Tareas pendientes:");
                foreach (Task task in tasks)
                {
                    if (!task.IsComplete)
                    {
                        Console.WriteLine(task);
                    }
                }
            }
        }

        public void MarkAsComplete(int index)
        {
            if (index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("La tarea especificada no existe.");
            }
            else
            {
                tasks[index].MarkAsComplete();
                SaveTasks();
            }
        }

        private void LoadTasks()
        {
            try
            {
                foreach (string line in File.ReadLines(filename))
                {
                    tasks.Add(new Task(line));
                }
            }
            catch (FileNotFoundException)
            {
                // Si el archivo no existe, no hay tareas que cargar
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al leer el archivo de tareas: " + e.Message);
            }
        }

        private void SaveTasks()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Task task in tasks)
                    {
                        writer.WriteLine(task.Name);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al escribir en el archivo de tareas: " + e.Message);
            }
        }

    }
}
