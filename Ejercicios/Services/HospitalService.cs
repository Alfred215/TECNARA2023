using Data;
using Infraestructure.DTO.HospitalDTOs;
using Infraestructure.Entities;
using Infraestructure.Enumerables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HospitalService
    {
        private AppDbContext db;
        public HospitalService(AppDbContext _db)
        {
            db = _db;
        }

        #region GET
        public async Task<List<Hospital>> GetListAsync()
        {
            return await db.Hospitales.ToListAsync();
        }

        public async Task<Hospital> GetByIdAsync(Guid id)
        {
            return await db.Hospitales.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<HospitalMiniDTO>> GetListHospitalesActualAsync()
        {
            var query = from hospital in db.Hospitales
                        select new HospitalMiniDTO
                        {
                            Id = hospital.Id,
                            Nombre = hospital.Nombre,
                            Localizacion = hospital.Localizacion,
                            Especialidad = hospital.Especialidad,
                            Capacidad = hospital.Capacidad,
                            CapacidadActual = db.Medicos.Where(x => x.HospitalId == hospital.Id).Count(),
                            Trabajadores = hospital.Trabajadores,
                            TrabajadoresActual = db.Pacientes.Where(x => x.HospitalId == hospital.Id).Count()
                        };

            return await query.ToListAsync();
        }

        public async Task<List<HospitalMiniDTO>> GetListHospitalesByMotivoPaciente(MotivoPacienteType motivo)
        {
            var query = from paciente in db.Pacientes
                            where paciente.Motivo == motivo
                        from hospital in db.Hospitales
                            where paciente.HospitalId == hospital.Id
                        select new HospitalMiniDTO
                        {
                            Id = hospital.Id,
                            Nombre = hospital.Nombre,
                            Localizacion = hospital.Localizacion,
                            Especialidad = hospital.Especialidad,
                            Capacidad = hospital.Capacidad,
                            Trabajadores = hospital.Trabajadores,
                        };

            return await query.ToListAsync();
        }
        #endregion

        #region ADD_EDIT
        public async Task<Hospital> AddEditAsync(Hospital data, bool commit = true)
        {
            if (await GetByIdAsync(data.Id) != null)
            {
                return await EditAsync(data, commit);
            }
            return await AddAsync(data, commit);
        }

        public async Task<Hospital> AddAsync(Hospital newData, bool commit = true)
        {
            await db.AddAsync(newData);
            if (commit) { db.SaveChanges(); }
            return newData;
        }

        public async Task<Hospital> EditAsync(Hospital newData, bool commit = true)
        {

            var resultOld = await GetByIdAsync(newData.Id);
            resultOld.Nombre = newData.Nombre;
            resultOld.Localizacion = newData.Localizacion;
            resultOld.Especialidad = newData.Especialidad;
            resultOld.Capacidad = newData.Capacidad;
            resultOld.Trabajadores = newData.Trabajadores;

            if (commit) { db.SaveChanges(); }

            return resultOld;

        }
        #endregion

        #region DELETE
        public async Task<Hospital> DeleteAsync(Guid id)
        {
            var resultOld = await GetByIdAsync(id);

            db.Remove(resultOld);
            db.SaveChanges();
            return resultOld;
        }
        #endregion
    }
}
