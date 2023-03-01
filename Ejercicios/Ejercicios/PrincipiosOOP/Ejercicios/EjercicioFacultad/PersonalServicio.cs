using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioFacultad
{
    public class PersonalServicio : Empleado
    {
        protected string seccion;

        public PersonalServicio(string nombre, string apellidos, string numeroId, string estadoCivil, int añoIncorporacion, string numDespacho, string seccion)
            : base(nombre, apellidos, numeroId, estadoCivil, añoIncorporacion, numDespacho)
        {
            this.seccion = seccion;
        }

        public void TrasladarSeccion(string nuevaSeccion)
        {
            this.seccion = nuevaSeccion;
        }

        public override void ImprimirInformacion()
        {
            base.ImprimirInformacion();
            Console.WriteLine("Sección asignada: {0}", seccion);
        }
    }
}
