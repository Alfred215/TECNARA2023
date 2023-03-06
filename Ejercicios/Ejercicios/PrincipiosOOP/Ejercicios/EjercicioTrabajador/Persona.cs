using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioTrabajador
{
    class Persona
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
    }

    class Trabajador : Persona
    {
        public Trabajador(string? dni, string? nombre, string? apellidos, double salario, DateTime fechaContratacion) : base()
        {
            DNI = dni;
            Nombre = nombre;
            Apellidos = apellidos;
            Salario = salario;
            FechaContratacion = fechaContratacion;
        }

        public double Salario { get; set; }
        public DateTime FechaContratacion { get; set; }
    }
}
