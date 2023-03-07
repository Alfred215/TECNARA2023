using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Garaje
{
    public class EjGaraje
    {
        public void EjercicioGaraje()
        {
            Coche coche = new Coche();
            coche.Modelo = "Ford Mustang";
            coche.NumeroDePuertas = 2;

            Moto moto = new Moto();
            moto.Modelo = "Harley Davidson";
            moto.TipoDeMoto = "Chopper";

            Garaje garaje = new Garaje();
            garaje.AgregarVehiculo(coche);
            garaje.AgregarVehiculo(moto);

            garaje.AcelerarTodos(); // Imprime "El coche acelera" y "La moto acelera"
        }
    }
}
