using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Robots
{
    // Clase para la pelea entre dos robots
    public class Pelea
    {
        public static void SimularPelea(Robot robot1, Robot robot2)
        {
            // Se utiliza un objeto de la clase Random para generar los ataques aleatorios
            Random rnd = new Random();

            // Ciclo que representa los turnos de la pelea
            while (robot1.Vida > 0 && robot2.Vida > 0)
            {
                // Se genera el ataque de cada robot de manera aleatoria
                int ataqueRobot1 = rnd.Next(robot1.Ataque);
                int ataqueRobot2 = rnd.Next(robot2.Ataque);

                // Se reduce la vida del robot contrario en función del ataque generado
                robot2.Vida -= ataqueRobot1 - robot2.Defensa;
                robot1.Vida -= ataqueRobot2 - robot1.Defensa;
            }
        }
    }
}
