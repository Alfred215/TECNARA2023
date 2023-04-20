using Infraestructure.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.HospitalDTOs
{
    public class HospitalPostDTO
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public LocalizacionType Localizacion { get; set; }
        public string Especialidad { get; set; }
        public int Capacidad { get; set; }
        public int Trabajadores { get; set; }
    }
}
