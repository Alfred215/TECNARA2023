using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.EmployeeServices
{
    public class EmployeeService : IEmployeeService
    {
        public Task<Empleado> AddEditAsync(Empleado employee)
        {
            throw new NotImplementedException();
        }

        public Task<List<Empleado>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Empleado>> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
