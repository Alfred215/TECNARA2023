using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Polimorfismo2
{
    public class PersonaMenorEdad : Persona
    {
        public string JuegoFavorito { get; set; }


        public PersonaMenorEdad(string n, string a, int e, string j)
        {
            nombre = n;
            apellidos = n;
            edad = e;
            JuegoFavorito = j;
        }

        public override string DarInformacionAbs()
        {
            return $"Aun estoy aprendiendo a vivir, me llamo {nombre} {apellidos}";
        }
    }

    public class PersonaAdulta : Persona
    {
        public string MarcaCoche { get; set; }
        public string ModeloCoche { get; set; }

        public override string DarInformacionAbs()
        {
            return $"Soy un adulto, me llamo {nombre}";
        }

        public override string DarInformacionVir()
        {
            return $"Soy un adulto, me llamo {nombre}";
        }
    }
}
