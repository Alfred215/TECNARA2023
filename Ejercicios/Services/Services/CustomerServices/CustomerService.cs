using Data;
using Infraestructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        private AppDbContext db;
        public CustomerService(AppDbContext _db)
        {
            db = _db;
        }

        #region GET
        public async Task<List<Customer>> GetListAsync()
        {
            return await db.Customers.ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(Guid id)
        {
            return await db.Customers.Where(x => x.Id == id).Include(x => x.Person).FirstOrDefaultAsync();
        }
        #endregion

        #region ADD_EDIT
        public async Task<Customer> AddEditAsync(Customer data, bool commit = true)
        {
            if (await GetByIdAsync(data.Id) != null)
            {
                return await EditAsync(data, commit);
            }
            return await AddAsync(data, commit);
        }

        public async Task<Customer> AddAsync(Customer newData, bool commit = true)
        {
            await db.AddAsync(newData);
            if (commit) { db.SaveChanges(); }
            return newData;
        }

        public async Task<Customer> EditAsync(Customer newData, bool commit = true)
        {

            var resultOld = await GetByIdAsync(newData.Id);
            resultOld.UserName = newData.UserName;
            resultOld.Saldo = newData.Saldo;
            resultOld.Estado = newData.Estado;
            resultOld.PersonId = newData.PersonId;

            if (commit) { db.SaveChanges(); }

            return resultOld;
        }
        #endregion

        #region DELETE
        public async Task<Customer> DeleteAsync(Guid id)
        {
            var resultOld = await GetByIdAsync(id);

            db.Remove(resultOld);
            db.SaveChanges();
            return resultOld;
        }
        #endregion
    }
}
