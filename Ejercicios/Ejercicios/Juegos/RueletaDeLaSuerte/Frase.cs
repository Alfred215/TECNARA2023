using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.RueletaDeLaSuerte
{
    public class Frase
    {

        public string FraseCompleta = "Hola chicos soy alfredo";
        public string LetrasIntroducidas = "";

        public Frase()
        {

        }

        public virtual int ComprobarLetra(string letra)
        {
            int cont = 0;
            var existe = false;
            foreach (var letraIntro in LetrasIntroducidas)
            {
                if (letraIntro.ToString().Equals(letra))
                {
                    existe = true;
                    Console.WriteLine("Esta letra ya a sido introducida");
                    break;
                }
            }

            if (!existe)
            {
                foreach (var letraFrase in FraseCompleta)
                {
                    if (letraFrase.ToString().ToLower().Equals(letra)) cont++;
                }
                LetrasIntroducidas += letra;
                Console.WriteLine("Existen {0} en la frase", cont);
            }
            
            return cont;
        }
    }
}
