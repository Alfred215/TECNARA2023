using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Garaje
{
    public class Garaje
    {
        private List<Vehiculo> vehiculos;

        public Garaje()
        {
            vehiculos = new List<Vehiculo>();
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }

        public void AcelerarTodos()
        {
            foreach (Vehiculo vehiculo in vehiculos)
            {
                vehiculo.Acelerar();
            }
        }
    }
}
