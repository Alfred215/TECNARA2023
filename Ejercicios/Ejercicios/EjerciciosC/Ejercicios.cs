using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicios.EjerciciosC
{
    public class Ejercicios
    {
        public void LlamarEjercicios()
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            //Ejercicio5();
            //Ejercicio6();
            //Ejercicio7();
            //Ejercicio8();
            //Ejercicio9();
            //Ejercicio10();
            //Ejercicio11();
            //Ejercicio12();
            //Ejercicio13();
            //Ejercicio13_Clase();
            //Ejercicio14();
            //Ejercicio14_Clase();
            //Ejercicio15();
            //Ejercicio15_Clase();
            //Ejercicio16();
            //Ejercicio17();
            //Ejercicio18();
            //Ejercicio19();
            //Ejercicio19_Clase();
            //Ejercicio20();
            //Ejercicio20_Clase();
            Ejercicio21();

        }

        static void Ejercicio1()
        {
            Console.WriteLine("\n\tEjercicio 1:");
            // Solicitamos al usuario un número
            Console.Write("Ingrese un número: ");
            // Leemos el número ingresado por el usuario
            int numero = int.Parse(Console.ReadLine());

            // Verificamos si el número es positivo o negativo
            if (numero >= 0)
            {
                // Si es positivo, mostramos un mensaje en pantalla indicándolo
                Console.WriteLine("El número ingresado es positivo.");
            }
            else
            {
                // Si es negativo, mostramos un mensaje en pantalla indicándolo
                Console.WriteLine("El número ingresado es negativo.");
            }
        }

        static void Ejercicio2()
        {
            Console.WriteLine("\n\tEjercicio 2:");
            // Solicitamos al usuario un día de la semana
            Console.Write("Ingrese un día de la semana: ");
            // Leemos el día ingresado por el usuario
            string dia = Console.ReadLine();

            // Verificamos si el día es laborable o no
            switch (dia.ToLower())
            {
                // Si es lunes, martes, miércoles, jueves o viernes, es laborable
                case "lunes":
                case "martes":
                case "miércoles":
                case "jueves":
                case "viernes":
                    // Mostramos un mensaje en pantalla indicando que es laborable
                    Console.WriteLine("El día ingresado es laborable.");
                    break;
                // Si es sábado o domingo, no es laborable
                case "sábado":
                case "domingo":
                    // Mostramos un mensaje en pantalla indicando que no es laborable
                    Console.WriteLine("El día ingresado no es laborable.");
                    break;
                // Si el día ingresado no coincide con ninguna de las opciones anteriores, es inválido
                default:
                    // Mostramos un mensaje en pantalla indicando que el día ingresado no es válido
                    Console.WriteLine("El día ingresado no es válido.");
                    break;
            }
        }

        static void Ejercicio3()
        {
            Console.WriteLine("\n\tEjercicio 3:");
            // Solicitamos al usuario un número
            Console.Write("Ingrese un número: ");
            // Leemos el número ingresado por el usuario
            int numero = int.Parse(Console.ReadLine());

            // Creamos un contador inicializado en 1
            int i = 1;
            // Mientras el contador sea menor o igual al número ingresado
            while (i <= numero)
            {
                // Verificamos si el número actual es impar
                if (i % 2 != 0)
                {
                    // Si es impar, lo mostramos en pantalla
                    Console.Write(i + " ");
                }
                // Incrementamos el contador en 1
                i++;
            }
        }

        static void Ejercicio4()
        {
            Console.WriteLine("\n\tEjercicio 4:");
            // Se pide al usuario que ingrese una serie de números separados por coma.
            Console.Write("Ingrese los números separados por coma: ");

            // Se lee la entrada del usuario y se guarda en la variable numerosString.
            string numerosString = Console.ReadLine();

            // Se separa la cadena de entrada en un array de cadenas utilizando la coma como separador.
            string[] numeros = numerosString.Split(',');

            // Se inicializa la variable suma en cero.
            int suma = 0;

            // Se itera sobre cada elemento del array de cadenas numeros.
            foreach (string numero in numeros)
            {
                // Se convierte cada cadena en un número entero y se suma a la variable suma.
                suma += int.Parse(numero);
            }

            // Se muestra en pantalla el resultado de la suma.
            Console.WriteLine("La suma de los números ingresados es: " + suma);
        }

        static void Ejercicio5()
        {
            Console.WriteLine("\n\tEjercicio 5:");
            Console.Write("Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El número " + numero + " es par.");
            }
            else
            {
                Console.WriteLine("El número " + numero + " es impar.");
            }
        }

        static void Ejercicio6()
        {
            Console.WriteLine("\n\tEjercicio 6:");
            Console.Write("Ingrese una cadena de texto: ");
            string cadena = Console.ReadLine();

            int contadorA = 0; int contadorE = 0; int contadorI = 0; int contadorO = 0; int contadorU = 0;

            foreach (char letra in cadena)
            {
                switch (letra)
                {
                    case 'a':
                    case 'A':
                        contadorA++;
                        break;
                    case 'e':
                    case 'E':
                        contadorE++;
                        break;
                    case 'i':
                    case 'I':
                        contadorI++;
                        break;
                    case 'o':
                    case 'O':
                        contadorO++;
                        break;
                    case 'u':
                    case 'U':
                        contadorU++;
                        break;
                }
            }

            Console.WriteLine("La cantidad de veces que aparece la vocal a es: " + contadorA);
            Console.WriteLine("La cantidad de veces que aparece la vocal e es: " + contadorE);
            Console.WriteLine("La cantidad de veces que aparece la vocal i es: " + contadorI);
            Console.WriteLine("La cantidad de veces que aparece la vocal o es: " + contadorO);
            Console.WriteLine("La cantidad de veces que aparece la vocal u es: " + contadorU);
        }

        static void Ejercicio7()
        {
            Console.WriteLine("\n\tEjercicio 7:");
            Console.Write("Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine(numero + " x " + i + " = " + resultado);
            }
        }

        static void Ejercicio8()
        {
            Console.WriteLine("\n\tEjercicio 8:");

            Console.Write("Ingrese la cantidad de asignaturas: ");
            int numAsignaturas = Convert.ToInt32(Console.ReadLine());

            string[] asignaturas = new string[numAsignaturas];
            double[] notas = new double[numAsignaturas];

            for (int i = 0; i < numAsignaturas; i++)
            {
                Console.Write("Ingrese el nombre de la asignatura {0}: ", i + 1);
                asignaturas[i] = Console.ReadLine();

                Console.Write("Ingrese la nota de {0}: ", asignaturas[i]);
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < numAsignaturas; i++)
            {
                Console.ForegroundColor = notas[i] >= 5 ? ConsoleColor.Green : ConsoleColor.Red;
                string estado = notas[i] >= 5 ? "Aprobado" : "Suspenso";
                Console.WriteLine("Asignatura {0} - {1} - {2}", asignaturas[i], notas[i], estado);
                Console.ResetColor();
            }
        }

        static void Ejercicio9()
        {
            Console.WriteLine("\n\tEjercicio 9:");

            Console.Write("Ingrese el tamaño del triángulo: ");
            int tam = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= tam; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void Ejercicio10()
        {
            Console.WriteLine("\n\tEjercicio 10:");

            Random rnd = new Random();
            int numero = rnd.Next(1, 101);
            int intentos = 0;

            while (true)
            {
                Console.Write("Adivina el número (1-100): ");
                int guess = Convert.ToInt32(Console.ReadLine());
                intentos++;

                if (guess == numero)
                {
                    Console.WriteLine("¡Adivinaste el número en {0} intentos!", intentos);
                    Console.Write("¿Quieres adivinar otro número? (s/n): ");
                    string respuesta = Console.ReadLine();
                    if (respuesta.ToLower() == "s")
                    {
                        Ejercicio10();
                    }
                    break;
                }
                else if (guess > numero)
                {
                    Console.WriteLine("El número es más pequeño");
                }
                else
                {
                    Console.WriteLine("El número es más grande");
                }
            }
        }

        static void Ejercicio11()
        {
            Console.WriteLine("\n\tEjercicio 11:");

            int total = 0;
            int num;

            do
            {
                Console.Write("Ingresa un número (0 para terminar): ");
                num = Convert.ToInt32(Console.ReadLine());
                total += num;
            } while (num != 0);

            Console.WriteLine("La suma de los números es {0}", total);
            Console.WriteLine("Terminado");
        }

        static void Ejercicio12()
        {
            Console.WriteLine("\n\tEjercicio 12:");

            Console.Write("Ingrese el precio del objeto: ");
            double precio = double.Parse(Console.ReadLine());

            // Comprobamos que el precio es positivo
            while (precio < 0)
            {
                Console.Write("El precio debe ser positivo. Ingrese el precio del objeto: ");
                precio = double.Parse(Console.ReadLine());
            }

            Console.Write("¿Desea pagar con efectivo o con tarjeta? (e/t): ");
            string opcionPago = Console.ReadLine();

            if (opcionPago.ToLower() == "e")
            {
                Console.WriteLine($"Pagó {precio} con efectivo.");
            }
            else if (opcionPago.ToLower() == "t")
            {
                Console.Write("Ingrese el número de tarjeta: ");
                string numeroTarjeta = Console.ReadLine();
                Console.WriteLine($"Pagó {precio} con tarjeta {numeroTarjeta}.");
            }
            else
            {
                Console.WriteLine("Opción de pago inválida.");
            }
        }

        static void Ejercicio13()
        {
            int n, fact = 1;
            Console.Write("Ingrese un número entero positivo: ");
            n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Error: El número debe ser positivo.");
            }
            else if (n == 0)
            {
                Console.WriteLine("El factorial de 0 es 1.");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                    Console.WriteLine(fact);
                }
                Console.WriteLine("El factorial de {0} es {1}.", n, fact);
            }

            Console.ReadKey();
        }

        static void Ejercicio13_Clase()
        {
            Console.WriteLine("Ingrese un número positivo para hacer el fatorial:");
            int num = int.Parse(Console.ReadLine());
            int total = 1;
            string numeros = "";
            for (int i = 1; i <= num; i++)
            {
                numeros += $"{i}*";
                total *= i;
            }
            Console.WriteLine("{0} = {1}", numeros, total);
        }

        static void Ejercicio14_Clase()
        {
            Console.WriteLine("Ingrese una cadena:");
            string cadena = Console.ReadLine();

            foreach (char letra in cadena)
            {
                Console.WriteLine(Convert.ToInt32(letra));
            }
        }

        static void Ejercicio14()
        {
            Console.Write("Introduce una cadena: ");
            string cadena = Console.ReadLine();

            Console.WriteLine("Código ASCII de la cadena:");

            foreach (char c in cadena)
            {
                int codigo = c;
                Console.Write("{0} ", codigo);
            }

            Console.ReadKey();
        }

        static void Ejercicio15()
        {
            Console.Write("Ingrese una cadena: ");
            string cadena = Console.ReadLine();

            string pares = "";
            string impares = "";

            for (int i = 0; i < cadena.Length; i++)
            {
                if (i % 2 == 0)
                {
                    pares += cadena[i];
                }
                else
                {
                    impares += cadena[i];
                }
            }

            Console.WriteLine("Cadena con posiciones pares: {0}", pares);
            Console.WriteLine("Cadena con posiciones impares: {0}", impares);

            Console.ReadKey();
        }

        static void Ejercicio16()
        {
            int[,] numeros = new int[3, 4];


            #region Numeros
            numeros[0, 0] = 11;
            numeros[0, 1] = 12;
            numeros[0, 2] = 13;
            numeros[0, 3] = 14;

            numeros[1, 0] = 21;
            numeros[1, 1] = 22;
            numeros[1, 2] = 23;
            numeros[1, 3] = 24;

            numeros[2, 0] = 31;
            numeros[2, 1] = 32;
            numeros[2, 2] = 33;
            numeros[2, 3] = 34;
            #endregion

            Console.WriteLine(numeros.Length);
            Console.WriteLine("+----+----+----+----+");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0,-2} | ", numeros[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine("+----+----+----+----+");
            }
        }

        static void Ejercicio17()
        {
            string[] options = { "piedra", "papel", "tijeras" };
            Console.WriteLine("Bienvenido al juego de piedra, papel o tijeras!");
            while (true)
            {
                Console.Write("Elija una opción (piedra, papel, tijeras): ");
                string playerChoice = Console.ReadLine().ToLower();
                if (Array.IndexOf(options, playerChoice) == -1)
                {
                    Console.WriteLine("Opción inválida. Por favor, intente nuevamente.");
                    continue;
                }

                Random random = new Random();
                int computerChoice = random.Next(0, 3);
                Console.WriteLine($"La computadora eligió: {options[computerChoice]}");
                int result = (Array.IndexOf(options, playerChoice) - computerChoice + 3) % 3;
                if (result == 0)
                {
                    Console.WriteLine("Empate!");
                }
                else if (result == 1)
                {
                    Console.WriteLine("Ganaste!");
                }
                else
                {
                    Console.WriteLine("La computadora gana!");
                }
                Console.Write("¿Quieres jugar de nuevo? (s/n): ");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain != "s")
                {
                    break;
                }
            }
        }

        static void Ejercicio18()
        {
            Console.Write("Introduce un número en hexadecimal: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input, 16);
            string romanNumber = ConvertToRoman(number);
            Console.WriteLine($"El número romano correspondiente es: {romanNumber}");
            Console.ReadKey();
        }

        static string ConvertToRoman(int number)
        {
            string[] romanNumeral = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string result = "";
            for (int i = 0; i < values.Length; i++)
            {
                while (number >= values[i])
                {
                    result += romanNumeral[i];
                    number -= values[i];
                }
            }
            return result;
        }

        static void Ejercicio19_Clase()
        {
            Console.WriteLine("Indica la entidad y la sucursal:");
            string cadena = Console.ReadLine();

            int[] numCadena = new int[8];
            int[] entidadMulty = { 4, 8, 5, 10 };
            int[] sucursalMulty = { 9, 7, 3, 6 };
            int total = 0;
            int digitoControl = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                numCadena[i] = Convert.ToInt32(cadena[i].ToString());
            }

            for (int j = 0; j < 4; j++)
            {
                total += numCadena[j] * entidadMulty[j];
            }

            for (int y = 0, z = 4; y < 4; y++, z++)
            {
                total += numCadena[z] * sucursalMulty[y];
            }

            switch (total % 11)
            {
                case 10:
                    digitoControl = 1;
                    break;
                case 11:
                    digitoControl = 0;
                    break;
                default:
                    digitoControl = 11 - total % 11;
                    break;
            }

            Console.WriteLine("Resultado = {0}", digitoControl);
            Console.ReadLine();
        }

        static void Ejercicio19()
        {
            Console.WriteLine("Ingrese los 4 dígitos del código de entidad:");
            string entidadString = Console.ReadLine();
            int[] entidad = new int[4];

            for (int i = 0; i < 4; i++)
            {
                entidad[i] = Convert.ToInt32(entidadString[i].ToString());
            }

            Console.WriteLine("Ingrese los 4 dígitos del número de oficina:");
            string oficinaString = Console.ReadLine();
            int[] oficina = new int[4];

            for (int i = 0; i < 4; i++)
            {
                oficina[i] = Convert.ToInt32(oficinaString[i].ToString());
            }
            int entidadSum = entidad[0] * 4 + entidad[1] * 8 + entidad[2] * 5 + entidad[3] * 10;
            int oficinaSum = oficina[0] * 9 + oficina[1] * 7 + oficina[2] * 3 + oficina[3] * 6;
            int totalSum = entidadSum + oficinaSum;
            int resto = totalSum % 11;

            int digitoControl;

            if (resto == 10)
            {
                digitoControl = 1;
            }
            else if (resto == 11)
            {
                digitoControl = 0;
            }
            else
            {
                digitoControl = 11 - resto;
            }
            Console.WriteLine("El primer dígito de control es: " + digitoControl);

            Console.ReadKey();
        }

        static void Ejercicio20_Clase()
        {
            Console.WriteLine("Escribe un NIF o NIE");
            string nifNie = Console.ReadLine();
        }

        static void Ejercicio20()
        {
            Console.WriteLine("Escribe un NIF o NIE");
            string nifNie = Console.ReadLine();

            var letters = "TRWAGMYFPDXBNJZSQVHLCKE";
            var regexNumeros = new Regex("[0-9]");
            var regexletterNie = new Regex("[XYZ]");

            if (nifNie.Length == 9 && int.TryParse(nifNie[0..8], out var numberNif) && regexNumeros.IsMatch(nifNie[0].ToString()))
            {
                var value = numberNif % 23;
                if (nifNie[8].ToString().ToUpper().Equals(letters[value].ToString()))
                {
                    Console.WriteLine("Es valido este NIF");
                }
                Console.WriteLine("No es valido este NIF");
            }

            else if (regexletterNie.IsMatch(nifNie[0].ToString()) && int.TryParse(nifNie[1..8], out var numberNie) && nifNie.Length == 9)
            {
                switch (nifNie[0].ToString())
                {
                    case "X":
                        numberNie = int.Parse("0" + numberNie.ToString());
                        break;
                    case "Y":
                        numberNie = int.Parse("1" + numberNie.ToString());
                        break;
                    case "Z":
                        numberNie = int.Parse("2" + numberNie.ToString());
                        break;
                }

                var value = numberNie % 23;
                if (nifNie[8].ToString().ToUpper().Equals(letters[value].ToString()))
                {
                    Console.WriteLine("Es valido este NIE");
                }
                else
                {
                    Console.WriteLine("No es valido este Nie");
                }
            }

            Console.ReadKey();
        }

        static void Ejercicio21()
        {
            Console.WriteLine("Por favor ingrese su fecha de nacimiento en formato dd/mm/aaaa: ");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

            DateTime hoy = DateTime.Today;

            int añosTranscurridos = hoy.Year - fechaNacimiento.Year;
            int mesesTranscurridos = hoy.Month - fechaNacimiento.Month;
            int diasTranscurridos = hoy.Day - fechaNacimiento.Day;

            if (mesesTranscurridos < 0 || mesesTranscurridos == 0 && diasTranscurridos < 0)
            {
                añosTranscurridos--;
                mesesTranscurridos += 12;
                if (diasTranscurridos < 0)
                {
                    diasTranscurridos += DateTime.DaysInMonth(fechaNacimiento.Year, fechaNacimiento.Month);
                }
            }
            else if (diasTranscurridos < 0)
            {
                mesesTranscurridos--;
                diasTranscurridos += DateTime.DaysInMonth(fechaNacimiento.Year, fechaNacimiento.Month);
            }

            Console.WriteLine("Han pasado {0} años, {1} meses y {2} días desde tu fecha de nacimiento.", añosTranscurridos, mesesTranscurridos, diasTranscurridos);
            Console.ReadLine();

            DateTime proximoCumpleaños = new DateTime(hoy.Year, fechaNacimiento.Month, fechaNacimiento.Day);
            if (proximoCumpleaños < hoy)
            {
                proximoCumpleaños = proximoCumpleaños.AddYears(1);
            }

            int diasParaCumpleaños = (proximoCumpleaños - hoy).Days;
            Console.WriteLine("Faltan {0} días para su próximo cumpleaños.", diasParaCumpleaños);
        }

    }
}
