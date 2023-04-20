using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure.Enumerables;

namespace Infraestructure.DTO.MedicoDTOs
{
    public class MedicoMiniDTO
    {
        public Guid Id { get; set; }
        public string Area { get; set; }
        public string Funcion { get; set; }
        public TimeSpan HorasDia { get; set; }

        #region Persona
        public Guid PersonaId { get; set; }
        public string PersonaNombre { get; set; }
        public string PersonaPApellido { get; set; }
        public string PersonaSApellido { get; set; }
        public int PersonaEdad { get; set; }
        public EstadoPersonaType PersonaEstado { get; set; }
        #endregion

        #region Hospital
        public Guid HospitalId { get; set; }
        public string HospitalNombre { get; set; }
        public LocalizacionType HospitalLocalizacion { get; set; }
        public string HospitalEspecialidades { get; set; } 
        #endregion
    }
}
