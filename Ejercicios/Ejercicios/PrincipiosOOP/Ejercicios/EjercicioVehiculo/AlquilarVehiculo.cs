using Ejercicios.PrincipiosOOP.Ejercicios.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioVehiculo
{
    public class AlquilarVehiculo
    {
        public void Ejercicio()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>()
            {
                new Coche ("123","Renault","Rojo", 5, 5 ),
                new Coche("321", "Peugeot","Rojo", 3, 7),
                new Microbus("456", "Mercedes", "Verde", 7, 15),
                new Microbus("654", "Iveco", "Amarillo", 2, 9),
                new Furgoneta("789", "Ford", "Blanco", 4),
                new Furgoneta("987", "Citroen", "Gris", 6),
                new Camion("12346789", "Iveco", "Negro", 12),
                new Camion("987654321", "MAN", "Violeta", 50)
            };

            foreach (var vehiculo in vehiculos)
            {
                Console.WriteLine("Matrícula: {0}\tMarca: {1}\tColor: {2}\tPrecio de alquiler: {3}",
                    vehiculo.Matricula, vehiculo.Marca, vehiculo.Color, vehiculo.CalcularPrecioAlquiler());
            }
        }
    }
}
