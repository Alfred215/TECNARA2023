using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio5_BBDD.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio5_BBDD
{
    public class ProfesorService
    {
        dbContextEjercicio5 db;
        public ProfesorService(dbContextEjercicio5 _db)
        {
            db = _db;
        }

        #region GET
        public async Task<Profesor> GetByIdAsync(Guid id)
        {
            var result = await db.Profesor.Where(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<List<Profesor>> GetListByCentroIdAsync(Guid centroId)
        {
            var result = await db.Profesor.Where(x => x.CentroId == centroId).ToListAsync();
            return result;
        }

        public async Task<List<Profesor>> GetListAsync()
        {
            return await db.Profesor.ToListAsync();
        }
        #endregion

        #region SET
        public async Task AddAsync(Profesor profesor)
        {
            profesor.Id = Guid.Empty;
            await db.AddAsync(profesor);
            db.SaveChanges();
        }

        public async Task EditAsync(Profesor profesor)
        {
            var profesorOld = await GetByIdAsync(profesor.Id);

            profesorOld.Nombre = profesor.Nombre;
            profesorOld.Telefono = profesor.Telefono;
            profesorOld.CentroId = profesor.CentroId;

            db.SaveChanges();
        }

        public async Task AddEditAsync(Profesor profesor)
        {
            if (await GetByIdAsync(profesor.Id) != null)
            {
                await EditAsync(profesor);
            }
            else
            {
                await AddAsync(profesor);
            }
        }
        #endregion

        #region DELETE
        public async Task DeletePersonaAsync(Guid id)
        {
            var profesorOld = await GetByIdAsync(id);

            db.Remove(profesorOld);
            db.SaveChanges();
        }
        #endregion
    }
}
