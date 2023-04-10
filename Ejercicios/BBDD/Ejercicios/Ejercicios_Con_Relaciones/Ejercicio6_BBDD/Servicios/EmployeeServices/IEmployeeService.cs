using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.EmployeeServices
{
    public interface IEmployeeService
    {
        public Task<Empleado> GetById(Guid id);
        public Task<List<Empleado>> GetList();
        public Task<List<Person>> GetListPersonAsync();
        public Task<List<Empresa>> GetListCompanyAsync();
        public Task AddEditAsync(Empleado employee);
        public Task Delete(Guid id);
    }
}
