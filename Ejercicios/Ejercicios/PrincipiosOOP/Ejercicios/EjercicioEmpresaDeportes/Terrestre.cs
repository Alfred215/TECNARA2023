using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioEmpresaDeportes
{
    public class Terrestre : Vehiculo
    {
        private int codigoTerrestre = 0;
        private int numeroRuedas;
        private int cilindrada;

        public Terrestre(string nombre, float peso, float altura, int plazas, string color, string marca, int numeroRuedas, int cilindrada)
            : base(nombre, peso, altura, plazas, color, marca)
        {
            this.codigoTerrestre++;
            this.numeroRuedas = numeroRuedas;
            this.cilindrada = cilindrada;
        }

        public void ElegirCilindrada(int cilindrada)
        {
            this.cilindrada = cilindrada;
        }

        public int getCilindrada()
        {
            return cilindrada;
        }

        public override string DimeTipoAveria()
        {
            return "El vehiculo terrestre tiene problemas con la rueda";
        }

        public override double DimeVelocidad()
        {
            return 120;
        }

        public void Conducir()
        {
            Console.WriteLine("Estoy conduciendo el vehículo terrestre.");
        }
    }
}
