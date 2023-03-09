using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Robots
{
    internal class EjPeleaRobots
    {
        public void CombateRobot()
        {
            // Se crean dos robots de combate
            RobotDeCombate robot1 = new RobotDeCombate
            {
                Nombre = "Robot1",
                Vida = 100,
                Ataque = 20,
                Defensa = 10,
                Velocidad = 5,
                Nivel = 1,
                TipoDeArma = "Láser",
                NivelEnergiaArma = 50
            };

            RobotDeCombate robot2 = new RobotDeCombate
            {
                Nombre = "Robot2",
                Vida = 100,
                Ataque = 25,
                Defensa = 5,
                Velocidad = 7,
                Nivel = 1,
                TipoDeArma = "Misiles",
                NivelEnergiaArma = 30
            };

            // Se muestra la información de los robots antes de la pelea
            Console.WriteLine($"Pelea entre {robot1.Nombre} y {robot2.Nombre}:");
            Console.WriteLine($"{robot1.Nombre}: {robot1.Vida} puntos de vida, {robot1.Ataque} puntos de ataque, {robot1.Defensa} puntos de defensa, {robot1.Velocidad} puntos de velocidad, nivel {robot1.Nivel}");
            Console.WriteLine($"{robot2.Nombre}: {robot2.Vida} puntos de vida, {robot2.Ataque} puntos de ataque, {robot2.Defensa} puntos de defensa, {robot2.Velocidad} puntos de velocidad, nivel {robot2.Nivel}");

            // Se simula la pelea entre los dos robots
            Pelea.SimularPelea(robot1, robot2);

            // Se muestra la información de los robots después de la pelea
            Console.WriteLine($"{robot1.Nombre}: {robot1.Vida} puntos de vida");
            Console.WriteLine($"{robot2.Nombre}: {robot2.Vida} puntos de vida");

            // Se determina el robot ganador y se muestra el resultado final
            if (robot1.Vida > robot2.Vida)
            {
                Console.WriteLine($"{robot1.Nombre} ha ganado la pelea");
            }
            else if (robot2.Vida > robot1.Vida)
            {
                Console.WriteLine($"{robot2.Nombre} ha ganado la pelea");
            }
            else
            {
                Console.WriteLine("La pelea ha terminado en empate");
            }
        }
    }
}
