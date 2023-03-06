using Ejercicios.PrincipiosOOP.Ejercicios.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioEmpresaDeportes
{
    public class EmpresaDeportes
    {
        public void Ejercicio()
        {
            Avioneta avioneta = new Avioneta(2, "Vueling",3000, 4, 7, "Rojo"," Airbus");
            Console.WriteLine("Avioneta");
            avioneta.EncenderHelices();
            avioneta.Volar();
            Console.WriteLine("Averia: {0}", avioneta.DimeTipoAveria());
            Console.WriteLine("Velocidad: {0}", avioneta.DimeVelocidad());

            Velero velero = new Velero("Vueling", 3000, 4, 7, "Rojo", " Airbus", 2);
            Console.WriteLine("\nVelero");
            velero.IzarVelas();
            velero.Navegar();
            Console.WriteLine("Averia: {0}",velero.DimeTipoAveria());
            Console.WriteLine("Velocidad: {0}", velero.DimeVelocidad());

            Moto moto = new Moto("Vueling", 3000, 4, 7, "Rojo", " Airbus", 2, 250);
            Console.WriteLine("\nMoto");
            moto.Conducir();
            moto.ElegirCilindrada(300);
            Console.WriteLine("Averia: {0}", moto.DimeTipoAveria());
            Console.WriteLine("Velocidad: {0}", moto.DimeVelocidad());

            Buggy buggy = new Buggy("Vueling", 3000, 4, 7, "Rojo", " Airbus", 2, 250);
            Console.WriteLine("\nBugy");
            buggy.Conducir();
            buggy.PonerDobleTraccion();
            Console.WriteLine("Averia: {0}",buggy.DimeTipoAveria());
            Console.WriteLine("Velocidad: {0}",buggy.DimeVelocidad());
        }
        
    }
}
