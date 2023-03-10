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
                10,50,75,10,100,10,200,50,25,25,50,10,25,10,75,10,25
            };
        }

        public int GetPuntos()
        {
            return Puntos[rad.Next(Puntos.Count)];
        }
    }
}
