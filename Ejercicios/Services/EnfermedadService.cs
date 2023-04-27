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
    public class EnfermedadService
    {
        AppDbContext db;

        public EnfermedadService(AppDbContext _db)
        {
            db = _db;
        }

        #region GET
        public async Task<List<Enfermedad>> GetListAsync()
        {
            return await db.Enfermedades.ToListAsync();
        }

        public async Task<Enfermedad> GetByIdAsync(Guid id)
        {
            return await db.Enfermedades.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        #endregion

        #region ADD_EDIT
        public async Task<Enfermedad> AddEditAsync(Enfermedad data, bool commit = true)
        {
            if (await GetByIdAsync(data.Id) != null)
            {
                return await EditAsync(data, commit);
            }
            return await AddAsync(data, commit);
        }

        public async Task<Enfermedad> AddAsync(Enfermedad newData, bool commit = true)
        {
            await db.AddAsync(newData);
            if (commit) { db.SaveChanges(); }
            return newData;
        }

        public async Task<Enfermedad> EditAsync(Enfermedad newData, bool commit = true)
        {

            var resultOld = await GetByIdAsync(newData.Id);
            resultOld.Nombre = newData.Nombre;
            resultOld.Riesgo = newData.Riesgo;
            resultOld.AreaId = newData.AreaId;

            if (commit) { db.SaveChanges(); }

            return resultOld;

        }
        #endregion

        #region DELETE
        public async Task<Enfermedad> DeleteAsync(Guid id)
        {
            var resultOld = await GetByIdAsync(id);

            db.Remove(resultOld);
            db.SaveChanges();
            return resultOld;
        }
        #endregion
    }
}
