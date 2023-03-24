using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExFicheros.GeneradorContrasena
{
    internal class PasswordGenerator
    {
        public PasswordGenerator() {

            string path = "../../../LenguajeAvanzado/ExFicheros/GeneradorContrasena/archivo.txt";

            string[] allWords = File.ReadAllLines(path);
            
            Console.Write("Ingrese la cantidad de palabras que desea combinar en la contraseña: ");
            int numWords = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int[] wordIndexes = Enumerable.Range(0, allWords.Length).OrderBy(x => rnd.Next()).Take(numWords).ToArray();

            string password = string.Join("", wordIndexes.Select(i => allWords[i]));

            bool isValid = IsPasswordValid(password);

            while (!isValid)
            {
                wordIndexes = Enumerable.Range(0, allWords.Length).OrderBy(x => rnd.Next()).Take(numWords).ToArray();
                password = string.Join("", wordIndexes.Select(i => allWords[i]));
                isValid = IsPasswordValid(password);
            }

            Console.WriteLine("Contraseña generada: " + password);
        }

        static bool IsPasswordValid(string password)
        {
            // Validar que la contraseña tenga al menos 8 caracteres
            if (password.Length < 8) return false;

            // Validar que la contraseña contenga al menos una letra mayúscula
            //if (!Regex.IsMatch(password, "^[A-Z]*$")) return false;

            //// Validar que la contraseña contenga al menos una letra minúscula
            //if (!Regex.IsMatch(password, "[a-z]")) return false;

            ////// Validar que la contraseña contenga al menos un número
            //if (!Regex.IsMatch(password, "[0-9]")) return false;

            //// Validar que la contraseña contenga al menos un caracter especial
            //if (!Regex.IsMatch(password, "[!#$%&()*+,-./:;<=>?@[\\]^_`{|}~]")) return false;

            // Si la contraseña pasa todas las validaciones, es válida
            return true;
        }
    }
}
