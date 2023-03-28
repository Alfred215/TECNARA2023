using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExClosedXML.Ventas
{
    public class VentasProducto
    {
        public VentasProducto() {

            string csvFilePath = Path.GetFullPath(@"..\..\..\LenguajeAvanzado\ExClosedXML\Ventas\CompraLista.xlsx");

            using (var workbook = new XLWorkbook())
            {
                var ventasSheet = workbook.AddWorksheet("Ventas");

                var ventasTable = ventasSheet.Range("A1:D3").CreateTable();
                ventasTable.Field(0).Name = "Productos";
                ventasTable.Field(1).Name = "Junio";
                ventasTable.Field(2).Name = "Julio";
                ventasTable.Field(3).Name = "Agosto";

                ventasTable.Cell("A2").SetValue("Pan");
                ventasTable.Cell(2, 2).SetValue("4328");
                ventasTable.Cell(2, 3).SetValue("4324");
                ventasTable.Cell(2, 4).SetValue("2343");

                ventasTable.Cell(3, 1).SetValue("Leche");
                ventasTable.Cell(3, 2).SetValue("4324");
                ventasTable.Cell(3, 3).SetValue("9372");
                ventasTable.Cell(3, 4).SetValue("342");

                ventasTable.Cell(4, 1).SetValue("Azucar");
                ventasTable.Cell(4, 2).SetValue("532");
                ventasTable.Cell(4, 3).SetValue("9836");
                ventasTable.Cell(4, 4).SetValue("1020");

                //---------------------------------------------

                //.Cell(8,9) -> alternativa
                ventasSheet.Cell("H9").InsertTable(new[]
                {
                    ("Harina", 4932843),
                    ("Huevos", 938243),
                    ("Chocolate", 483423)

                }, "Ingredientes", true);

                var table = ventasSheet.Table("Ingredientes");
                table.Field(0).Name = "Nombre";
                table.Field(1).Name = "Precio";


                workbook.SaveAs(csvFilePath);
            }
        }
    }
}
