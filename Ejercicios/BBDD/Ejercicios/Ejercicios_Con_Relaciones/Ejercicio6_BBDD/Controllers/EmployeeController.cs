using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.CompanyServices;
using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.EmployeeServices;
using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Controllers
{
    public class EmployeeController
    {
        private EmployeeService employeeSV;
        public EmployeeController(dbContextEjerciciosRelaciones6 _db)
        {
            employeeSV = new EmployeeService(_db);
        }
        public async Task AddEditEmployeetAsync()
        {
            var listEmployee = await employeeSV.GetList();
            int i = 0;
            foreach (var employee in listEmployee)
            {
                Console.WriteLine("{0}- Nombre: {1} Nombre empresa: {2} Horas de entrada: {3} Hora de salida: {4} Precio por hora: {5}", ++i, employee.Person.Name, employee.Empresa.Nombre, employee.HoraEntrada, employee.HoraSalida, employee.PrecioPorHora);
            }

            Console.WriteLine("Elija una posición o escriba 0 para crear un nuevo registro");
            var position = Convert.ToInt32(Console.ReadLine());

            Empleado employeeAddEdit = new Empleado();
            employeeAddEdit.Id = position == 0 ? new Guid() : listEmployee[position - 1].Id;

            #region Lista de Personas
            var listPerson = await employeeSV.GetListPersonAsync();

            foreach (var person in listPerson)
            {
                Console.WriteLine("{0}- Nombre: {1} P. Apellido: {2} S. Apellido: {3} Edad: {4}", ++i, person.Name, person.Surname1, person.Surname2, person.Age);
            }

            Console.WriteLine("Elija una posición: ");
            var positionPerson = Convert.ToInt32(Console.ReadLine());
            employeeAddEdit.PersonId = listPerson[positionPerson - 1].Id;
            #endregion

            #region Lista de Empresas
            var listCompany = await employeeSV.GetListCompanyAsync();

            foreach (var compnay in listCompany)
            {
                Console.WriteLine("{0}- Nombre: {1} Localización: {2} Cantidad de oficinas: {3} Cantidad de empleados: {4}", ++i, compnay.Nombre, compnay.Localizacion, compnay.CantidadOficinas, compnay.CantidadEmpleados);
            }

            Console.WriteLine("Elija una posición: ");
            var positionEmpresa = Convert.ToInt32(Console.ReadLine());
            employeeAddEdit.EmpresaId = listPerson[positionEmpresa - 1].Id;
            #endregion

            Console.WriteLine("Hora de entrada (hh:mm:ss)");
            var horaEntrada = Console.ReadLine().Split(":");
            employeeAddEdit.HoraEntrada = new TimeSpan(int.Parse(horaEntrada[0]), int.Parse(horaEntrada[1]), int.Parse(horaEntrada[2]));

            Console.WriteLine("Horas de salida");
            var horaSalida = Console.ReadLine().Split(":");
            employeeAddEdit.HoraSalida = new TimeSpan(int.Parse(horaSalida[0]), int.Parse(horaSalida[1]), int.Parse(horaSalida[2]));

            Console.WriteLine("Precio por la hora");
            employeeAddEdit.PrecioPorHora = Convert.ToInt32(Console.ReadLine());

            await employeeSV.AddEditAsync(employeeAddEdit);
        }

        public async Task DeleteEmployeeAsync()
        {
            var listEmployee = await employeeSV.GetList();
            int i = 0;
            foreach (var employee in listEmployee)
            {
                Console.WriteLine("{0}- Nombre: {1} Nombre empresa: {2} Horas de entrada: {3} Hora de salida: {4} Precio por hora: {5}", ++i, employee.Person.Name, employee.Empresa.Nombre, employee.HoraEntrada, employee.HoraSalida, employee.PrecioPorHora);
            }

            var position = Convert.ToInt32(Console.ReadLine());

            await employeeSV.Delete(listEmployee[position - 1].Id);
        }

        public async Task GetListEmployeeAsync()
        {
            var listEmployee = await employeeSV.GetList();
            int i = 0;
            foreach (var employee in listEmployee)
            {
                Console.WriteLine("{0}- Nombre: {1} Nombre empresa: {2} Horas de entrada: {3} Hora de salida: {4} Precio por hora: {5}", ++i, employee.Person.Name, employee.Empresa.Nombre, employee.HoraEntrada, employee.HoraSalida, employee.PrecioPorHora);
            }
        }

    }
}
