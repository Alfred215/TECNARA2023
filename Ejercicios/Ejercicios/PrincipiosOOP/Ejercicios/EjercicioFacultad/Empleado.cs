using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioFacultad
{
    public class Empleado : Persona
    {
        protected int añoIncorporacion;
        protected string numDespacho;

        public Empleado(string nombre, string apellidos, string numeroId, string estadoCivil, int añoIncorporacion, string numDespacho)
            : base(nombre, apellidos, numeroId, estadoCivil)
        {
            this.añoIncorporacion = añoIncorporacion;
            this.numDespacho = numDespacho;
        }

        public virtual void ReasignarDespacho(string nuevoNumDespacho)
        {
            this.numDespacho = nuevoNumDespacho;
        }

        public override void ImprimirInformacion()
        {
            base.ImprimirInformacion();
            Console.WriteLine("Año de incorporación: {0}", añoIncorporacion);
            Console.WriteLine("Número de despacho: {0}", numDespacho);
        }
    }
}
