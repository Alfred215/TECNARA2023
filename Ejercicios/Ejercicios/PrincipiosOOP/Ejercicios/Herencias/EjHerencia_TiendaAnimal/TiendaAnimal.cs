using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_TiendaAnimal
{
    public class TiendaAnimal
    {
        private List<Mascota> mascotas;

        public TiendaAnimal()
        {
            mascotas = new List<Mascota>();
        }

        public void AgregarMascota()
        {
            Console.WriteLine("Ingrese los datos de la mascota:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Tipo de animal (perro, gato o pajaro): ");
            string tipo = Console.ReadLine().ToLower();
            var tipEnum = TipoDeAnimal.None;
            if (tipo.Contains("perro"))
            {
                tipEnum = TipoDeAnimal.Perro;
            } else if (tipo.Contains("gato"))
            {
                tipEnum = TipoDeAnimal.Gato;
            } else if (tipo.Contains("pajaro"))
            {
                tipEnum = TipoDeAnimal.Pajaro;
            }


            Console.Write("Color de pelaje: ");
            string colorPelaje = Console.ReadLine();
            Console.Write("Precio: ");
            double precio = double.Parse(Console.ReadLine());

            Mascota mascota = null;
            switch (tipo)
            {
                case "perro":
                    Console.Write("Raza: ");
                    string raza = Console.ReadLine();
                    Console.Write("Entrenado (si/no): ");
                    bool esEntrenado = Console.ReadLine().ToLower() == "si";
                    mascota = new Perro
                    {
                        Nombre = nombre,
                        Edad = edad,
                        Tipo = tipEnum,
                        ColorPelaje = colorPelaje,
                        Precio = precio,
                        Raza = raza,
                        EsEntrenado = esEntrenado
                    };
                    break;
                case "gato":
                    Console.Write("Cazador (si/no): ");
                    bool esCazador = Console.ReadLine().ToLower() == "si";
                    mascota = new Gato
                    {
                        Nombre = nombre,
                        Edad = edad,
                        Tipo = tipEnum,
                        ColorPelaje = colorPelaje,
                        Precio = precio,
                        EsCazador = esCazador
                    };
                    break;
                case "pajaro":
                    Console.Write("Especie: ");
                    string especie = Console.ReadLine();
                    Console.Write("Cantante (si/no): ");
                    bool esCantante = Console.ReadLine().ToLower() == "si";
                    mascota = new Pajaro
                    {
                        Nombre = nombre,
                        Edad = edad,
                        Tipo = tipEnum,
                        ColorPelaje = colorPelaje,
                        Precio = precio,
                        Especie = especie,
                        EsCantante = esCantante
                    };
                    break;
                default:
                    Console.WriteLine("Tipo de animal no válido.");
                    return;
            }
            mascotas.Add(mascota);
            Console.WriteLine("Mascota agregada correctamente.");
        }

        public void MostrarTodos()
        {
            Console.WriteLine("\nMascotas en la tienda:");

            var mascotasOrdenadasPorTipo = mascotas.OrderBy(m => m.Tipo);

            foreach (var mascota in mascotasOrdenadasPorTipo)
            {
                Console.WriteLine($"\n{mascota.Tipo}:");
                Console.WriteLine($"Nombre: {mascota.Nombre}");
                Console.WriteLine($"Edad: {mascota.Edad}");
                Console.WriteLine($"Color de pelaje: {mascota.ColorPelaje}");
                Console.WriteLine($"Precio: {mascota.Precio} €");

                if (mascota is Perro perro)
                {
                    Console.WriteLine($"Raza: {perro.Raza}");
                    Console.WriteLine($"Entrenado: {(perro.EsEntrenado ? "Sí" : "No")}");
                }
                else if (mascota is Gato gato)
                {
                    Console.WriteLine($"Cazador: {(gato.EsCazador ? "Sí" : "No")}");
                }
                else if (mascota is Pajaro pajaro)
                {
                    Console.WriteLine($"Especie: {pajaro.Especie}");
                    Console.WriteLine($"Cantante: {(pajaro.EsCantante ? "Sí" : "No")}");
                }
            }
        }
    }
}
