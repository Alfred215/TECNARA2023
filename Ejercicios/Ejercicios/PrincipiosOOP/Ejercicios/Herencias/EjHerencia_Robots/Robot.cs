using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Robots
{
    // Clase base para los robots
    public class Robot
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public int Velocidad { get; set; }
        public int Nivel { get; set; }
    }

    // Clase para los robots de combate
    public class RobotDeCombate : Robot
    {
        public string TipoDeArma { get; set; }
        public int NivelEnergiaArma { get; set; }
    }

    // Clase para los robots de exploración
    public class RobotDeExploracion : Robot
    {
        public int NivelSensores { get; set; }
        public int NivelAutonomia { get; set; }
        public int CapacidadCarga { get; set; }
    }
}
