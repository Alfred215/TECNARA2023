using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio5_BBDD.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio5_BBDD
{
    public class CentroService
    {
        dbContextEjercicio5 db;
        public CentroService(dbContextEjercicio5 _db) 
        {
            db = _db;
        }

        #region GET
        public async Task<Centro> GetByIdAsync(Guid? id)
        {
            var result = await db.Centro.Where(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<Centro> GetListMaxAlumnosCenterAsync()
        {
            var listCentro = db.Alumno.GroupBy(x => x.CentroId).ToList();
            var centroId = listCentro.Where(x => x.Count() == listCentro.Max(y => y.Count())).FirstOrDefault().Key;
            var result = await GetByIdAsync(centroId);
            return result;
        }

        public async Task<Centro> GetListMaxProfesorCenterAsync()
        {
            var listCentro = db.Profesor.GroupBy(x => x.CentroId).ToList();
            var centroId = listCentro.Where(x => x.Count() == listCentro.Max(y => y.Count())).FirstOrDefault().Key;
            var result = await GetByIdAsync(centroId);
            return result;
        }

        public async Task<int?> GetHorasTotalCursosByCentroIdAsync(Guid centroId)
        {
            var horasTotales = db.Curso.Where(x => x.CentroId == centroId).Select(x => x.HorasTotales).ToList().Sum();
            return horasTotales;
        }

        public async Task<List<Centro>> GetListAsync()
        {
            var listCentro = await db.Centro.ToListAsync();
            int i = 0;
            foreach (var centro in listCentro)
            {
                Console.WriteLine("{0}- Nombre: {1} CP: {2}", ++i, centro.Nombre, centro.Cp);
            }
            return listCentro;
        }
        #endregion

        #region SET
        public async Task AddAsync(Centro centro)
        {
            centro.Id = Guid.Empty;
            await db.AddAsync(centro);

            db.SaveChanges();
        }

        public async Task EditAsync(Centro centro)
        {
            var centroOld = await GetByIdAsync(centro.Id);

            centroOld.Nombre = centro.Nombre;
            centroOld.Cp = centro.Cp;

            db.SaveChanges();
        }

        public async Task AddEditAsync(Centro centro)
        {
            if (await GetByIdAsync(centro.Id) != null)
            {
                await EditAsync(centro);
            }
            else
            {
                await AddAsync(centro);
            }
        }
        #endregion

        #region DELETE
        public async Task DeletePersonaAsync(Guid id)
        {
            var centroOld = await GetByIdAsync(id);

            db.Remove(centroOld);
            db.SaveChanges();
        }
        #endregion
    }
}
