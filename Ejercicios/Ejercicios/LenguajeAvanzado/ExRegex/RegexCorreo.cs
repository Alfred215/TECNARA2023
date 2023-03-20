using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExRegex
{
    internal class RegexCorreo
    {
        public RegexCorreo()
        {
            // Pedimos al usuario que introduzca su nombre y correo electrónico
            Console.WriteLine("Introduce tu nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Introduce tu correo electrónico:");
            string correo = Console.ReadLine();

            // Validamos el nombre
            bool tieneMayuscula = Regex.IsMatch(nombre, "[A-Z]*");
            bool tieneMinuscula = Regex.IsMatch(nombre, "[a-z]*");
            bool nombreValido = tieneMayuscula && tieneMinuscula;

            // Validamos el correo electrónico
            bool correoValido = Regex.IsMatch(correo, "^[^@]+@[^@]+\\.[a-zA-Z]{2,}$");
            bool dominioValido = Regex.IsMatch(correo, "@(gmail\\.com|outlook\\.com)$");

            // Imprimimos el mensaje de confirmación o de error
            if (nombreValido && correoValido && dominioValido)
            {
                Console.WriteLine("Tu nombre y correo electrónico son válidos");
            }
            else
            {
                Console.WriteLine("Ha habido un error en la validación:");
                if (!nombreValido)
                {
                    Console.WriteLine("- El nombre debe contener al menos una letra mayúscula y una letra minúscula");
                }
                if (!correoValido)
                {
                    Console.WriteLine("- El correo electrónico debe tener el formato nombre@dominio.extension");
                }
                if (!dominioValido)
                {
                    Console.WriteLine("- El dominio del correo electrónico debe ser gmail.com o outlook.com");
                }
            }

            Console.ReadKey();
        }
    }
}
