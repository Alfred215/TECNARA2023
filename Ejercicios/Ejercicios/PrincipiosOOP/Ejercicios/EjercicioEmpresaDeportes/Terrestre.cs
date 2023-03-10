using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioEmpresaDeportes
{
    public abstract class Terrestre : Vehiculo
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

        public abstract override void DimeTipoAveria();

        public abstract override void DimeVelocidad();

        public abstract void Conducir();
    }
}
