using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio5_BBDD.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio5_BBDD
{
    public class AlumnoService
    {
        dbContextEjercicio5 db;
        public AlumnoService(dbContextEjercicio5 _db)
        {
            db = _db;
        }

        #region GET
        public async Task<Alumno> GetByIdAsync(Guid id)
        {
            var result = await db.Alumno.Where(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<List<Alumno>> GetListByCentroIdAsync(Guid centroId)
        {
            var result = await db.Alumno.Where(x => x.CentroId == centroId).ToListAsync();
            return result;
        }

        public async Task<List<Alumno>> GetListAsync()
        {
            return await db.Alumno.ToListAsync();
        }
        #endregion

        #region SET
        public async Task AddAsync(Alumno centro)
        {
            centro.Id = Guid.Empty;
            await db.AddAsync(centro);

            db.SaveChanges();
        }

        public async Task EditAsync(Alumno alumno)
        {
            var alumnoOld = await GetByIdAsync(alumno.Id);

            alumnoOld.Nombre = alumno.Nombre;
            alumnoOld.FechaNacimiento = alumno.FechaNacimiento;
            alumnoOld.CentroId = alumno.CentroId;

            db.SaveChanges();
        }

        public async Task AddEditAsync(Alumno alumno)
        {
            if (await GetByIdAsync(alumno.Id) != null)
            {
                await EditAsync(alumno);
            }
            else
            {
                await AddAsync(alumno);
            }
        }
        #endregion

        #region DELETE
        public async Task DeletePersonaAsync(Guid id)
        {
            var alumnoOld = await GetByIdAsync(id);

            db.Remove(alumnoOld);
            db.SaveChanges();
        }
        #endregion
    }
}
