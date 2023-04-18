using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio5_BBDD.Entities;
using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio7_BBDD.Context;
using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio7_BBDD.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio7_BBDD
{
    public class Ejercicio7_Main
    {
        //EmployeeController employeeController;
        //ClientController clientController;
        //PersonController personController;
        //CompanyController companyController;

        public Ejercicio7_Main(dbContextEj7 db)
        {
            //employeeController = new EmployeeController(db);
            //clientController = new ClientController(db);
            //personController = new PersonController(db);
            //companyController = new CompanyController(db);

            var idguid = new Guid("02e2e551-d14b-4940-b602-7a596876a5e8");

            var sumaFacturas = (from cliente in db.Cliente
                                join tc in db.TrabajadorCliente on cliente.Id equals tc.ClienteId
                                join trab in db.Trabajador on tc.TrabajadorId equals trab.Id
                                join sucur in db.Sucursal on trab.SucursalId equals sucur.Id
                                join cb in db.CentroBelleza on sucur.CentroId equals cb.Id
                                //where cb.Id == "ID_DEL_CENTRO_CONCRETO"
                                select cliente.FacturaTotal)
                                .Sum();

            var sumaFacturas2 = db.Cliente
                    .Join(db.TrabajadorCliente,
                          c => c.Id,
                          tc => tc.ClienteId,
                          (c, tc) => new { Cliente = c, TrabajadorCliente = tc })
                    .Join(db.Trabajador,
                          tc => tc.TrabajadorCliente.TrabajadorId,
                          t => t.Id,
                          (tc, t) => new { tc.Cliente, Trabajador = t })
                    .Join(db.Sucursal,
                          t => t.Trabajador.SucursalId,
                          s => s.Id,
                          (t, s) => new { t.Cliente, t.Trabajador, Sucursal = s })
                    .Join(db.CentroBelleza,
                          s => s.Sucursal.CentroId,
                          cb => cb.Id,
                          (s, cb) => new { s.Cliente, s.Trabajador, s.Sucursal, CentroBelleza = cb })
                    //.Where(cb => cb.CentroBelleza.Id == "ID_DEL_CENTRO_CONCRETO")
                    .Sum(cb => cb.Cliente.FacturaTotal);
        }

        public async Task MenuAsync()
        {
            //do
            //{
            //    Console.WriteLine("1-Persona \n2-Empresa \n3-Empleado \n4-Cliente");
            //    var option = int.Parse(Console.ReadLine());

            //    switch (option)
            //    {
            //        #region Persona
            //        case 1:
            //            Console.WriteLine("1-Crear o Editar \n2-Eliminar \n3-Listar");
            //            var optionPerson = int.Parse(Console.ReadLine());

            //            switch (optionPerson)
            //            {
            //                case 1:
            //                    await personController.AddEditPersonAsync();
            //                    break;
            //                case 2:
            //                    await personController.DeletePersonAsync();
            //                    break;
            //                case 3:
            //                    await personController.GetListPersonAsync();
            //                    break;
            //            }
            //            break;
            //        #endregion

            //        #region Empresa
            //        case 2:
            //            Console.WriteLine("1-Crear o Editar \n2-Eliminar \n3-Listar");
            //            var optionCompany = int.Parse(Console.ReadLine());

            //            switch (optionCompany)
            //            {
            //                case 1:
            //                    await companyController.AddEditCompanyAsync();
            //                    break;
            //                case 2:
            //                    await companyController.DeleteCompanyAsync();
            //                    break;
            //                case 3:
            //                    await companyController.GetListCompanyAsync();
            //                    break;
            //            }
            //            break;
            //        #endregion

            //        #region Empleado
            //        case 3:
            //            Console.WriteLine("1-Crear o Editar \n2-Eliminar \n3-Listar");
            //            var optionEmployee = int.Parse(Console.ReadLine());

            //            switch (optionEmployee)
            //            {
            //                case 1:
            //                    await employeeController.AddEditEmployeetAsync();
            //                    break;
            //                case 2:
            //                    await employeeController.DeleteEmployeeAsync();
            //                    break;
            //                case 3:
            //                    await employeeController.GetListEmployeeAsync();
            //                    break;
            //            }
            //            break;
            //        #endregion

            //        #region Cliente
            //        case 4:
            //            Console.WriteLine("1-Crear o Editar \n2-Eliminar \n3-Listar");
            //            var optionClient = int.Parse(Console.ReadLine());

            //            switch (optionClient)
            //            {
            //                case 1:
            //                    await clientController.AddEditClientAsync();
            //                    break;
            //                case 2:
            //                    await clientController.DeleteClientAsync();
            //                    break;
            //                case 3:
            //                    await clientController.GetListClientAsync();
            //                    break;
            //            }
            //            break;
            //            #endregion
            //    }
            //} while (true);
        }
    }
}
