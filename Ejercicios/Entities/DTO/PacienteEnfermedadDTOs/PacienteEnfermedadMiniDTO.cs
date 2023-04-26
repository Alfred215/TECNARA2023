using Infraestructure.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.PacienteEnfermedadDTOs
{
    public class PacienteEnfermedadMiniDTO
    {
        public Guid Id { get; set; }
        public DateTime Fecha { get; set; }

        public Guid PacienteId { get; set; }
        public DateTimeOffset PacienteFecha { get; set; }
        public MotivoPacienteType PacienteMotivo { get; set; }

        public Guid EnfermedadId { get; set; }
        public string EnfermedadNombre { get; set; }
        public int EnfermedadRiesgo { get; set; }
    }
}
