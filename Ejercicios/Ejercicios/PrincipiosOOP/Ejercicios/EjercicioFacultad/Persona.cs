using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioFacultad
{
    public class Persona
    {
        protected string nombre;
        protected string apellidos;
        protected string numeroId;
        protected string estadoCivil;

        public Persona(string nombre, string apellidos, string numeroId, string estadoCivil)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.numeroId = numeroId;
            this.estadoCivil = estadoCivil;
        }

        public void CambiarEstadoCivil(string nuevoEstadoCivil)
        {
            this.estadoCivil = nuevoEstadoCivil;
        }

        public virtual void ImprimirInformacion()
        {
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Apellidos: {0}", apellidos);
            Console.WriteLine("Número de identificación: {0}", numeroId);
            Console.WriteLine("Estado civil: {0}", estadoCivil);
        }
    }
}
