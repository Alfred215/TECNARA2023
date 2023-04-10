using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.ClientServices
{
    public interface IClientService
    {
        public Task<Client> GetById(Guid id);
        public Task<List<Client>> GetList();
        public Task<List<Person>> GetListPerson();
        public Task AddEditAsync(Client client);
        public Task Delete(Guid id);
    }
}
