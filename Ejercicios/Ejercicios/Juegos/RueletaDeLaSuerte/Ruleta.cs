using Ejercicios.EjemploClase.Ejemplo_Static_Id;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.RueletaDeLaSuerte
{
    public class Ruleta : Puntuacion
    {
        private int Puntos = 0;
        public Ruleta() : base() {}

        public virtual void Tirada(int cantidad)
        {
            Puntos += base.GetPuntos()*cantidad;
        }

        public virtual int GetPuntos()
        {
            return Puntos;
        }

        public void RestarCompra()
        {
            Puntos = Puntos - 100;
        }
    }
}
