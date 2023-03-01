using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioEmpresaDeportes
{
    public class Avioneta : Aereo
    {
        // Atributos
        private bool helicesEncendidas;

        // Constructor
        public Avioneta(int numHelices, string nombre, float peso, float altura, int numPlazas, string color, string marca) : base(numHelices, nombre, peso, altura, numPlazas, color, marca)
        {
            helicesEncendidas = false;
        }

        // Métodos
        public void EncenderHelices()
        {
            helicesEncendidas = true;
            Console.WriteLine("Las hélices han sido encendidas.");
        }

        public void ApagarHelices()
        {
            helicesEncendidas = false;
            Console.WriteLine("Las hélices han sido apagadas.");
        }

        public override void Volar()
        {
            if (!helicesEncendidas)
            {
                Console.WriteLine("No se puede volar sin encender las hélices.");
                return;
            }

            Console.WriteLine("La avioneta está volando.");
        }
    }
}
