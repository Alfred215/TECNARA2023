using Infraestructure.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.CustomerServices
{
    public  interface ICustomerService 
    {
        Task<List<Customer>> GetListAsync();
        Task<Customer> GetByIdAsync(Guid id);
        Task<Customer> AddEditAsync(Customer data, bool commit = true);
        Task<Customer> DeleteAsync(Guid id);
    }
}
