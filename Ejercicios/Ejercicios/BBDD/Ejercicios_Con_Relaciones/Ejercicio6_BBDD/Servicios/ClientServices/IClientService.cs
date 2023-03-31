using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;
using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Entidades;
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
        public Task<Client> AddEditAsync(Client client);
        public Task<List<Client>> Delete(Guid id);
    }
}
