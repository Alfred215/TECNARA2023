using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioEmpresaDeportes
{
    public class Velero : Acuatico
    {
        public Velero(string nombre, float peso, float altura, int plazas, string color, string marca, int numeroVelas)
            : base(nombre, peso, altura, plazas, color, marca, numeroVelas)
        {
        }

        public override void DimeTipoAveria()
        {
            Console.WriteLine("Tiene rota la vela");
        }

        public override void DimeVelocidad()
        {
            Console.WriteLine("32 km/h");
        }

        public override void Navegar()
        {
            Console.WriteLine("Estas navegando");
        }

        public void IzarVelas()
        {
            Console.WriteLine("Izando velas...");
        }
    }
}
