using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.ClientServices
{
    public class ClientService : IClientService
    {
        dbContextEjerciciosRelaciones6 db;
        public ClientService(dbContextEjerciciosRelaciones6 _db)
        {
            db = _db;
        }

        #region ADDEDIT
        public async Task AddEditAsync(Client cliente)
        {
            if (GetById(cliente.Id) != null)
            {
                await Edit(cliente);
            }
            else
            {
                await AddAsync(cliente);
            }
        }

        public async Task AddAsync(Client cliente)
        {
            await db.AddAsync(cliente);
            db.SaveChanges();
        }

        public async Task Edit(Client cliente)
        {
            var clienteOld = await GetById(cliente.Id);
            clienteOld.PersonId = cliente.PersonId;
            clienteOld.Saldo = cliente.Saldo;
            clienteOld.HoraServicio = cliente.HoraServicio;

            db.SaveChanges();
        }
        #endregion

        #region DELETE
        public async Task Delete(Guid id)
        {
            var empresaOld = await GetById(id);
            db.Remove(empresaOld);
            db.SaveChanges();
        }
        #endregion

        #region GET
        public async Task<Client> GetById(Guid id)
        {
            return await db.Client.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Client>> GetList()
        {
            return await db.Client.ToListAsync();
        }

        public async Task<List<Person>> GetListPerson()
        {
            return await db.Client.Select(x => x.Person).ToListAsync();
        }
        #endregion
    }
}
