using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExClosedXML.LeerExcel
{
    public class GananciasMes
    {
        public GananciasMes()
        {
            string excelFilePath = Path.GetFullPath(@"..\..\..\LenguajeAvanzado\ExClosedXML\LeerExcel\gananciames.xlsx");
            
            // Crea un objeto XLWorkbook para representar el archivo Excel
            XLWorkbook workbook = new XLWorkbook(excelFilePath);

            // Selecciona la hoja de trabajo que contiene los datos que deseas leer
            IXLWorksheet worksheet = workbook.Worksheet("Hoja1");

            // Recorre las filas de la tabla de datos y obtén los valores de las celdas correspondientes
            foreach (var row in worksheet.RowsUsed().Skip(1)) // Ignora la primera fila (encabezados)
            {
                string mes = row.Cell(1).GetString();
                double ventas = row.Cell(2).GetDouble();
                double ganancias = row.Cell(3).GetDouble();

                // Imprime los valores en pantalla
                Console.WriteLine("Mes: {0}, Ventas: {1}, Ganancias: {2}", mes, ventas, ganancias);
            }

            // Espera a que el usuario presione una tecla para cerrar la ventana de consola
            Console.ReadKey();
        }
    }
}
