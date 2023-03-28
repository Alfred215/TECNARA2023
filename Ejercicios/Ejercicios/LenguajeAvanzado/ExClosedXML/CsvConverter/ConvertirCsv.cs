using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExClosedXML.CsvConverter
{
    public class ConvertirCsv
    {
        public ConvertirCsv()
        {
            var personas = new List<Persona>();

            // Leer el archivo CSV y crear objetos de persona
            string csvFilePath = Path.GetFullPath(@"..\..\..\LenguajeAvanzado\ExClosedXML\CsvConverter\file.csv");
            
            // Leer la fila de cabecera y omitirla
            var reader = File.ReadAllLines(csvFilePath);

            foreach(var line in reader)
            {
                var values = line.Split(';');

                if (!(values[0] == "Nombre"))
                {
                    var persona = new Persona
                    (
                        values[0],
                        values[1],
                        int.Parse(values[3]),
                        values[4],
                        int.Parse(values[5])
                    );
                    personas.Add(persona);
                }
            }

            // Escribir los datos en un archivo de Excel
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Personas");
                worksheet.Cell(1, 1).Value = "Nombre";
                worksheet.Cell(1, 2).Value = "Contraseña";
                worksheet.Cell(1, 3).Value = "ContraseñaHash";
                worksheet.Cell(1, 4).Value = "Edad";
                worksheet.Cell(1, 5).Value = "Banco";
                worksheet.Cell(1, 6).Value = "Saldo";

                for (int i = 0; i < personas.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = personas[i].Nombre;
                    worksheet.Cell(i + 2, 2).Value = personas[i].Contraseña;
                    worksheet.Cell(i + 2, 3).Value = personas[i].ContraseñaHash;
                    worksheet.Cell(i + 2, 4).Value = personas[i].Edad;
                    worksheet.Cell(i + 2, 5).Value = personas[i].Banco;
                    worksheet.Cell(i + 2, 6).Value = personas[i].Saldo;
                }

                string excelFilePath = Path.GetFullPath(@"..\..\..\LenguajeAvanzado\ExClosedXML\CsvConverter\converter.xlsx");
                workbook.SaveAs(excelFilePath);
            }
        }
    }
}
