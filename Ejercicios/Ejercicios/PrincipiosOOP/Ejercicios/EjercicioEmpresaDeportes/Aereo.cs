using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioEmpresaDeportes
{
    public abstract class Aereo : Vehiculo
    {
        // Atributos
        private int codigoAereo;
        private int numeroHelices;

        // Propiedades
        public int CodigoAereo { get => codigoAereo; set => codigoAereo = value; }
        public int NumeroHelices { get => numeroHelices; set => numeroHelices = value; }

        // Constructor
        public Aereo(int numeroHelices, string nombre, double peso, double altura, int plazas, string color, string marca)
            : base(nombre, peso, altura, plazas, color, marca)
        {
            this.codigoAereo++;
            this.NumeroHelices = numeroHelices;
        }

        // Métodos
        public abstract void Volar();

        public abstract override void DimeTipoAveria();

        public abstract override void DimeVelocidad();
    }
}
