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

        public void PonerDobleTraccion()
        {
            DobleTraccion = true;
        }
    }
}
