using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.RueletaDeLaSuerte
{
    public class Puntuacion 
    {
        List<int> Puntos; 

        Random rad = new Random();

        public Puntuacion()
        {
            Puntos = new List<int>()
            {
                10,25,50,75,100,200
            };
        }

        public int GetPuntos()
        {
            return Puntos[rad.Next(Puntos.Count)];
        }
    }
}
