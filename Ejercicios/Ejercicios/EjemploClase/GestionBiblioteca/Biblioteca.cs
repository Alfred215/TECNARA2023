using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjemploClase.GestionBiblioteca
{
    public class Biblioteca
    {
        private List<Book> libros;

        public Biblioteca()
        {
            libros = new List<Book>();

            #region addBooks
            libros.Add(new Book("Cien años de soledad", "Gabriel García Márquez", 1967, "Novela", libros.Count + 1));
            libros.Add(new Book("La Odisea", "Homero", -800, "Epopeya", libros.Count + 1));
            libros.Add(new Book("La Iliada", "Homero", -800, "Epopeya", libros.Count + 1));
            libros.Add(new Book("1984", "George Orwell", 1949, "Ciencia Ficción", libros.Count + 1));
            libros.Add(new Book("Don Quijote de la Mancha", "Miguel de Cervantes", 1605, "Novela", libros.Count + 1));

            libros.Add(new Book("101 Dálmatas", "Dodie Smith", 1956, "Infantil", libros.Count + 1));
            libros.Add(new Book("La Sirenita", "Hans Christian Andersen", 1837, "Infantil", libros.Count + 1));
            libros.Add(new Book("Blancanieves y los siete enanitos", "Hermanos Grimm", 1812, "Infantil", libros.Count + 1));
            libros.Add(new Book("Pinocho", "Carlo Collodi", 1883, "Infantil", libros.Count + 1));
            libros.Add(new Book("Peter Pan", "J. M. Barrie", 1911, "Infantil", libros.Count + 1)); 
            #endregion
        }

        public void agregarLibro(string tittle, string auth, int year, string genre)
        {
            libros.Add(new Book(tittle, auth, year, genre, libros.Count + 1));
        }

        public void addBook()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Introduce el título:");
            string titulo = Console.ReadLine();
            Console.WriteLine("Introduce el autor:");
            string autor = Console.ReadLine();
            Console.WriteLine("Introduce el año de publicación:");
            int año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el género:");
            string genero = Console.ReadLine();
            int codigo = libros.Count + 1;
            libros.Add(new Book(titulo, autor, año, genero, codigo));
            Console.WriteLine("Libro añadido con éxito. Código asignado: " + codigo);

            Console.ResetColor();

        }

        public void rentBook()
        {

            Console.WriteLine("Introduce el código del libro que quieres alquilar:");
            int codigo = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;
            foreach (Book libro in libros)
            {
                if (libro.Code == codigo)
                {
                    encontrado = true;
                    if (libro.isRented)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lo siento, el libro ya está alquilado.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        libro.isRented = true;
                        Console.WriteLine($"{libro.Tittle} alquilado con éxito.");
                    }
                }
            }
            if (!encontrado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lo siento, el código introducido no existe.");
            }
            Console.ResetColor();

        }

        public void searchBook()
        {
            Console.WriteLine("Introduce el título del libro que quieres buscar:");
            string titulo = Console.ReadLine();
            bool encontrado = false;
            foreach (Book libro in libros)
            {
                if (libro.Tittle.ToLower() == titulo.ToLower())
                {
                    encontrado = true;
                    Console.WriteLine("Título: " + libro.Tittle);
                    Console.WriteLine("Autor: " + libro.Auth);
                    Console.WriteLine("Año: " + libro.Year);
                    Console.WriteLine("Género: " + libro.Genre);
                    if (libro.isRented)
                    {
                        Console.WriteLine("Estado: Alquilado");
                    }
                    else
                    {
                        Console.WriteLine("Estado: Disponible");
                    }
                    //Console.WriteLine(libro.isRented ? "Alquilado" : "Disponible");
                }
            }
            if (!encontrado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lo siento, el título introducido no existe.");
            }
            Console.ResetColor();

        }

        public void bookListByGenre()
        {
            Console.WriteLine("Introduce el género:");
            string genero = Console.ReadLine();
            bool encontrado = false;
            foreach (Book libro in libros)
            {
                if (libro.Genre.ToLower() == genero.ToLower())
                {
                    Console.WriteLine("\t-" + libro.Tittle.ToString());
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No se han encontrado libros del género indicado.");
            }
            Console.ResetColor();

        }

        public void bookListRented()
        {
            bool encontrado = false;
            foreach (Book libro in libros)
            {
                if (libro.isRented)
                {
                    Console.WriteLine("\t-" + libro.Tittle.ToString());
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No hay libros alquilados en estos momentos.");
            }
            Console.ResetColor();

        }

        public void bookListAvailable()
        {
            bool encontrado = false;
            foreach (Book libro in libros)
            {
                if (!libro.isRented)
                {
                    Console.WriteLine("\t-" + libro.Tittle.ToString());
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No hay libros disponibles en estos momentos.");
            }
            Console.ResetColor();

        }

        public void returnRentedBook()
        {
            Console.WriteLine("Introduce el código del libro que quieres devolver:");
            int codigo = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;
            foreach (Book libro in libros)
            {
                if (libro.Code == codigo)
                {
                    if (!libro.isRented)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("El libro no está alquilado.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        libro.isRented = false;
                        Console.WriteLine("El libro ha sido devuelto.");
                    }
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El libro no existe.");
            }
            Console.ResetColor();

        }

        public Book selectedBook(string tittle)
        {
            return libros.FirstOrDefault(x => x.Tittle == tittle);
        }
    }
}
