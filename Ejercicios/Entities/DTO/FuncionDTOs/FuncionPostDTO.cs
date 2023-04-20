using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.FuncionDTOs
{
    public class FuncionPostDTO
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public Guid AreaId { get; set; }
    }
}
