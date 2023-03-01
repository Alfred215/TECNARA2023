using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioFacultad
{
    public class Estudiante : Persona
    {
        protected string curso;

        public Estudiante(string nombre, string apellidos, string numeroId, string estadoCivil, string curso)
            : base(nombre, apellidos, numeroId, estadoCivil)
        {
            this.curso = curso;
        }

        public void MatricularEnCurso(string nuevoCurso)
        {
            this.curso = nuevoCurso;
        }

        public override void ImprimirInformacion()
        {
            base.ImprimirInformacion();
            Console.WriteLine("Curso matriculado: {0}", curso);
        }
    }
}
