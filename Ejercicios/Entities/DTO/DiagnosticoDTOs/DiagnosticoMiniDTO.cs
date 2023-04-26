using Infraestructure.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.DiagnosticoDTOs
{
    public class DiagnosticoMiniDTO
    {
        public Guid Id { get; set; }
        public DateTime Fecha { get; set; }

        public Guid MedicoId { get; set; }
        public TimeSpan MedicoHorasDia { get; set; }

        public Guid PacienteId { get; set; }
        public DateTimeOffset PacienteFecha { get; set; }
        public MotivoPacienteType PacienteMotivo { get; set; }
    }
}
