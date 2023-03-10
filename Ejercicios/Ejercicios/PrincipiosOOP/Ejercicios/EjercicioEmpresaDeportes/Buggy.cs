using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioEmpresaDeportes
{
    public class Buggy : Terrestre
    {
        private bool DobleTraccion;

        public Buggy(string nombre, float peso, float altura, int plazas, string color, string marca, int numeroRuedas, int cilindrada)
            : base(nombre, peso, altura, plazas, color, marca, numeroRuedas, cilindrada)
        {
        }

        public override void DimeTipoAveria()
        {
            Console.WriteLine("Tiene roto el pedal de freno");
        }

        public override void DimeVelocidad()
        {
            Console.WriteLine("60 km/h");
        }

        public override void Conducir()
        {
            Console.WriteLine("Estas conduciendo el buggy");
        }
        public void PonerDobleTraccion()
        {
            DobleTraccion = true;
        }
    }
}
