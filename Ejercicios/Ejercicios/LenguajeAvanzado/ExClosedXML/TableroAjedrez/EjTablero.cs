using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExClosedXML.TableroAjedrez
{
    public class EjTablero
    {
        public EjTablero() 
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\LenguajeAvanzado\ExClosedXML\TableroAjedrez\tablero.xlsx");
            string filename = Path.GetFullPath(path);

            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Tablero de ajedrez");

            worksheet.ColumnWidth = 2;
            worksheet.RowHeight = 15;

            for (int row = 1; row <= 100; row++)
            {
                for (int col = 1; col <= 100; col++)
                {
                    var cell = worksheet.Cell(row, col);
                    var border = cell.Style.Border;
                    border.TopBorder = XLBorderStyleValues.Thin;
                    border.BottomBorder = XLBorderStyleValues.Thin;
                    border.LeftBorder = XLBorderStyleValues.Thin;
                    border.RightBorder = XLBorderStyleValues.Thin;

                    if ((row + col) % 2 == 0)
                    {
                        cell.Style.Fill.BackgroundColor = XLColor.Red;
                    }
                    else
                    {
                        cell.Style.Fill.BackgroundColor = XLColor.Yellow;
                    }
                }
            }

            workbook.SaveAs(filename);
        }
    }
}
