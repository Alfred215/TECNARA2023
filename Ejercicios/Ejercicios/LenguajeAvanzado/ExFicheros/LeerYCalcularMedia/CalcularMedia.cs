using System;
using System.Collections.Generic;
using System.Globalization;
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
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\LenguajeAvanzado\ExFicheros\LeerYCalcularMedia");
                string fullpath = Path.GetFullPath(path);

                string origen = Path.Combine(fullpath, "numeros.txt");
                string salida = Path.Combine(fullpath, "resultado.txt");

                var leer = File.ReadAllText(origen);
                var arraySeparado = leer.Split(',');
                var arraySinEspacio = arraySeparado.Select(x => x.Trim()).ToList();

                List<double> doubles = new List<double>();
                foreach (var snum in arraySinEspacio)
                {
                    if (double.TryParse(snum, NumberStyles.Float, CultureInfo.InvariantCulture, out double resultado)) 
                    {
                        //doubles.Add(double.Parse(snum, CultureInfo.InvariantCulture));
                        doubles.Add(resultado);
                    } else
                    {
                        Console.WriteLine($"El numero {snum} no es valido");
                        //throw new FormatException($"El numero {snum} no es valido");
                    }
                }

                double media = doubles.Average();

                File.WriteAllText(salida, $"La media de los numeros es {media}");

                Console.WriteLine("El programa ha finalizado");

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
