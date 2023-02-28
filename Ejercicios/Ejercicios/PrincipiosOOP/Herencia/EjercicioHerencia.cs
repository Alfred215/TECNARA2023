using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Herencia
{
    public class EjercicioHerencia
    {
        /*En este ejemplo, la clase Animal es la clase base que define el método 
         * Speak. Las clases Cat y Dog derivan de la clase Animal y proporcionan 
         * sus propias implementaciones del método Speak. En el método Main, se 
         * crea un objeto de cada una de las clases y se llama al método Speak.*/

        public void EjercicioHerenciaCode() {
            Persona per = new Persona("Paco");
            Console.WriteLine(per.Name);

            Estudiante est = new Estudiante(7, "informatica", "Paquito");
            Console.WriteLine(est.Name + est.curso + est.num_matricula);
            est.Hablar();

            Profesor pro = new Profesor("Bruno");
            Console.WriteLine(pro.Name + pro.aula);

        }
    }
}
