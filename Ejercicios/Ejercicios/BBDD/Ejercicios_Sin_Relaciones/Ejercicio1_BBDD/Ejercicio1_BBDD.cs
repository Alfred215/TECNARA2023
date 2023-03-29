using Ejercicios.BBDD.Ejercicios.Entidades;
using Ejercicios.BBDD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios.Ejercicio1_BBDD
{
    public class Ejercicio1_BBDD
    {
        Metodos1_BBDD metodos;
        public Ejercicio1_BBDD(dbContextEjercicios db) 
        {
            metodos= new Metodos1_BBDD(db);
            Consultas();
        }

        public void Consultas()
        {
            int accion = 0;
            do
            {
                Console.WriteLine("1-Buscar por Id \n2-Mostrar Lista \n3-Añadir o Editar \n4-Eliminar \n5-Salir");
                accion = Convert.ToInt32(Console.ReadLine());

                switch(accion) 
                {
                    case 1:
                        Console.WriteLine("Dime la id: ");
                        var empresaOnly = metodos.GetById(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Id: {0} Nombre: {1} Localización: {2} Cantidad Empleados: {3} Cantidad Oficinas: {4} \n", empresaOnly.Id, empresaOnly.Nombre, empresaOnly.Localización, empresaOnly.CantidadEmpleados, empresaOnly.CantidadOficinas);
                        break;
                    case 2:
                        metodos.GetList();
                        break;
                    case 3:
                        var empresa = CreateEmpresa();
                        metodos.AddEdit(empresa);
                        break;
                    case 4:
                        Console.WriteLine("Dime la id: ");
                        metodos.Delete(Convert.ToInt32(Console.ReadLine()));
                        break;
                    default:
                        break;

                }

            } while (accion != 5 && accion < 5);
        }

        public Empresa CreateEmpresa()
        {
            Empresa empresa = new Empresa();

            Console.WriteLine("Id:");
            empresa.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre:");
            empresa.Nombre = Console.ReadLine();
            Console.WriteLine("Localización:");
            empresa.Localización = Console.ReadLine();
            Console.WriteLine("Cantidad de empleados");
            empresa.CantidadEmpleados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cantidad de oficinas");
            empresa.CantidadOficinas = Convert.ToInt32(Console.ReadLine());

            return empresa;
        }
    }
}
