using Ejercicios.PrincipiosOOP.Ejercicios.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioVehiculo
{
    public class VehiculoPasajeros : Vehiculo
    {
        private int plazas;
        private int dias;

        public VehiculoPasajeros(string matricula, string marca, string color, int diasAlquiler, int plazas)
            : base(matricula, marca, color, diasAlquiler)
        {
            this.plazas = plazas;
            this.dias = diasAlquiler;
        }
        public override decimal CalcularPrecioAlquiler()
        {
            decimal precioBase = base.CalcularPrecioAlquiler();
            decimal precioPlazas = plazas * dias * 1.5m;
            return precioBase + precioPlazas;
        }
    }
}
