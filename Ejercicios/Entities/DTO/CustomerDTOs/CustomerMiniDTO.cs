using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.CustomerDTOs
{
    public class CustomerMiniDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public int Saldo { get; set; }
        public Guid PersonId { get; set; }
        public EstadoType? Estado { get; set; }
        public string EstadoDescription { get; set; }
        public string Name { get; set; }
        public string Surname1 { get; set; }
        public string Surname2 { get; set; }
        public string Age { get; set; }

    }
}
