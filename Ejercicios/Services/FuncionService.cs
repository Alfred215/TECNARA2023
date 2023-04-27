using Data;
using Infraestructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FuncionService
    {
        AppDbContext db;

        public FuncionService(AppDbContext _db) 
        {
            db = _db;
        }

        #region GET
        public async Task<List<Funcion>> GetListAsync()
        {
            return await db.Funciones.ToListAsync();
        }

        public async Task<Funcion> GetByIdAsync(Guid id)
        {
            return await db.Funciones.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        #endregion

        #region ADD_EDIT
        public async Task<Funcion> AddEditAsync(Funcion data, bool commit = true)
        {
            if (await GetByIdAsync(data.Id) != null)
            {
                return await EditAsync(data, commit);
            }
            return await AddAsync(data, commit);
        }

        public async Task<Funcion> AddAsync(Funcion newData, bool commit = true)
        {
            await db.AddAsync(newData);
            if (commit) { db.SaveChanges(); }
            return newData;
        }

        public async Task<Funcion> EditAsync(Funcion newData, bool commit = true)
        {

            var resultOld = await GetByIdAsync(newData.Id);
            resultOld.Nombre = newData.Nombre;
            resultOld.AreaId = newData.AreaId;

            if (commit) { db.SaveChanges(); }

            return resultOld;

        }
        #endregion

        #region DELETE
        public async Task<Funcion> DeleteAsync(Guid id)
        {
            var resultOld = await GetByIdAsync(id);

            db.Remove(resultOld);
            db.SaveChanges();
            return resultOld;
        }
        #endregion
    }
}
