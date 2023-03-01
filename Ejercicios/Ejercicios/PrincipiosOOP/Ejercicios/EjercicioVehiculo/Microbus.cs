using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Ejercicio1
{
    public class Microbus : Vehiculo
    {
        private int plazas;

        public Microbus(string matricula, string marca, string color, int diasAlquiler, int plazas)
            : base(matricula, marca, color, diasAlquiler)
        {
            this.plazas = plazas;
        }

        public override decimal CalcularPrecioAlquiler()
        {
            decimal precioBase = DiasAlquiler * 50;
            decimal precioPlazas = plazas * DiasAlquiler * 1.5m;
            decimal precioAdicional = plazas * 2;

            return precioBase + precioPlazas + precioAdicional;
        }
    }

}
