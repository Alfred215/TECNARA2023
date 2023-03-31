using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.CompanyServices
{
    public class CompanyService : ICompanyService
    {
        public Task<Empresa> AddEditAsync(Empresa company)
        {
            throw new NotImplementedException();
        }

        public Task<List<Empresa>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Empresa> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Empresa>> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
