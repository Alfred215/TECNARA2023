using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.HerenciaProfesor.Ej1
{
    public class garaje
    {
        private List<vehiculo> vehiculos; /*= new List<vehiculo>();*/

        public garaje() { 
            vehiculos = new List<vehiculo>();
        }

        public void AddVehiculo(vehiculo v)
        {
            vehiculos.Add(v);
        }

        public void AceleraTodo()
        {
            foreach (var vehi in vehiculos) {
                vehi.Acelerar();            
            }
        }
    }
}
