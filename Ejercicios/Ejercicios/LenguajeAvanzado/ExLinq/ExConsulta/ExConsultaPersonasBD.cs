using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExLinq.ExConsulta
{
    public class ExConsultaPersonasBD
    {
        public ExConsultaPersonasBD()
        {
            //Lista de personas
            List<Persona> _personas = new List<Persona>()
            {
                new Persona() { Nombre= "Paula", Edad= 25},
                new Persona() { Nombre= "Maria", Edad= 16},
                new Persona() { Nombre= "Laura", Edad= 24},
                new Persona() { Nombre= "Rodrigo", Edad= 37},
                new Persona() { Nombre= "Pepe", Edad= 15},
            }; 

            //Consulta LINQ utilizando la sintaxis de consulta
            var resultado = from persona in _personas
                            where persona.Edad >= 18
                            orderby persona.Nombre
                            select persona;

            //Mostrar el resultado por consola
            foreach ( var per in resultado )
            {
                Console.WriteLine( per.ToString() );
                //Console.WriteLine(per.Nombre + " - " + per.Edad);
            }
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public override string ToString()
        {
            return $"{Nombre} - tiene {Edad} años";
        }
    }
}
