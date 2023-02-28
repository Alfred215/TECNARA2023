using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Herencia
{
    /*La herencia se utiliza para crear una nueva clase a partir de 
     * una clase existente. En otras palabras, una clase puede heredar 
     * los atributos y métodos de otra clase, y luego agregar o modificar 
     * esos atributos y métodos para crear una nueva clase. 
     * 
     * Por ejemplo, si tienes una clase "Persona" y quieres crear una nueva clase 
     * "Estudiante", puedes heredar los atributos y métodos de la clase 
     * "Persona" y agregar algunos nuevos, como "número de matrícula" 
     * y "cursos".*/

    public class Persona
    {
        public string Name;

        public Persona(string name) {
            Name = name;
        }   

        public void Hablar()
        {
            Console.WriteLine("La persona está hablando.");
        }
    }

    public class Estudiante : Persona
    {
        public int num_matricula;
        public string curso;

        public Estudiante(int num, string cursito, string nombre) : base (nombre)
        {
            num_matricula = num;
            curso = cursito;
            Name = nombre;
        }

        public new void Hablar()
        {
            Console.WriteLine("El estudiante está hablando.");
        }
    }

    public class Profesor : Persona
    {
        public string aula;

        public Profesor(string name) : base(name)
        {
            Name = name;
        }
    }
}
