using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Polimorfismo2
{
    public abstract class Persona
    {
        //Para que sea una privacidad entre padres e hijos, utiliza protected.
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }

        public string DarInformacionNormal()
        {
            return $"Soy una persona NORMAL y me llamo {nombre} {apellidos} y tengo {edad} años.";
        }

        public abstract string DarInformacionAbs();

        public virtual string DarInformacionVir()
        {
            return $"Soy una persona y mi nombre es {nombre} {apellidos}";
        }
    }
}
