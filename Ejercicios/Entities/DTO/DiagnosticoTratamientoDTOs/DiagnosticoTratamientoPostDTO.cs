using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.DiagnosticoTratamientoDTOs
{
    public class DiagnosticoTratamientoPostDTO
    {
        public Guid Id { get; set; }
        public Guid DiagnosticoId { get; set; }
        public Guid TratamientoId { get; set; }
    }
}
