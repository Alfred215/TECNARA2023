using Ejercicios.PrincipiosOOP.Ejercicios.EjercicioVehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Ejercicio1
{
    public class Coche : VehiculoPasajeros
    {
        public Coche(string matricula, string marca, string color, int diasAlquiler, int plazas)
            : base(matricula, marca, color, diasAlquiler,plazas)
        {}
    }
}
