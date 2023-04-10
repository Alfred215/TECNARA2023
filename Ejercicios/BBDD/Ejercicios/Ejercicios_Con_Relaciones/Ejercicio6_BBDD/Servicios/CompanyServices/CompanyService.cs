using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.CompanyServices
{
    public class CompanyService : ICompanyService
    {
        dbContextEjerciciosRelaciones6 db;
        public CompanyService(dbContextEjerciciosRelaciones6 _db)
        {
            db = _db;
        }

        #region ADDEDIT
        public async Task AddEditAsync(Empresa empresa)
        {
            if (GetById(empresa.Id) != null)
            {
                await Edit(empresa);
            }
            else
            {
                await AddAsync(empresa);
            }
        }

        public async Task AddAsync(Empresa empresa)
        {
            await db.AddAsync(empresa);
            db.SaveChanges();
        }

        public async Task Edit(Empresa empresa)
        {
            var empresaOld = await GetById(empresa.Id);
            empresaOld.Nombre = empresa.Nombre;
            empresaOld.Localizacion = empresa.Localizacion;
            empresaOld.CantidadOficinas = empresa.CantidadOficinas;
            empresaOld.CantidadEmpleados = empresa.CantidadEmpleados;

            db.SaveChanges();
        }
        #endregion

        #region DELETE
        public async Task Delete(Guid id)
        {
            var empresaOld = await GetById(id);
            db.Remove(empresaOld);
            db.SaveChanges();

        }
        #endregion

        #region GET
        public async Task<Empresa> GetById(Guid id)
        {
            return await db.Empresa.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Empresa>> GetList()
        {
            return await db.Empresa.ToListAsync();
        }
        #endregion
    }
}
