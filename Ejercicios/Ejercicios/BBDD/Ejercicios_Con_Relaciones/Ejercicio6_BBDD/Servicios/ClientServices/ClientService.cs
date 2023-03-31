using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.ClientServices
{
    public class ClientService : IClientService
    {
        #region SET
        public Task<Client> AddEditAsync(Client client)
        {
            throw new NotImplementedException();
        }

        public Task<Client> AddAsync(Client client)
        {
            throw new NotImplementedException();
        }

        public Task<Client> EditAsync(Client client)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region DELETE
        public Task<List<Client>> Delete(Guid id)
        {
            throw new NotImplementedException();
        } 
        #endregion

        #region GET
        public Task<Client> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Client>> GetList()
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
