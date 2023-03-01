using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioFacultad
{
    public class Profesor : Empleado
    {
        protected string departamento;

        public Profesor(string nombre, string apellidos, string numeroId, string estadoCivil, int añoIncorporacion, string numDespacho, string departamento)
            : base(nombre, apellidos, numeroId, estadoCivil, añoIncorporacion, numDespacho)
        {
            this.departamento = departamento;
        }

        public void CambiarDepartamento(string nuevoDepartamento)
        {
            this.departamento = nuevoDepartamento;
        }

        public override void ImprimirInformacion()
        {
            base.ImprimirInformacion();
            Console.WriteLine("Departamento: {0}", departamento);
        }
    }
}
