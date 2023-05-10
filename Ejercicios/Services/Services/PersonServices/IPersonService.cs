using Infraestructure.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.PersonServices
{
    public interface IPersonService
    {
        Task<List<Person>> GetListAsync();
        Task<Person> GetByIdAsync(Guid id);
        Task<Person> AddEditAsync(Person data, bool commit = true);
        Task<Person> DeleteAsync(Guid id);
    }
}
