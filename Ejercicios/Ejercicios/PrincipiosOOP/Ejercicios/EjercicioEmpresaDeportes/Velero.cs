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

        public void IzarVelas()
        {
            Console.WriteLine("Izando velas...");
        }
    }
}
