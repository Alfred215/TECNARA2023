using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Garaje
{
    public abstract class Vehiculo
    {
        public string Modelo { get; set; }

        public abstract void Acelerar();
    }

    public class Coche : Vehiculo
    {
        public int NumeroDePuertas { get; set; }

        public override void Acelerar()
        {
            Console.WriteLine("El coche acelera");
        }
    }

    public class Moto : Vehiculo
    {
        public string TipoDeMoto { get; set; }

        public override void Acelerar()
        {
            Console.WriteLine("La moto acelera");
        }
    }
}
