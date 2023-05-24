using Data;
using Infraestructure.DTO.CustomerDTOs;
using Infraestructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

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
        public async Task<List<Customer>> GetListFilterAsync(CustomerFilterDTO filter, int pageIndex = 1, int pageSize = 5)
        {
            var list = await db.Customers
                .Where(x => filter.UserName != null ? x.UserName.Contains(filter.UserName): x.UserName == x.UserName)
                .Where(x => filter.Saldo != null ? x.Saldo.ToString().Contains(filter.Saldo.ToString()): x.Saldo == x.Saldo)
                .Where(x => filter.Estado != null ? x.Estado == filter.Estado: x.Estado == x.Estado)
                .ToListAsync();
            if(list.Count > 0)
            {
                int index = (pageIndex - 1) * pageSize;
                if ((index + pageSize) > list.Count)
                {
                    pageSize -= (index + pageSize) - list.Count;
                }

                if (filter.OrderBy != null && filter.AscOrDesc != null)
                {
                    if (filter.AscOrDesc.Value)
                    {
                        list = list.OrderBy(x => GetFieldToOrderBy(x, filter.OrderBy)).ToList();
                    }
                    else
                    {
                        list = list.OrderByDescending(x => GetFieldToOrderBy(x, filter.OrderBy)).ToList();
                    }
                }

                var result = list.GetRange(index, pageSize);
                
                return result;
            }
            return null;
        }

        public string GetFieldToOrderBy(Customer x, string orderBy)
        {
            switch (orderBy)
            {
                case "userName":
                    return x.UserName;
                case "saldo":
                    return x.UserName;
                case "estado":
                    return x.UserName;
                default:
                    return null;
            }
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
