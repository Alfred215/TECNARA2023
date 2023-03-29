using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClosedXML.Excel.XLPredefinedFormat;

namespace Ejercicios.LenguajeAvanzado.ExClosedXML.Banco
{
    public class MetodosBanco
    {
        public IXLWorkbook CrearCuanta(IXLWorkbook workbook)
        {
            Console.WriteLine("Dime tu nombre");
            var nombre = Console.ReadLine();
            IXLWorksheet workSheet = workbook.AddWorksheet(nombre);

            var datatable = new DataTable();
            datatable.Columns.Add("Saldo", typeof(Int32));
            datatable.Columns.Add("Ingresos", typeof(Int32));
            datatable.Columns.Add("Retiradas",typeof(Int32));
            
            Console.WriteLine("Saldo inicial");
            var saldo = Convert.ToInt32(Console.ReadLine());
            datatable.Rows.Add(saldo, saldo, 0);
            workSheet.FirstCell().InsertTable(datatable, nombre);

            Console.WriteLine("Dime tu contraseña");
            workSheet.Protection.Protect(Console.ReadLine());
            workbook.Save();
            return workbook;
        }

        public void Ingresar(IXLWorksheet workSheet, string nombre, string contraseña)
        {
            var tabla =  workSheet.Table(nombre);
            var saldoActual = tabla.LastRow().Cell(1).Value;

            Console.WriteLine("Cuanto quieres ingresar?");
            int ingreso = Convert.ToInt32(Console.ReadLine());

            var row = tabla.DataRange.InsertRowsBelow(1).Last();
            row.Cell(1).Value = ingreso + Convert.ToInt32(saldoActual.GetNumber());
            row.Cell(2).Value = ingreso;
            row.Cell(3).Value = 0;

            workSheet.Protection.Protect(contraseña);
        }
        public void Retirar(IXLWorksheet workSheet, string nombre, string contraseña)
        {
            var tabla = workSheet.Table(nombre);
            var saldoActual = tabla.LastRow().Cell(1).Value;

            Console.WriteLine("Cuanto quieres retirar?");
            int retirada = Convert.ToInt32(Console.ReadLine());

            var row = tabla.DataRange.InsertRowsBelow(1).Last();
            row.Cell(1).Value = Convert.ToInt32(saldoActual.GetNumber()) - retirada;
            row.Cell(2).Value = 0;
            row.Cell(3).Value = retirada;

            workSheet.Protection.Protect(contraseña);
        }
    }
}
