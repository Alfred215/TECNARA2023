using Ejercicios.LenguajeAvanzado.ExFicheros.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExFicheros
{
    public class ExTheory
    {
        public ExTheory() 
        {
            string filePath = "../../../LenguajeAvanzado/ExFicheros/ficheroTexto.txt";
            string[] lineas = new string[3]
            {
                "Una linea", "Otra linea", "¡y otra más!"
            };

            //----------------------------------------------------------------------------
                //StreamWriter file = new StreamWriter(filePath);
                //foreach (string line in lineas)
                //{
                //    if (!line.Contains("Otra"))
                //    {
                //        file.WriteLine(line);
                //    }
                //}
                //file.Close();
            //----------------------------------------------------------------------------

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in lineas)
                {
                    if (!line.Contains("Otra"))
                    {
                        writer.WriteLine(line);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
