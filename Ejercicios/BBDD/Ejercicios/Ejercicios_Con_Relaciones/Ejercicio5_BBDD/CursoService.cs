using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio5_BBDD.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio5_BBDD
{
    public class CursoService
    {
        dbContextEjercicio5 db;
        public CursoService(dbContextEjercicio5 _db)
        {
            db = _db;
        }

        #region GET
        public async Task<Curso> GetByIdAsync(Guid id)
        {
            var result = await db.Curso.Where(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<List<Curso>> GetListCursoMaxHorasAsync()
        {
            var horasMax = db.Curso.Select(x => x.HorasTotales).ToList().Max();
            var result = await db.Curso.Where(x => x.HorasTotales == horasMax).ToListAsync();
            return result;
        }

        public async Task<List<Curso>> GetListByCentroIdAsync(Guid centroId)
        {
            var result = await db.Curso.Where(x => x.CentroId == centroId).ToListAsync();
            return result;
        }

        public async Task<List<Curso>> GetListAsync()
        {
            return await db.Curso.ToListAsync();
        }
        #endregion

        #region SET
        public async Task AddAsync(Curso curso)
        {
            curso.Id = Guid.Empty;
            await db.AddAsync(curso);
            db.SaveChanges();
        }

        public async Task EditAsync(Curso curso)
        {
            var cursorOld = await GetByIdAsync(curso.Id);

            cursorOld.Nombre = curso.Nombre;
            cursorOld.HorasTotales = curso.HorasTotales;
            cursorOld.CentroId = curso.CentroId;

            db.SaveChanges();
        }

        public async Task AddEditAsync(Curso curso)
        {
            if (await GetByIdAsync(curso.Id) != null)
            {
                await EditAsync(curso);
            }
            else
            {
                await AddAsync(curso);
            }
        }
        #endregion

        #region DELETE
        public async Task DeletePersonaAsync(Guid id)
        {
            var cursorOld = await GetByIdAsync(id);

            db.Remove(cursorOld);
            db.SaveChanges();
        }
        #endregion
    }
}
