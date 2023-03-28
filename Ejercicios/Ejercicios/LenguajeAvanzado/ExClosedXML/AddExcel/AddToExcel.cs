using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExClosedXML.AddExcel
{
    internal class AddToExcel
    {
        public AddToExcel() {

            string excelFilePath = Path.GetFullPath(@"..\..\..\LenguajeAvanzado\ExClosedXML\AddExcel\Productos.xlsx");

            var workbook = new XLWorkbook(excelFilePath);
            var worksheet = workbook.Worksheet("Hoja1");
            var miTabla = worksheet.Table("Tabla1");

            // Pedir nuevos datos
            Console.Write("Ingrese el nombre del producto: ");
            string producto = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            var nuevaFila = miTabla.DataRange.InsertRowsBelow(1).First();
            nuevaFila.Cell(1).Value = producto;
            nuevaFila.Cell(2).Value = cantidad;

            workbook.Save();

            Console.WriteLine("Datos agregados correctamente.");
        } 
    }
}
