using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjemploClase.Ejemplo_Static_Id
{
    public class ListaPersonas
    {
        public static List<Persona> Lista { get; set; }
        public static void Mostrar() {
            Console.WriteLine("Listado de personas:");
            foreach (var persona in Lista)
            {
                Console.WriteLine($"ID: {persona.Id} - {persona.Name}");
            }
        }

        public void AñadirYVerPersonas()
        {
            var persona1 = new Persona("Paquita");
            var persona2 = new Persona("Rodrigo", "Perez");
            var persona3 = new Persona("Enrique");

            // Agregamos las personas a la lista
            ListaPersonas.Lista = new List<Persona>() { persona1, persona2, persona3 };

            // Mostramos el listado de personas
            ListaPersonas.Mostrar();

            // Esperamos a que el usuario presione una tecla para cerrar la aplicación
            Console.ReadKey();
        }
    }
}
