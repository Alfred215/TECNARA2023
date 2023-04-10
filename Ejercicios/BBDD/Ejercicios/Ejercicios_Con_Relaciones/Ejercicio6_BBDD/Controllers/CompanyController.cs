using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.CompanyServices;
using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.PersonServices;
using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Controllers
{
    public class CompanyController
    {
        private CompanyService companySV;
        public CompanyController(dbContextEjerciciosRelaciones6 _db)
        {
            companySV = new CompanyService(_db);
        }

        public async Task AddEditCompanyAsync()
        {
            var listCompany = await companySV.GetList();
            int i = 0;
            foreach (var company in listCompany)
            {
                Console.WriteLine("{0}- Nombre: {1} Localización: {2} Cantidad de oficinas: {3} Cantidad de empleados: {4}", ++i, company.Nombre, company.Localizacion, company.CantidadOficinas, company.CantidadEmpleados);
            }

            Console.WriteLine("Elija una posición o escriba 0 para crear un nuevo registro");
            var position = Convert.ToInt32(Console.ReadLine());

            Empresa companyAddEdit = new Empresa();
            companyAddEdit.Id = position == 0 ? new Guid() : listCompany[position - 1].Id;
            Console.WriteLine("Nombre");
            companyAddEdit.Nombre = Console.ReadLine();
            Console.WriteLine("Localización");
            companyAddEdit.Localizacion = Console.ReadLine();
            Console.WriteLine("Cantidad de oficinas");
            companyAddEdit.CantidadOficinas = Console.ReadLine();
            Console.WriteLine("Cantidad de empleados");
            companyAddEdit.CantidadEmpleados = Console.ReadLine();

            await companySV.AddEditAsync(companyAddEdit);
        }

        public async Task DeleteCompanyAsync()
        {
            var listCompany = await companySV.GetList();
            int i = 0;
            foreach (var company in listCompany)
            {
                Console.WriteLine("{0}- Nombre: {1} Localización: {2} Cantidad de oficinas: {3} Cantidad de empleados: {4}", ++i, company.Nombre, company.Localizacion, company.CantidadOficinas, company.CantidadEmpleados);
            }

            var position = Convert.ToInt32(Console.ReadLine());

            companySV.Delete(listCompany[position - 1].Id);
        }

        public async Task GetListCompanyAsync()
        {
            var listCompany = await companySV.GetList();
            int i = 0;
            foreach (var company in listCompany)
            {
                Console.WriteLine("{0}- Nombre: {1} Localización: {2} Cantidad de oficinas: {3} Cantidad de empleados: {4}", ++i, company.Nombre, company.Localizacion, company.CantidadOficinas, company.CantidadEmpleados);
            }
        }
    }
}
