using Ejercicios.PrincipiosOOP.Ejercicios.EjercicioVehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Ejercicio1
{
    public class Microbus : VehiculoPasajeros
    {
        private int plazas;

        public Microbus(string matricula, string marca, string color, int diasAlquiler, int plazas)
            : base(matricula, marca, color, diasAlquiler,plazas)
        {
            this.plazas = plazas;
        }

        public override decimal CalcularPrecioAlquiler()
        {
            decimal precioBase = base.CalcularPrecioAlquiler();
            decimal precioAdicional = plazas * 2;

            return precioBase + precioAdicional;
        }
    }

}
