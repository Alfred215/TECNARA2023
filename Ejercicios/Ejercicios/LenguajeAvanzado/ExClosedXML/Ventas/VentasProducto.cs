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
            // Crear archivo Excel
            using (var workbook = new XLWorkbook())
            {
                // Crear hoja "Ventas"
                var ventasSheet = workbook.Worksheets.Add("Ventas");

                // Agregar datos a la tabla de ventas
                var ventasTable = ventasSheet.Range("A1:D3").CreateTable();
                ventasTable.Field(0).Name = "Producto";
                ventasTable.Field(1).Name = "Mes 1";
                ventasTable.Field(2).Name = "Mes 2";
                ventasTable.Field(3).Name = "Mes 3";
                ventasTable.Cell(2, 1).SetValue("Producto A");
                ventasTable.Cell(2, 2).SetValue(1000);
                ventasTable.Cell(2, 3).SetValue(2000);
                ventasTable.Cell(2, 4).SetValue(1500);
                ventasTable.Cell(3, 1).SetValue("Producto B");
                ventasTable.Cell(3, 2).SetValue(500);
                ventasTable.Cell(3, 3).SetValue(1000);
                ventasTable.Cell(3, 4).SetValue(750);

                // Crear hoja "Inventario"
                var inventarioSheet = workbook.Worksheets.Add("Inventario");

                // Agregar datos a la tabla de inventario
                var inventarioTable = inventarioSheet.Range("A1:B4").CreateTable();
                inventarioTable.Field(0).Name = "Producto";
                inventarioTable.Field(1).Name = "Cantidad";
                inventarioTable.Cell(2, 1).SetValue("Producto A");
                inventarioTable.Cell(2, 2).SetValue(100);
                inventarioTable.Cell(3, 1).SetValue("Producto B");
                inventarioTable.Cell(3, 2).SetValue(50);
                inventarioTable.Cell(4, 1).SetValue("Producto C");
                inventarioTable.Cell(4, 2).SetValue(75);

                // Crear hoja "Personal"
                var personalSheet = workbook.Worksheets.Add("Personal");

                // Agregar datos a la tabla de personal
                var personalTable = personalSheet.Range("A1:C4").CreateTable();
                personalTable.Field(0).Name = "Nombre";
                personalTable.Field(1).Name = "Apellido";
                personalTable.Field(2).Name = "Fecha de contratación";
                personalTable.Cell(2, 1).SetValue("Juan");
                personalTable.Cell(2, 2).SetValue("Pérez");
                personalTable.Cell(2, 3).SetValue(new DateTime(2020, 1, 1));
                personalTable.Cell(3, 1).SetValue("María");
                personalTable.Cell(3, 2).SetValue("García");
                personalTable.Cell(3, 3).SetValue(new DateTime(2019, 6, 1));
                personalTable.Cell(4, 1).SetValue("Pedro");
                personalTable.Cell(4, 2).SetValue("López");
                personalTable.Cell(4, 3).SetValue(new DateTime(2021, 3, 1));

                string csvFilePath = Path.GetFullPath(@"..\..\..\LenguajeAvanzado\ExClosedXML\Ventas\ventas.xlsx");

                // Guardar archivo Excel
                workbook.SaveAs(csvFilePath);
            }
        }
    }
}
