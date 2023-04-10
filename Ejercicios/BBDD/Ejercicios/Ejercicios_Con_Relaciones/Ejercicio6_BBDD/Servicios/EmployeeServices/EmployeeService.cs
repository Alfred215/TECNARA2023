using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.EmployeeServices
{
    public class EmployeeService : IEmployeeService
    {
        dbContextEjerciciosRelaciones6 db;
        public EmployeeService(dbContextEjerciciosRelaciones6 _db)
        {
            db = _db;
        }

        #region ADDEDIT
        public async Task AddEditAsync(Empleado empleado)
        {
            if (GetById(empleado.Id) != null)
            {
                await Edit(empleado);
            }
            else
            {
                await AddAsync(empleado);
            }
        }

        public async Task AddAsync(Empleado empleado)
        {
            await db.AddAsync(empleado);
            db.SaveChanges();
        }

        public async Task Edit(Empleado empleado)
        {
            var empleadoOld = await GetById(empleado.Id);
            empleadoOld.PersonId = empleado.PersonId;
            empleadoOld.EmpresaId = empleado.EmpresaId;
            empleadoOld.HoraEntrada = empleado.HoraEntrada;
            empleadoOld.HoraSalida = empleado.HoraSalida;
            empleadoOld.PrecioPorHora = empleado.PrecioPorHora;

            db.SaveChanges();
        }
        #endregion

        #region DELETE
        public async Task Delete(Guid id)
        {
            var empleadoOld = await GetById(id);
            db.Remove(empleadoOld);
            db.SaveChanges();

        }
        #endregion

        #region GET
        public async Task<Empleado> GetById(Guid id)
        {
            return await db.Empleado.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Empleado>> GetList()
        {
            return await db.Empleado.ToListAsync();
        }

        public async Task<List<Person>> GetListPersonAsync()
        {
            return await db.Client.Select(x => x.Person).ToListAsync();
        }

        public async Task<List<Empresa>> GetListCompanyAsync()
        {
            return await db.Empleado.Select(x => x.Empresa).ToListAsync();
        }
        #endregion
    }
}
