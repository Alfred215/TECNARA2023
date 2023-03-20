using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExRegex
{
    internal class RegexContraseña
    {
        public RegexContraseña()
        {
            Console.WriteLine("Escribe una contraseña valida");
            string password = Console.ReadLine();

            bool hasUpper = Regex.IsMatch(password, "^[A-Z]*$");
            //bool hasUpper = password.Any(c => char.IsUpper(c));

            bool hasLower = Regex.IsMatch(password, "[a-z]");
            //bool hasLower = password.Any(c => char.IsLower(c));

            bool hasNumber = Regex.IsMatch(password, "[0-9]");
            bool hasEspecial = Regex.IsMatch(password, "[!@#$%^&*]");
            bool notSpace = !Regex.IsMatch(password, @"\s");
            bool lenthOk = password.Length >= 8 && password.Length <= 20;

            if (hasUpper && hasLower && hasNumber && hasEspecial && notSpace && lenthOk)
            {
                Console.WriteLine("La contraseña es valida");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La contraseña no es valida");
                if (!hasUpper) Console.WriteLine("La cadena no tiene mayusculas");
                if (!hasLower) Console.WriteLine("La cadena no tiene minusculas");
                if (!hasNumber) Console.WriteLine("La cadena no tiene numeros");
                if (!hasEspecial) Console.WriteLine("La cadena no tiene especiales");
                if (!notSpace) Console.WriteLine("La cadena tiene espacios");
                if (!lenthOk) Console.WriteLine("La cadena no tiene el largo correcto");
            }

            var changePassword = password[0].ToString().ToUpper() + password.Substring(1);
            //var changePassword = char.ToUpper(password[0]) + password.Substring(1);

            Console.Write(changePassword);
        }
    }
}
