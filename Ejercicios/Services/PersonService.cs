using Data;
using Infraestructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class PersonService
    {
        private AppDbContext db;
        public PersonService(AppDbContext _db)
        {
            db = _db;
        }

        #region GET
        public async Task<List<Person>> GetListAsync()
        {
            return await db.Personas.ToListAsync();
        }

        public async Task<Person> GetByIdAsync(Guid id)
        {
            return await db.Personas.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        #endregion

        #region ADD_EDIT
        public async Task<Person> AddEditAsync(Person data, bool commit = true)
        {
            if(await GetByIdAsync(data.Id) != null)
            {
                return await EditAsync(data, commit);
            }
            return await AddAsync(data, commit);
        }

        public async Task<Person> AddAsync(Person newData, bool commit = true)
        {
            await db.AddAsync(newData);
            if (commit) { db.SaveChanges(); }
            return newData;
        }

        public async Task<Person> EditAsync(Person newData, bool commit = true)
        {

            var resultOld = await GetByIdAsync(newData.Id);
            resultOld.Name = newData.Name;
            resultOld.Surname1 = newData.Surname1;
            resultOld.Surname2 = newData.Surname2;
            resultOld.Age = newData.Age;
            resultOld.Estado = newData.Estado;

            if (commit) { db.SaveChanges(); }

            return resultOld;

        }
        #endregion

        #region DELETE
        public async Task<Person> DeleteAsync(Guid id)
        {
            var resultOld = await GetByIdAsync(id);

            db.Remove(resultOld);
            db.SaveChanges();
            return resultOld;
        }
        #endregion
    }
}