using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Monedas
{
    public class Divisa
    {
        protected double tasaDeCambio;

        public Divisa(double tasaDeCambio)
        {
            this.tasaDeCambio = tasaDeCambio;
        }

        public double convertir(double cantidad, Divisa divisaDestino)
        {
            return cantidad * (this.tasaDeCambio / divisaDestino.tasaDeCambio);
        }
    }

    public class Dolar : Divisa
    {
        public Dolar() : base(1.0)
        {
        }
    }

    public class Euro : Divisa
    {
        public Euro() : base(0.83)
        {
        }
    }
}
