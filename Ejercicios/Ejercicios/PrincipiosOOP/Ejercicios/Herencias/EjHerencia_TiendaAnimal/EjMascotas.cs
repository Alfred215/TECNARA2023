using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_TiendaAnimal
{
    public class EjMascotas
    {
        public EjMascotas()
        {
            TiendaAnimal tienda = new TiendaAnimal();

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n-- Tienda de Mascotas --");
                Console.WriteLine("1. Agregar mascota");
                Console.WriteLine("2. Mostrar todas las mascotas");
                Console.WriteLine("3. Salir");

                Console.Write("\nIngrese una opción: ");
                string opcion = Console.ReadLine();

                //OPCIONAL: Mostrar listado filtrado por tipo, por precio, etc.

                switch (opcion)
                {
                    case "1":
                        tienda.AgregarMascota();
                        break;
                    case "2":
                        tienda.MostrarTodos();
                        break;
                    case "3":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
