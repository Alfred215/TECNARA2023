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
    public class AreaService
    {
        AppDbContext db;

        public AreaService(AppDbContext _db)
        {
            db = _db;
        }

        #region GET
        public async Task<List<Area>> GetListAsync()
        {
            return await db.Areas.ToListAsync();
        }

        public async Task<Area> GetByIdAsync(Guid id)
        {
            return await db.Areas.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        #endregion

        #region ADD_EDIT
        public async Task<Area> AddEditAsync(Area data, bool commit = true)
        {
            if (await GetByIdAsync(data.Id) != null)
            {
                return await EditAsync(data, commit);
            }
            return await AddAsync(data, commit);
        }

        public async Task<Area> AddAsync(Area newData, bool commit = true)
        {
            await db.AddAsync(newData);
            if (commit) { db.SaveChanges(); }
            return newData;
        }

        public async Task<Area> EditAsync(Area newData, bool commit = true)
        {

            var resultOld = await GetByIdAsync(newData.Id);
            resultOld.Nombre = newData.Nombre;
            resultOld.Tamaño = newData.Tamaño;
            resultOld.HospitalId = newData.HospitalId;

            if (commit) { db.SaveChanges(); }

            return resultOld;

        }
        #endregion

        #region DELETE
        public async Task<Area> DeleteAsync(Guid id)
        {
            var resultOld = await GetByIdAsync(id);

            db.Remove(resultOld);
            db.SaveChanges();
            return resultOld;
        }
        #endregion
    }
}
