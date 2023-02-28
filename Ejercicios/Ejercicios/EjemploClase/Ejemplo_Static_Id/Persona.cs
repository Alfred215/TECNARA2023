using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjemploClase.Ejemplo_Static_Id
{
    public class Persona
    {
        public static int Incrementer { get; set; }
        public int Id { get; set; }
        public string Name { get; set; } //null != ""
        public string Apelllido { get; set; }


        public Persona(string nombre) { 
            Incrementer++; 
            Id = Incrementer; 
            Name = nombre; 
        }

        public Persona(string nombre, string apellido)
        {
            Incrementer++;
            Id = Incrementer;
            Name = nombre;
            Apelllido = apellido;
        }

    }
}
