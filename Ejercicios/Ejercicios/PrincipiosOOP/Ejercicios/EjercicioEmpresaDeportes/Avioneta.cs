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

        public override void DimeTipoAveria()
        {
            Console.WriteLine("No tiene helices");
        }

        public override void DimeVelocidad()
        {
            Console.WriteLine("320 km/h");
        }

        public override void Volar()
        {
            Console.WriteLine("Estas volando");
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
    }
}
