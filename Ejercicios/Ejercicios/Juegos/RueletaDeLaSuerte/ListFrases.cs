using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.RueletaDeLaSuerte
{
    public class ListFrases
    {
        List<string> Frases = new List<string>() 
        {
            "Hola chicos soy alfredo",
            "La ruleta de la suerte no es dificil",
            "Este juego es de herencia y poliformismo",
            "Antes hemos hecho el juego de la oca y nos hemos rallado la cabeza"
        };

        public string RecogerFraseAleatoria()
        {
            Random ran = new Random();
            return Frases[ran.Next(Frases.Count)];
        }
    }
}
