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
    public class MedicoService
    {
        private AppDbContext db;
        public MedicoService(AppDbContext _db)
        {
            db = _db;
        }

        #region GET
        public async Task<List<Medico>> GetListAsync()
        {
            return await db.Medicos.ToListAsync();
        }

        public async Task<Medico> GetByIdAsync(Guid id)
        {
            return await db.Medicos.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        #endregion

        #region ADD_EDIT
        public async Task<Medico> AddEditAsync(Medico data, bool commit = true)
        {
            if (await GetByIdAsync(data.Id) != null)
            {
                return await EditAsync(data, commit);
            }
            return await AddAsync(data, commit);
        }

        public async Task<Medico> AddAsync(Medico newData, bool commit = true)
        {
            await db.AddAsync(newData);
            if (commit) { db.SaveChanges(); }
            return newData;
        }

        public async Task<Medico> EditAsync(Medico newData, bool commit = true)
        {

            var resultOld = await GetByIdAsync(newData.Id);
            resultOld.Area = newData.Area;
            resultOld.Funcion = newData.Funcion;
            resultOld.HorasDia = newData.HorasDia;
            resultOld.PersonaId = newData.PersonaId;
            resultOld.HospitalId = newData.HospitalId;

            if (commit) { db.SaveChanges(); }

            return resultOld;

        }
        #endregion

        #region DELETE
        public async Task<Medico> DeleteAsync(Guid id)
        {
            var resultOld = await GetByIdAsync(id);

            db.Remove(resultOld);
            db.SaveChanges();
            return resultOld;
        }
        #endregion
    }
}
