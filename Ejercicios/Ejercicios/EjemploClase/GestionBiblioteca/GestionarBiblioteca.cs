using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjemploClase.GestionBiblioteca
{
    public class GestionarBiblioteca
    {
        public void Gestion() {
            Biblioteca biblioteca = new Biblioteca();
            int opcion = 0;

            while (opcion != 8)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("----- GESTIÓN DE BIBLIOTECA -----");
                Console.WriteLine("1 - Añadir nuevo libro");
                Console.WriteLine("2 - Alquilar libro");
                Console.WriteLine("3 - Buscar libro");
                Console.WriteLine("4 - Mostrar listado de todos los libros de un determinado género");
                Console.WriteLine("5 - Mostrar listado de libros alquilados");
                Console.WriteLine("6 - Mostrar listado de libros disponibles (no alquilados)");
                Console.WriteLine("7 - Devolver un libro");
                Console.WriteLine("8 - Salir");
                Console.WriteLine("Elige una opción:");
                Console.ResetColor();

                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        biblioteca.addBook();
                        break;
                    case 2:
                        biblioteca.rentBook();
                        break;
                    case 3:
                        biblioteca.searchBook();
                        break;
                    case 4:
                        biblioteca.bookListByGenre();
                        break;
                    case 5:
                        biblioteca.bookListRented();
                        break;
                    case 6:
                        biblioteca.bookListAvailable();
                        break;
                    case 7:
                        biblioteca.returnRentedBook();
                        break;
                    case 8:
                        Console.WriteLine("¡Hasta pronto!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige otra.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
