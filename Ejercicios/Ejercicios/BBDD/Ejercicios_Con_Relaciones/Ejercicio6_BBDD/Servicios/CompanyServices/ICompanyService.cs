using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.CompanyServices
{
    public interface ICompanyService
    {
        public Task<Empresa> GetById(Guid id);
        public Task<List<Empresa>> GetList();
        public Task<Empresa> AddEditAsync(Empresa company);
        public Task<List<Empresa>> Delete(Guid id);
    }
}
