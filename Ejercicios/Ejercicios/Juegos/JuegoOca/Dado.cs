using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.JuegoOca
{
    public class Dado
    {
        private Random _rnd;

        public Dado()
        {
            _rnd = new Random();
        }

        public int Tirar()
        {
            Console.ReadKey();
            var dado = _rnd.Next(1, 6);
            Console.WriteLine("Has sacado un {0}",dado);
            return dado;
        }
    }
}
