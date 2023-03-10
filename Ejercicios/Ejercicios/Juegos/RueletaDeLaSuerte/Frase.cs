using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.RueletaDeLaSuerte
{
    public class Frase
    {
        private string FraseCompleta = "";
        private string LetrasIntroducidas = "";
        private string LetraValidas = "";
        private string VocalesCompradas = "";
        private string FraseIncompleta = "";

        public Frase() 
        {
            FraseCompleta = new ListFrases().RecogerFraseAleatoria();

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
                Console.WriteLine("Existen {0} en la frase", cont);
            }
            if(cont > 0)
            {
                LetraValidas += letra;
                AñadirLetras();
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
                LetraValidas+= letra;
                AñadirLetras();
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

        //Mirar este método para comprobar porque no inserta las letras en el string
        public void AñadirLetras()
        {
            FraseIncompleta = "";
            for (int i = 0; i < FraseCompleta.Length; i++)
            {
                bool añadida = false;
                foreach(var letra in LetraValidas)
                {
                    if (FraseCompleta.ToList()[i].ToString().ToLower().Equals(letra.ToString()))
                    {
                        FraseIncompleta += letra;
                        añadida = true;
                    }
                }
                if (!añadida)
                {
                    if (Char.IsWhiteSpace(FraseCompleta.ToList()[i]))
                    {
                        FraseIncompleta += " ";
                    }
                    else
                    {
                        FraseIncompleta += "_";
                    }
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
