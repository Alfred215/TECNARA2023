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
            // Leer el archivo CSV y crear objetos de persona
            string csvFilePath = Path.GetFullPath(@"..\..\..\LenguajeAvanzado\ExClosedXML\CsvConverter\file.csv");
            
            // Leer la fila de cabecera y omitirla
            var reader = File.ReadAllLines(csvFilePath);

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Personas");

                for (int i = 0; i < reader.Length; i++)
                {
                    var values = reader[i].Split(';');

                    for (int j = 0; j < values.Length; j++)
                    {
                        worksheet.Cell(i + 1, j+1).Value = values[j];
                    }
                }

                string excelFilePath = Path.GetFullPath(@"..\..\..\LenguajeAvanzado\ExClosedXML\CsvConverter\converter.xlsx");
                workbook.SaveAs(excelFilePath);
            }
        }
    }
}
