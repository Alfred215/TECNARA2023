using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioEmpresaDeportes
{
    public class Acuatico : Vehiculo
    {
        private int codigoAcuatico = 0;
        private int numeroVelas;

        public Acuatico(string nombre, float peso, float altura, int plazas, string color, string marca, int numeroVelas)
            : base(nombre, peso, altura, plazas, color, marca)
        {
            this.codigoAcuatico++;
            this.numeroVelas = numeroVelas;
        }

        public override string DimeTipoAveria()
        {
            return "El barco tiene problemas con la vela";
        }

        public override double DimeVelocidad()
        {
            return 20;
        }

        public void Navegar()
        {
            Console.WriteLine("El barco está navegando...");
        }
    }
}
