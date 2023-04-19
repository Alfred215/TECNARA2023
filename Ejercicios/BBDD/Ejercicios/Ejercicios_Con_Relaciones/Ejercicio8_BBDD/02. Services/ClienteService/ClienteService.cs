using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._02._Services.ClienteService
{
    public class ClienteService : IClienteService
    {
        dbContextEj8 db;

        public ClienteService(dbContextEj8 _db) 
        {
            db = _db;
        }

        public async Task AgregarCliente(Cliente cliente)
        {
            await db.AddAsync(cliente);
        }

        public async Task<List<Reserva>> TotalReservasCliente(Guid clienteId)
        {
            var query = from r in db.Reserva
                        where r.IdCliente == clienteId
                        select r;

            return await query.ToListAsync();
        }
    }
}
