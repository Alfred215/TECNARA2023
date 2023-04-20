using Infraestructure.Entities;
using Infraestructure.Enumerables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.PacienteDTOs
{
    public class PacientePostDTO
    {
        public Guid Id { get; set; }
        public DateTimeOffset Fecha { get; set; }
        public MotivoPacienteType Motivo { get; set; }
        public Guid PersonaId { get; set; }
        public Guid HospitalId { get; set; }

        public virtual Person Persona { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
