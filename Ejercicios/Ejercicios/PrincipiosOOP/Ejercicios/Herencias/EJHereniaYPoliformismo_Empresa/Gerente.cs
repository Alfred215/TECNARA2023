using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EJHerenciaYPoliformismo_Empresa
{
    public class Gerente : Empleado
    {
        public string departamento { get; set; }

        public Gerente(string nombre, double sueldo, string departamento) : base(nombre, sueldo)
        {
            this.departamento = departamento;
        }

        public override void DimeSueldo(double suma)
        {
            base.DimeSueldo(suma);
            Console.WriteLine("Departamento: {0}", departamento);
        }
    }
}
