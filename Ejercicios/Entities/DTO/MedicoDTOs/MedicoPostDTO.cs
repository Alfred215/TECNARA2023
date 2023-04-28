using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.ComponentModel;

namespace Infraestructure.DTO.MedicoDTOs
{
    public class MedicoPostDTO
    {
        public Guid Id { get; set; }
        public string Area { get; set; }
        public string Funcion { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public int Segundo { get; set; }
        public Guid PersonaId { get; set; }
        public Guid HospitalId { get; set; }
    }
}
