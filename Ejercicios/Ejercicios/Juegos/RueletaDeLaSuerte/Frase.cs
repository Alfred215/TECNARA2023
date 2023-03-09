using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.RueletaDeLaSuerte
{
    public class Frase
    {
        private string FraseCompleta = "Hola chicos soy alfredo";
        private string LetrasIntroducidas = "";
        private string LetraValidas = "";
        private string VocalesCompradas = "";
        private string FraseIncompleta = "";

        public Frase() 
        {
            foreach(char letra in FraseCompleta)
            {
                if (Char.IsWhiteSpace(letra))
                {
                    FraseIncompleta += " ";
                }
                else
                {
                    FraseIncompleta += "_";
                }
            }
        }

        #region Get
        public string GetLetrasIntroducidas()
        {
            return LetrasIntroducidas;
        }

        public string GetVocalesCompradas()
        {
            return VocalesCompradas;
        }
        #endregion

        #region Comprobar
        public int ComprobarLetra(string letra)
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
                AñadirLetras(letra);
                Console.WriteLine("Existen {0} en la frase", cont);
            }

            return cont;
        }

        public bool ComprarVocal(string letra)
        {
            var existe = false;
            foreach (var letraIntro in VocalesCompradas)
            {
                if (letraIntro.ToString().Equals(letra))
                {
                    existe = true;
                    Console.WriteLine("Esta vocal ya ha sido introducida");
                    break;
                }
            }

            if (!existe)
            {
                VocalesCompradas += letra;
                AñadirLetras(letra);
            }

            return existe;
        }

        public bool Resolver(string frase)
        {
            if (frase.ToLower().Equals(FraseCompleta.ToLower()))
            {
                return true;
            }
            return false;
        }

        public void AñadirLetras(string letraNew)
        {
            for (int i = 0; i < FraseCompleta.Length; i++)
            {
                if (FraseCompleta.ToArray()[i].ToString().Equals(letraNew))
                {
                    FraseIncompleta.ToArray()[i] = letraNew;
                }
            }
        }
        #endregion

        #region Imprimir
        public virtual void ImprimirFrase()
        {
            foreach (var letra in FraseIncompleta)
            {
                Console.Write(letra.ToString());
            }

        }
        #endregion
    }
}
