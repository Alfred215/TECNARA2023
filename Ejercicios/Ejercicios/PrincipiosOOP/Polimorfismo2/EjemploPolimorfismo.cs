using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Polimorfismo2
{
    public class EjemploPolimorfismo
    {
        public void MetodoPrincipal()
        {
            List<Persona> personaList = new List<Persona>();

            PersonaMenorEdad menor = new PersonaMenorEdad("Juan", "Perez", 9, "fifa");

            PersonaAdulta mayor = new PersonaAdulta()
            {
                nombre = "Paquito",
                apellidos = "Gonzalez",
                edad = 9,
                MarcaCoche = "Opel",
                ModeloCoche = "7"
            };

            personaList.Add(menor);
            personaList.Add(mayor);

            Console.WriteLine();
            Console.WriteLine("Información obtenida de método nomral:");
            foreach (Persona persona in personaList)
            {
                Console.WriteLine(persona.DarInformacionNormal());
            };

            Console.WriteLine();
            Console.WriteLine("Información obtenida de método abstracion:");
            foreach (Persona persona in personaList)
            {
                Console.WriteLine(persona.DarInformacionAbs());
            };

            Console.WriteLine();
            Console.WriteLine("Información obtenida de método virtual:");
            foreach (Persona persona in personaList)
            {
                Console.WriteLine(persona.DarInformacionVir());
            };

            Console.ReadKey();

        }



    }
}
