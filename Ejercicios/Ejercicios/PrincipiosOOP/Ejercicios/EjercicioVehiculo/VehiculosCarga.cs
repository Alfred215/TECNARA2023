using Ejercicios.PrincipiosOOP.Ejercicios.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioVehiculo
{
    public class VehiculosCarga : Vehiculo
    {
        public VehiculosCarga(string matricula, string marca, string color, int diasAlquiler)
        : base(matricula, marca, color, diasAlquiler)
        {}

        public override decimal CalcularPrecioAlquiler()
        {
            return base.CalcularPrecioAlquiler() + 20m;
        }
    }
}
