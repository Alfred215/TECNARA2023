using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioEmpresaDeportes
{
    public class Moto : Terrestre
    {
        public Moto(string nombre, float peso, float altura, int plazas, string color, string marca, int numeroRuedas, int cilindrada)
            : base(nombre, peso, altura, plazas, color, marca, numeroRuedas, cilindrada)
        {
        }

        public override void DimeTipoAveria()
        {
            Console.WriteLine("Tiene roto el motor");
        }

        public override void DimeVelocidad()
        {
            Console.WriteLine("120 km/h");
        }

        public override void Conducir()
        {
            Console.WriteLine("Estas conduciendo la moto");
        }


        public new void ElegirCilindrada(int cilindrada)
        {
            base.ElegirCilindrada(cilindrada);
        }

        public new int getCilindrada()
        {
            return base.getCilindrada();
        }
    }
}
