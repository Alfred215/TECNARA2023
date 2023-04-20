using Data;
using Infraestructure.DTO.PacienteDTOs;
using Infraestructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PacienteService
    {
        private AppDbContext db;
        public PacienteService(AppDbContext _db)
        {
            db = _db;
        }

        #region GET
        public async Task<List<Paciente>> GetListAsync()
        {
            return await db.Pacientes.ToListAsync();
        }

        public async Task<Paciente> GetByIdAsync(Guid id)
        {
            return await db.Pacientes.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<PacienteMiniDTO> GetPacienteByMedicoIdAsync(Guid medicoId)
        {
            var query = (from medico in db.Medicos
                            where medico.Id == medicoId
                         from hospital in db.Hospitales
                            where hospital.Id == medico.HospitalId
                         from paciente in db.Pacientes
                            where paciente.HospitalId == medico.HospitalId
                         from persona in db.Personas
                            where persona.Id == paciente.PersonaId
                         select new PacienteMiniDTO
                            {
                                Id = paciente.Id,
                                Fecha = paciente.Fecha,
                                Motivo = paciente.Motivo,
                                PersonaNombre = persona.Name,
                                PersonaPApellido = persona.Surname1,
                                PersonaSApellido = persona.Surname2,
                                PersonaEdad = persona.Age,
                                PersonaEstado = persona.Estado,
                                HospitalNombre = hospital.Nombre,
                                HospitalLocalizacion = hospital.Localizacion,
                                HospitalEspecialidades = hospital.Especialidad
                            }).ToList();

            Random rm = new Random();

            return query[rm.Next(query.Count() - 1)];
        }
        #endregion

        #region ADD_EDIT
        public async Task<Paciente> AddEditAsync(Paciente data, bool commit = true)
        {
            if (await GetByIdAsync(data.Id) != null)
            {
                return await EditAsync(data, commit);
            }
            return await AddAsync(data, commit);
        }

        public async Task<Paciente> AddAsync(Paciente newData, bool commit = true)
        {
            await db.AddAsync(newData);
            if (commit) { db.SaveChanges(); }
            return newData;
        }

        public async Task<Paciente> EditAsync(Paciente newData, bool commit = true)
        {

            var resultOld = await GetByIdAsync(newData.Id);
            resultOld.Fecha = newData.Fecha;
            resultOld.Motivo = newData.Motivo;
            resultOld.PersonaId = newData.PersonaId;
            resultOld.HospitalId = newData.HospitalId;

            if (commit) { db.SaveChanges(); }

            return resultOld;

        }
        #endregion

        #region DELETE
        public async Task<Paciente> DeleteAsync(Guid id)
        {
            var resultOld = await GetByIdAsync(id);

            db.Remove(resultOld);
            db.SaveChanges();
            return resultOld;
        }
        #endregion
    }
}
