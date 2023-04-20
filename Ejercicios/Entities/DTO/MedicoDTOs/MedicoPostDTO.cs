using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.MedicoDTOs
{
    public class MedicoPostDTO
    {
        public Guid Id { get; set; }
        public string Area { get; set; }
        public string Funcion { get; set; }
        public TimeSpan HorasDia { get; set; }
        public Guid PersonaId { get; set; }
        public Guid HospitalId { get; set; }

        public virtual Person Persona { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
