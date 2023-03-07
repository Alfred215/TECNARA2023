using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.HerenciaProfesor.Ej1
{
    public class ejVehiculosGarajes
    {
        public void comprobar()
        {

            Coche c = new Coche();
            c.Modelo = "Citroen";
            c.numeroPuertas = 5;

            Moto m = new Moto();
            m.Modelo = "Suzuki";
            m.TipoMoto = "Molona";

            garaje g = new garaje();
            g.AddVehiculo(c);
            g.AddVehiculo(m);

            g.AceleraTodo();
        }
    }
}
