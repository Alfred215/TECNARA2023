using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExClosedXML.Pruebas
{
    public class EjPruebas
    {
        string filename = "";
        string realPath = "";
        public EjPruebas() 
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..");
            string fullpath = Path.GetFullPath(path);
            realPath = Path.Combine(fullpath, $"LenguajeAvanzado\\ExClosedXML\\Pruebas");
            filename = Path.Combine(realPath, "Prueba.xlsx");
        }

        public void AbrirExcel()
        {
            IXLWorkbook workbook = new XLWorkbook(filename);

            IXLWorksheet worksheet = workbook.Worksheet("Hoja1");

            IXLCell cell = worksheet.Cell("A1");
            Console.WriteLine(cell.Value);
        }

        public void CrearExcel()
        {
            IXLWorkbook workbook = new XLWorkbook();

            IXLWorksheet worksheet = workbook.AddWorksheet("NewHoja");

            worksheet.Cell("A1").Value = "Meto datos";
            worksheet.Cell("B2").Value = "Esto es B2";

            workbook.SaveAs("NuevaPrueba");
        }

        public void EliminarExcel()
        {
            filename = Path.Combine(realPath, "NuevaPrueba.xlsx");
            IXLWorkbook workbook = new XLWorkbook(filename);

            IXLWorksheet worksheet = workbook.Worksheet("NewHoja");

            IXLCell cell = worksheet.Cell("A1");
            Console.WriteLine(cell.Value);
            
            File.Delete(filename);
        }
    }
}
