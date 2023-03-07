using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.HerenciaProfesor.Ej1
{
    public abstract class vehiculo
    {
        public string Modelo { get; set; }

        public abstract void Acelerar();

        //public virtual void Acelerar()
        //{
        //    Console.WriteLine("brum brum");
        //}
    }

    public class Coche : vehiculo
    {
        public int numeroPuertas { get; set; }

        public override void Acelerar()
        {
            Console.WriteLine("el coche ha arrancado");
        }

        public void CambiarPuertas(int nPuerta)
        {
            numeroPuertas = nPuerta;
        }
    }

    public class Moto : vehiculo
    {
        public string TipoMoto { get; set; }

        public override void Acelerar()
        {
            Console.WriteLine("La moto hace brrrrrrrrrrr");
        }

    }
}
