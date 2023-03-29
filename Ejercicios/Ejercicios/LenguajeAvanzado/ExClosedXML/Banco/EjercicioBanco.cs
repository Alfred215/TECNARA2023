using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExClosedXML.Banco
{
    public class EjercicioBanco
    {
        string excelFilePath = Path.GetFullPath(@"..\..\..\LenguajeAvanzado\ExClosedXML\Banco\Banco.xlsx");
        IXLWorkbook workbook ;
        MetodosBanco metodos = new MetodosBanco();
        public EjercicioBanco() 
        {
            workbook = new XLWorkbook(excelFilePath);
            Bucle();
        }

        public void Bucle()
        {
            do
            {
                Console.WriteLine("\n1-Crear Cuenta \n2-Añadir fondos \n3-Retirar fondos");
                int acciones = Convert.ToInt32(Console.ReadLine());

                switch (acciones)
                {
                    case 1:
                        workbook = metodos.CrearCuanta(workbook);
                        break;
                    case 2:
                        Console.WriteLine("\nDime tu nombre");
                        var nameIngreso = Console.ReadLine();
                        var workSheetIngresar = workbook.Worksheet(nameIngreso);

                        Console.WriteLine("\nDime tu contraseña");
                        var contraseñaIngresar = Console.ReadLine();

                        try { 
                            workSheetIngresar.Protection.Unprotect(contraseñaIngresar);
                            metodos.Ingresar(workSheetIngresar, nameIngreso, contraseñaIngresar);
                            workbook.Save();
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("\nContraseña Incorrecta");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nDime tu nombre");
                        var nameRetirada = Console.ReadLine();
                        var workSheetRetirar = workbook.Worksheet(nameRetirada);

                        Console.WriteLine("\nDime tu contraseña");
                        var contraseñaRetirar = Console.ReadLine();
                        try
                        {
                            workSheetRetirar.Protection.Unprotect(contraseñaRetirar);
                            metodos.Retirar(workSheetRetirar, nameRetirada, contraseñaRetirar);
                            workbook.Save();
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("\nContraseña Incorrecta");
                        }
                        break;
                }

            } while (true);
        }

    }
}
