using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjemploClase.Ejemplo1
{
    public class Ejemplo_Persona
    {
        Persona nuevaPersona = new Persona("Nombre", "Apellidos", 23) 
        { 
            Nombre = "",
            Apellidos = "",
            Edad = 21
        };

        public void Ejercicio()
        {
            Console.WriteLine(nuevaPersona.GetNombreApellidos());
            Console.WriteLine("Introduce Nombre:");
            nuevaPersona.Nombre = Console.ReadLine();
            Console.WriteLine(nuevaPersona.GetNombreApellidos());

        }
    }
}
