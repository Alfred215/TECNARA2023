using Ejercicios.PrincipiosOOP.Interfaz;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EJHerenciaYPoliformismo_Empresa
{
    public class Empleado
    {
        public string nombre { get; set; }
        public double sueldo { get; set; }

        public Empleado(string nombre, double sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        public virtual void DimeSueldo(double suma)
        {
            Console.WriteLine("El sueldo del empleado {0} es: {1}", nombre, sueldo + suma);
        }
    }
}
