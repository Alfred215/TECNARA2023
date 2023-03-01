using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjemploClase.EjPoliformismoEmpleado
{
    public class EjercicioEmpleado
    {
        public void Ejercicio()
        {
            Gerente gerente = new Gerente("Paco", 2500, "Informatica");
            Console.WriteLine("Gerente: ");
            gerente.DimeSueldo(3000);

            Director director = new Director("Laura", 3000, "Administración");
            Console.WriteLine("\nDirector:");
            director.DimeSueldo(6000);
        }
    }
}
