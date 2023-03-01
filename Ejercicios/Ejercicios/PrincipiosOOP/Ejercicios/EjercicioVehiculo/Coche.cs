using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Ejercicio1
{
    public class Coche : Vehiculo
    {
        private int plazas;

        public Coche(string matricula, string marca, string color, int diasAlquiler, int plazas)
            : base(matricula, marca, color, diasAlquiler)
        {
            this.plazas = plazas;
        }

        public override decimal CalcularPrecioAlquiler()
        {
            decimal precioBase = DiasAlquiler * 50;
            decimal precioPlazas = plazas * DiasAlquiler * 1.5m;

            return precioBase + precioPlazas;
        }
    }
}
