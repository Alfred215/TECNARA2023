﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.CustomerDTOs
{
    public class CustomerPostDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public int Saldo { get; set; }
        public Guid PersonId { get; set; }
    }
}
