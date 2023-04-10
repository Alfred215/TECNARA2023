using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Controllers;
using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio6_BBDD
{
    public class Ejercicio6_Main
    {
        EmployeeController employeeController;
        ClientController clientController;
        PersonController personController;
        CompanyController companyController;

        public Ejercicio6_Main(dbContextEjerciciosRelaciones6 db)
        {
            employeeController = new EmployeeController(db);
            clientController = new ClientController(db);
            personController = new PersonController(db);
            companyController = new CompanyController(db);
        }

        public async Task MenuAsync()
        {
            do
            {
                Console.WriteLine("1-Persona \n2-Empresa \n3-Empleado \n4-Cliente");
                var option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    #region Persona
                    case 1:
                        Console.WriteLine("1-Crear o Editar \n2-Eliminar \n3-Listar");
                        var optionPerson = int.Parse(Console.ReadLine());

                        switch (optionPerson)
                        {
                            case 1:
                                await personController.AddEditPersonAsync();
                                break;
                            case 2:
                                await personController.DeletePersonAsync();
                                break;
                            case 3:
                                await personController.GetListPersonAsync();
                                break;
                        }
                        break;
                    #endregion

                    #region Empresa
                    case 2:
                        Console.WriteLine("1-Crear o Editar \n2-Eliminar \n3-Listar");
                        var optionCompany = int.Parse(Console.ReadLine());

                        switch (optionCompany)
                        {
                            case 1:
                                await companyController.AddEditCompanyAsync();
                                break;
                            case 2:
                                await companyController.DeleteCompanyAsync();
                                break;
                            case 3:
                                await companyController.GetListCompanyAsync();
                                break;
                        }
                        break;
                    #endregion

                    #region Empleado
                    case 3:
                        Console.WriteLine("1-Crear o Editar \n2-Eliminar \n3-Listar");
                        var optionEmployee = int.Parse(Console.ReadLine());

                        switch (optionEmployee)
                        {
                            case 1:
                                await employeeController.AddEditEmployeetAsync();
                                break;
                            case 2:
                                await employeeController.DeleteEmployeeAsync();
                                break;
                            case 3:
                                await employeeController.GetListEmployeeAsync();
                                break;
                        }
                        break;
                    #endregion

                    #region Cliente
                    case 4:
                        Console.WriteLine("1-Crear o Editar \n2-Eliminar \n3-Listar");
                        var optionClient = int.Parse(Console.ReadLine());

                        switch (optionClient)
                        {
                            case 1:
                                await clientController.AddEditClientAsync();
                                break;
                            case 2:
                                await clientController.DeleteClientAsync();
                                break;
                            case 3:
                                await clientController.GetListClientAsync();
                                break;
                        }
                        break;
                        #endregion
                }
            } while (true);
        }
    }
}
