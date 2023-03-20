using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExFicheros.GeneradorContrasena
{
    internal class PasswordGenerator
    {
        public PasswordGenerator() {

            string path = "../../../LenguajeAvanzado/ExFicheros/GeneradorContrasena/archivo.txt";

            // Leer todas las palabras del archivo y guardarlas en un arreglo
            string[] allWords = File.ReadAllLines(path);

            // Pedir al usuario cuántas palabras quiere combinar
            Console.Write("Ingrese la cantidad de palabras que desea combinar en la contraseña: ");
            int numWords = int.Parse(Console.ReadLine());

            // Generar un arreglo aleatorio de índices que representen las palabras que se usarán
            Random rnd = new Random();
            int[] wordIndexes = Enumerable.Range(0, allWords.Length).OrderBy(x => rnd.Next()).Take(numWords).ToArray();

            // Unir las palabras seleccionadas en una sola contraseña
            string password = string.Join("", wordIndexes.Select(i => allWords[i]));

            // Validar la contraseña generada
            bool isValid = IsPasswordValid(password);

            // Mientras la contraseña no sea válida, generar una nueva hasta que lo sea
            while (!isValid)
            {
                wordIndexes = Enumerable.Range(0, allWords.Length).OrderBy(x => rnd.Next()).Take(numWords).ToArray();
                password = string.Join("", wordIndexes.Select(i => allWords[i]));
                isValid = IsPasswordValid(password);
            }

            // Imprimir la contraseña generada
            Console.WriteLine("Contraseña generada: " + password);
        }

        static bool IsPasswordValid(string password)
        {
            // Validar que la contraseña tenga al menos 8 caracteres
            if (password.Length < 8)
                return false;

            //// Validar que la contraseña contenga al menos una letra mayúscula
            //if (!password.Any(char.IsUpper))
            //    return false;

            //// Validar que la contraseña contenga al menos una letra minúscula
            //if (!password.Any(char.IsLower))
            //    return false;

            //// Validar que la contraseña contenga al menos un número
            //if (!password.Any(char.IsDigit))
            //    return false;

            //// Validar que la contraseña contenga al menos un caracter especial
            //string specialChars = @"!#$%&()*+,-./:;<=>?@[\]^_`{|}~";
            //if (!password.Any(c => specialChars.Contains(c)))
            //    return false;

            // Si la contraseña pasa todas las validaciones, es válida
            return true;
        }
    }
}
