using Ejercicios.BBDD.Ejercicios.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios.Ejercicio1_BBDD
{
    public class Metodos1_BBDD 
    {
        dbContextEjercicios db;
        public Metodos1_BBDD(dbContextEjercicios _db) 
        {
            db = _db;
        }

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
                foreach (var empresa in empresas)
                {
                    Console.WriteLine("Id: {0} Nombre: {1} Localización: {2} Cantidad Empleados: {3} Cantidad Oficinas: {4}", empresa.Id, empresa.Nombre, empresa.Localización, empresa.CantidadEmpleados, empresa.CantidadOficinas);
                }
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
                foreach (var empresa in empresas)
                {
                    Console.WriteLine("Id: {0} Nombre: {1} Localización: {2} Cantidad Empleados: {3} Cantidad Oficinas: {4}", empresa.Id, empresa.Nombre, empresa.Localización, empresa.CantidadEmpleados, empresa.CantidadOficinas);
                }
            }
        }

        public void AddEdit(Empresa empresa)
        {
            if (GetById(empresa.Id) != null)
            {
                Edit(empresa);
            }
            else
            {
                AddAsync(empresa);
            }
        }

        public async Task AddAsync(Empresa empresa)
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

        public void Delete(int id)
        {
            var person = GetById(id);
            db.Remove(person);
            db.SaveChanges();

            GetList();
        }
    }
}
