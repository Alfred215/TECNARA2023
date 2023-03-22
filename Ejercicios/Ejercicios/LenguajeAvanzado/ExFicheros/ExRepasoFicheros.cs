using Ejercicios.Juegos.Ahorcado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExFicheros
{
    public class ExRepasoFicheros
    {
        public ExRepasoFicheros()
        {
            string filePath = "../../../LenguajeAvanzado/ExFicheros/GeneradorContrasena/archivo.txt";

            //-------------------------------------------------------------------------------------------------


            Console.WriteLine("Ejercicio 2: \n");
            string[] lines = File.ReadAllLines(filePath);
            int wordCount = lines.Count();
            Console.WriteLine("El archivo de texto contiene {0} palabras.", wordCount);


            //-------------------------------------------------------------------------------------------------


            Console.WriteLine("Ejercicio 3: \n");
            using (StreamReader reader = new StreamReader(filePath))
            {
                int lineNumber = 0;
                string line;
                while ((line = reader.ReadLine()) != null && lineNumber < 10)
                {
                    Console.WriteLine(line);
                    lineNumber++;
                }
            }


            //-------------------------------------------------------------------------------------------------

            Console.WriteLine("Ejercicio 4: \n");
            string[] lineas = File.ReadAllLines(filePath);
            Console.Write("Ingrese la cadena de texto a buscar: ");
            string searchText = Console.ReadLine();

            var result = lineas.ToList().IndexOf(searchText);
            Console.WriteLine($"La primera vez que se encuentra {searchText} es en la posición {result}");

            List<int> posiciones = new List<int>();
            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i] == searchText)
                {
                    posiciones.Add(i);
                }
            }

            foreach (int posicion in posiciones)
            {
                Console.WriteLine($"La palabra '{searchText}' se encuentra en la posición {posicion} del array.");
            }

            Console.ReadKey();
        }
    }
}
