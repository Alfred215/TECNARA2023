using Infraestructure.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.PacienteDTOs
{
    public class PacienteMiniDTO 
    {
        public Guid Id { get; set; }
        public DateTimeOffset Fecha { get; set; }
        public MotivoPacienteType Motivo { get; set; }

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
