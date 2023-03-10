using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Ejercicio1
{
    public class Vehiculo
    {
        public string Matricula { get; }
        public string Marca { get; }
        public string Color { get; }
        public int DiasAlquiler { get; }

        protected Vehiculo(string matricula, string marca, string color, int diasAlquiler)
        {
            Matricula = matricula;
            Marca = marca;
            Color = color;
            DiasAlquiler = diasAlquiler;
        }

        public virtual decimal CalcularPrecioAlquiler() {
            return DiasAlquiler * 50;
        }
    }

}
