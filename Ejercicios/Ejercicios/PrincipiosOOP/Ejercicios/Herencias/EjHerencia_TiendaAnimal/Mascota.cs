using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_TiendaAnimal
{
    abstract class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public TipoDeAnimal Tipo { get; set; }
        public string ColorPelaje { get; set; }
        public double Precio { get; set; }
    }

    public enum TipoDeAnimal
    {
        None = 0,
        Perro = 1,
        Gato = 2,
        Pajaro = 3
    }

    // Clases que heredan de Mascota para definir las propiedades específicas de cada especie
    class Perro : Mascota
    {
        public string Raza { get; set; }
        public bool EsEntrenado { get; set; }
    }

    class Gato : Mascota
    {
        public bool EsCazador { get; set; }
    }

    class Pajaro : Mascota
    {
        public string Especie { get; set; }
        public bool EsCantante { get; set; }
    }
}
