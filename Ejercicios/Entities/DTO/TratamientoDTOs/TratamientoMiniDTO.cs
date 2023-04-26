using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.TratamientoDTOs
{
    public class TratamientoMiniDTO
    {
        public Guid Id { get; set; }
        public int Duracion { get; set; }
        public Guid EnfermedadId { get; set; }
        public string EnfermedadNombre { get; set; }
        public int EnfermedadRiesgo { get; set; }
    }
}
