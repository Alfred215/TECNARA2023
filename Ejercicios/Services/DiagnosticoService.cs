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
    public class DiagnosticoService
    {
        AppDbContext db;

        public DiagnosticoService(AppDbContext _db)
        {
            db = _db;
        }

        #region GET
        public async Task<List<Diagnostico>> GetListAsync()
        {
            return await db.Diagnosticos.ToListAsync();
        }

        public async Task<Diagnostico> GetByIdAsync(Guid id)
        {
            return await db.Diagnosticos.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        #endregion

        #region ADD_EDIT
        public async Task<Diagnostico> AddEditAsync(Diagnostico data, bool commit = true)
        {
            if (await GetByIdAsync(data.Id) != null)
            {
                return await EditAsync(data, commit);
            }
            return await AddAsync(data, commit);
        }

        public async Task<Diagnostico> AddAsync(Diagnostico newData, bool commit = true)
        {
            await db.AddAsync(newData);
            if (commit) { db.SaveChanges(); }
            return newData;
        }

        public async Task<Diagnostico> EditAsync(Diagnostico newData, bool commit = true)
        {

            var resultOld = await GetByIdAsync(newData.Id);
            resultOld.Fecha = newData.Fecha;
            resultOld.MedicoId = newData.MedicoId;
            resultOld.PacienteId = newData.PacienteId;

            if (commit) { db.SaveChanges(); }

            return resultOld;

        }
        #endregion

        #region DELETE
        public async Task<Diagnostico> DeleteAsync(Guid id)
        {
            var resultOld = await GetByIdAsync(id);

            db.Remove(resultOld);
            db.SaveChanges();
            return resultOld;
        }
        #endregion
    }
}
