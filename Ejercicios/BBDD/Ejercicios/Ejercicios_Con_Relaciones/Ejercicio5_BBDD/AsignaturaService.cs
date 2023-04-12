using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio5_BBDD.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio5_BBDD
{
    public class AsignaturaService
    {
        dbContextEjercicio5 db;
        public AsignaturaService(dbContextEjercicio5 _db)
        {
            db = _db;
        }

        #region GET
        public async Task<Asignatura> GetByIdAsync(Guid id)
        {
            var result = await db.Asignatura.Where(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<List<Asignatura>> GetByCursoIdAsync(Guid cursoId)
        {
            var result = await db.Asignatura.Where(x => x.CursoId == cursoId).ToListAsync();
            return result;
        }

        public async Task<List<Asignatura>> GetListAsync()
        {
            return await db.Asignatura.ToListAsync();
        }
        #endregion

        #region SET
        public async Task AddAsync(Asignatura asignatura)
        {
            asignatura.Id = Guid.Empty;
            await db.AddAsync(asignatura);
            db.SaveChanges();
        }

        public async Task EditAsync(Asignatura asignatura)
        {
            var asignaturaOld = await GetByIdAsync(asignatura.Id);

            asignaturaOld.Nombre = asignatura.Nombre;
            asignaturaOld.CursoId = asignatura.CursoId;
            asignaturaOld.ProfesorId = asignatura.ProfesorId;

            db.SaveChanges();
        }

        public async Task AddEditAsync(Asignatura asignatura)
        {
            if (await GetByIdAsync(asignatura.Id) != null)
            {
                await EditAsync(asignatura);
            }
            else
            {
                await AddAsync(asignatura);
            }
        }
        #endregion

        #region DELETE
        public async Task DeletePersonaAsync(Guid id)
        {
            var asignaturaOld = await GetByIdAsync(id);

            db.Remove(asignaturaOld);
            db.SaveChanges();
        }
        #endregion
    }
}
