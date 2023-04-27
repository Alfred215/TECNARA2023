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
    public class TratamientoService
    {
        AppDbContext db;

        public TratamientoService(AppDbContext _db)
        {
            db = _db;
        }

        #region GET
        public async Task<List<Tratamiento>> GetListAsync()
        {
            return await db.Tratamientos.ToListAsync();
        }

        public async Task<Tratamiento> GetByIdAsync(Guid id)
        {
            return await db.Tratamientos.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        #endregion

        #region ADD_EDIT
        public async Task<Tratamiento> AddEditAsync(Tratamiento data, bool commit = true)
        {
            if (await GetByIdAsync(data.Id) != null)
            {
                return await EditAsync(data, commit);
            }
            return await AddAsync(data, commit);
        }

        public async Task<Tratamiento> AddAsync(Tratamiento newData, bool commit = true)
        {
            await db.AddAsync(newData);
            if (commit) { db.SaveChanges(); }
            return newData;
        }

        public async Task<Tratamiento> EditAsync(Tratamiento newData, bool commit = true)
        {

            var resultOld = await GetByIdAsync(newData.Id);
            resultOld.Duracion = newData.Duracion;
            resultOld.EnfermedadId = newData.EnfermedadId;

            if (commit) { db.SaveChanges(); }

            return resultOld;

        }
        #endregion

        #region DELETE
        public async Task<Tratamiento> DeleteAsync(Guid id)
        {
            var resultOld = await GetByIdAsync(id);

            db.Remove(resultOld);
            db.SaveChanges();
            return resultOld;
        }
        #endregion
    }
}
