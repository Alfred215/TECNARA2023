using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EJHerenciaYPoliformismo_Empresa
{
    public class Director : Empleado
    {
        public string empresa { get; set; }

        public Director(string nombre, double sueldo, string empresa) : base(nombre, sueldo)
        {
            this.empresa = empresa;
        }

        public override void DimeSueldo(double suma)
        {
            base.DimeSueldo(suma);
            Console.WriteLine("Empresa: {0}", empresa);
        }
    }
}
