using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Ejercicio1
{
    public class Camion : Vehiculo
    {
        public Camion(string matricula, string marca, string color, int diasAlquiler)
        : base(matricula, marca, color, diasAlquiler)
        {
        }

        public override decimal CalcularPrecioAlquiler()
        {
            decimal precioBase = DiasAlquiler * 50;
            return precioBase + 40m;
        }
    }
}
