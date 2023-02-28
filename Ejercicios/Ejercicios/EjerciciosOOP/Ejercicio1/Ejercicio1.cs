using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.OOP.Ejercicio2
{
    public class Ejercicio1
    {
        public void Ejercicio()
        {
            List<AsignaturasNotas> objetos = new List<AsignaturasNotas>();

            while (true)
            {
                Console.Write("Ingrese el nombre de la asignatura: (Enter para finalizar) ");
                var asignatura = Console.ReadLine();

                if (!string.IsNullOrEmpty(asignatura))
                {
                    Console.Write("Ingrese la nota: ");
                    var nota = Convert.ToDecimal(Console.ReadLine());

                    objetos.Add(new AsignaturasNotas {Asignatura = asignatura, Nota = nota });
                }
                else
                {
                    break;
                }
            }

            foreach (var lista in objetos)
            {
                Console.ForegroundColor = lista.Nota >= 5 ? ConsoleColor.Green : ConsoleColor.Red;
                string estado = lista.Nota >= 5 ? "Aprobado" : "Suspenso";
                Console.WriteLine("Asignatura {0} - {1} - {2}", lista.Asignatura, lista.Nota, estado);
                Console.ResetColor();
            }
        }
    }
}
