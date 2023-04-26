using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.DiagnosticoTratamientoDTOs
{
    public class DiagnosticoTratamientoMiniDTO
    {
        public Guid Id { get; set; }
        public Guid DiagnosticoId { get; set; }
        public DateTime DiagnosticoFecha { get; set; }

        public Guid TratamientoId { get; set; }
        public int TratamientoDuracion { get; set; }
    }
}
