using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioEmpresaDeportes
{
    public abstract class Acuatico : Vehiculo
    {
        private int codigoAcuatico = 0;
        private int numeroVelas;

        public Acuatico(string nombre, float peso, float altura, int plazas, string color, string marca, int numeroVelas)
            : base(nombre, peso, altura, plazas, color, marca)
        {
            this.codigoAcuatico++;
            this.numeroVelas = numeroVelas;
        }

        public abstract override void DimeTipoAveria();

        public abstract override void DimeVelocidad();

        public abstract void Navegar();
    }
}
