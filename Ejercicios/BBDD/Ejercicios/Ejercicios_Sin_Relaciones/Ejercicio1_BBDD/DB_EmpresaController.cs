using Ejercicios.BBDD.Ejercicios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios.Ejercicio1_BBDD
{
    public class DB_EmpresaController
    {
        DB_EmpresaServicio _empresaSV;

        public DB_EmpresaController(dbContextEjercicios db) 
        {
            _empresaSV = new DB_EmpresaServicio(db);
            IniciarMenu();
        }

        public void IniciarMenu()
        {
            int accion = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1- Buscar por Id");
                Console.WriteLine("2- Mostrar Lista");
                Console.WriteLine("3- Añadir o Editar");
                Console.WriteLine("4- Eliminar");
                Console.WriteLine("5- Salir");
                Console.ResetColor();

                accion = Convert.ToInt32(Console.ReadLine());

                switch(accion) 
                {
                    case 1:
                        Console.WriteLine("¿Qué id estás buscando? ");
                        var empresaOnly = _empresaSV.GetById(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Id: {0} Nombre: {1} Localización: {2} Cantidad Empleados: {3} Cantidad Oficinas: {4} \n", empresaOnly.Id, empresaOnly.Nombre, empresaOnly.Localización, empresaOnly.CantidadEmpleados, empresaOnly.CantidadOficinas);
                        break;
                    case 2:
                        _empresaSV.GetList();
                        break;
                    case 3:
                        var empresa = _empresaSV.CreateEmpresa();
                        _empresaSV.AddEdit(empresa);
                        break;
                    case 4:
                        Console.WriteLine("Dime la id: ");
                        _empresaSV.Delete(Convert.ToInt32(Console.ReadLine()));
                        break;
                    default:
                        break;

                }

            } while (accion != 5 && accion < 5);
        }
    }
}
