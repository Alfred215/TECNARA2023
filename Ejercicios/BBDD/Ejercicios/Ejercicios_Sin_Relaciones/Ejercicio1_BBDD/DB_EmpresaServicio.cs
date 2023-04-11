using Ejercicios.BBDD.Ejercicios.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios.Ejercicio1_BBDD
{
    public class DB_EmpresaServicio 
    {
        dbContextEjercicios db;
        public DB_EmpresaServicio(dbContextEjercicios _db) 
        {
            db = _db;
        }

        #region GET
        public Empresa GetById(int id)
        {
            var empresa = db.Empresa.Where(x => x.Id == id).FirstOrDefault();
            //Console.WriteLine("Filtro por Id");
            //Console.WriteLine("Id: {0} Nombre: {1} P. Apellido: {2} S. Apellido: {3} Edad: {4}", empresa.Id, empresa.Nombre, empresa.Localización, empresa.CantidadEmpleados, empresa.CantidadOficinas);
            return empresa;

        }

        public void GetList()
        {
            var empresas = db.Empresa.ToList();

            if (empresas.Count == 0)
            {
                Console.WriteLine("\nNo hay datos");
            }
            else
            {
                Console.WriteLine("\nLista completa");
                empresas.ForEach(x => Console.WriteLine(" - Id: {0} Nombre: {1} Localización: {2} Cantidad Empleados: {3} Cantidad Oficinas: {4}", x.Id, x.Nombre, x.Localización, x.CantidadEmpleados, x.CantidadOficinas));
            }
        }

        public void GetListFilterByCantEmployee(int min, int max)
        {
            var empresas = db.Empresa.Where(x => x.CantidadEmpleados >= min && x.CantidadEmpleados <= max).OrderBy(x => x.CantidadEmpleados).ToList();

            if (empresas.Count == 0)
            {
                Console.WriteLine("\nNo hay datos");
            }
            else
            {
                Console.WriteLine("\nLista completa");
                empresas.ForEach(x => Console.WriteLine(" - Id: {0} Nombre: {1} Localización: {2} Cantidad Empleados: {3} Cantidad Oficinas: {4}", x.Id, x.Nombre, x.Localización, x.CantidadEmpleados, x.CantidadOficinas));
            }
        }
        #endregion

        #region SET
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

        public async void AddEdit(Empresa empresa)
        {
            if (GetById(empresa.Id) != null)
            {
                Edit(empresa);
                Console.WriteLine("Empresa guardada correctamente");
            }
            else
            {
                await Create(empresa);
                Console.WriteLine("Empresa creada correctamente");
            }
        }

        public async Task Create(Empresa empresa)
        {
            empresa.Id = 0;
            await db.AddAsync(empresa);
            db.SaveChanges();

            GetList();
        }

        public void Edit(Empresa empresa)
        {
            var empresaOld = GetById(empresa.Id);
            empresaOld.Nombre = empresa.Nombre;
            empresaOld.Localización = empresa.Localización;
            empresaOld.CantidadEmpleados = empresa.CantidadEmpleados;
            empresaOld.CantidadOficinas = empresa.CantidadOficinas;

            db.SaveChanges();
            GetList();
        }
        #endregion

        #region DELETE
        public void Delete(int id)
        {
            var empr = GetById(id);
            db.Remove(empr);
            db.SaveChanges();

            GetList();
        } 
        #endregion
    }
}
