using Infraestructure.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.PersonDTOs
{
    public class PersonPostDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname1 { get; set; }
        public string Surname2 { get; set; }
        public string Age { get; set; }
        public EstadoPersonaType Estado { get; set; }
    }
}
