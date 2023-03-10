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
            avioneta.DimeTipoAveria();
            avioneta.DimeVelocidad();

            Velero velero = new Velero("Vueling", 3000, 4, 7, "Rojo", " Airbus", 2);
            Console.WriteLine("\nVelero");
            velero.IzarVelas();
            velero.Navegar();
            velero.DimeTipoAveria();
            velero.DimeVelocidad();

            Moto moto = new Moto("Vueling", 3000, 4, 7, "Rojo", " Airbus", 2, 250);
            Console.WriteLine("\nMoto");
            moto.Conducir();
            moto.ElegirCilindrada(300);
            moto.DimeTipoAveria();
            moto.DimeVelocidad();

            Buggy buggy = new Buggy("Vueling", 3000, 4, 7, "Rojo", " Airbus", 2, 250);
            Console.WriteLine("\nBugy");
            buggy.Conducir();
            buggy.PonerDobleTraccion();
            buggy.DimeTipoAveria();
            buggy.DimeVelocidad();
        }
        
    }
}
