using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.CustomerDTOs
{
    public class CustomerFilterDTO
    {
        public string? UserName { get; set; }
        public int? Saldo { get; set; }
        public EstadoType? Estado { get; set; }
    }
}
