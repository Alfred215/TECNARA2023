using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicios.LenguajeAvanzado.ExFicheros.LeerYCalcularMedia
{
    public class CalcularMedia
    {
        public CalcularMedia()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..");
                string fullpath = Path.GetFullPath(path);
                string realPath = Path.Combine(fullpath, $"LenguajeAvanzado\\ExFicheros\\LeerYCalcularMedia");

                string fileName = Path.Combine(realPath, "numeros.txt");
                string outputFileName = Path.Combine(realPath, "media.txt");

                var leer = File.ReadAllText(fileName);
                var arraySeparado = leer.Split(',');
                var arrayQuitarEspacios = arraySeparado.Select(x => x.Trim());
                var comprobaciónDouble = arrayQuitarEspacios.Select(num =>
                {
                    // alternativa: (Regex.IsMatch(s, @"^\d+(\.\d+)?$"))
                    if (double.TryParse(num, out double result))
                        return result;
                    else
                        throw new FormatException($"El número {num} no es válido");
                });

                double media = comprobaciónDouble.Average();

                File.WriteAllText(outputFileName, $"La media de los números en {fileName} es {media}");

                Console.WriteLine($"Se ha calculado la media correctamente y se ha guardado en {outputFileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error: {ex.Message}");
            }
        }
    }
}
