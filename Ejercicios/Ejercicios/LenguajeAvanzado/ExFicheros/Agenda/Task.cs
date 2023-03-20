using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExFicheros.Agenda
{
    public class Task
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; }

        public Task(string name)
        {
            Name = name;
            IsComplete = false;
        }

        public void MarkAsComplete()
        {
            IsComplete = true;
        }

        public override string ToString()
        {
            string status = IsComplete ? "[X]" : "[ ]";
            return status + " " + Name;
        }
    }
}
