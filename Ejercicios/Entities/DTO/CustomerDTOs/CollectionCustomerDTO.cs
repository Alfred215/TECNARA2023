using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure.DTO.PersonDTOs;

namespace Infraestructure.DTO.CustomerDTOs
{
    public class CollectionCustomerDTO
    {
        public List<CustomerMiniDTO> Personas { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
