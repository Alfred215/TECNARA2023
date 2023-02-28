using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.OOP.Ejercicio3
{
    public class Paises
    {
        public string Pais { get; set; }
        public List<int> Estatura = new List<int>();
    }

    public class ListPaises
    {
        private List<Paises> paises = new List<Paises>();
        public List<Paises> GetPaises()
        {
            return paises;
        }

        public void SetPaises(Paises pais)
        {
            paises.Add(new Paises { Pais= pais.Pais, Estatura= pais.Estatura });
        }
    }
}
