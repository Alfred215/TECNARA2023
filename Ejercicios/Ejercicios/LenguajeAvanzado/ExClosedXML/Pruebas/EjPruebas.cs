using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main;
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

            IXLCell cell = worksheet.Cell(1,1);
            Console.WriteLine(cell.Value);
        }

        public void CrearExcel()
        {
            IXLWorkbook workbook = new XLWorkbook();

            IXLWorksheet worksheet = workbook.AddWorksheet("NewHoja");

            worksheet.Cell("A1").Value = "Meto datos";
            worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.Red;
            worksheet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            worksheet.Cell("A1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            worksheet.Cell("A1").Style.Fill.PatternColor = XLColor.White; 
            worksheet.Cell("B2").Value = "Esto es B2";

            filename = Path.Combine(realPath, "NuevaPrueba.xlsx");
            workbook.SaveAs(filename);
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

        public void CrearExcelAsignaturas()
        {
            IXLWorkbook workbook = new XLWorkbook();

            IXLWorksheet worksheet = workbook.AddWorksheet("NewHoja");

            List<(string, decimal)> asignaturas = new List<(string, decimal)>();

            Console.Write("Ingrese la cantidad de asignaturas: ");
            int numAsignaturas = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numAsignaturas; i++)
            {
                Console.Write("Ingrese el nombre de la asignatura {0}: ", i + 1);
                string asignatura = Console.ReadLine();

                Console.Write("Ingrese la nota de {0}: ", asignatura);
                decimal nota = Convert.ToDecimal(Console.ReadLine());

                asignaturas.Add((asignatura,nota));
            }

            for (int i = 0; i < numAsignaturas; i++)
            {
                worksheet.Cell(i + 1, 1).Value = "Asignatura";
                worksheet.Cell(i + 1, 1).Style.Fill.BackgroundColor = asignaturas[i].Item2 >= 5 ? XLColor.Green : XLColor.Red;
                worksheet.Cell(i + 1, 2).Value = asignaturas[i].Item1;
                worksheet.Cell(i + 1, 3).Value = asignaturas[i].Item2;
                worksheet.Cell(i + 1, 4).Value = asignaturas[i].Item2 >= 5 ? "Aprobado" : "Suspenso";
            }

            filename = Path.Combine(realPath, "Asignaturas.xlsx");
            workbook.SaveAs(filename);
        }


    }
}
