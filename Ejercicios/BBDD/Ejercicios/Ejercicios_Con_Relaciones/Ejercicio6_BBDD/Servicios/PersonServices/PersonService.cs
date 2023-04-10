using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.PersonServices
{
    public class PersonService : IPersonService
    {
        dbContextEjerciciosRelaciones6 db;
        public PersonService(dbContextEjerciciosRelaciones6 _db)
        {
            db = _db;
        }

        #region ADDEDIT
        public async Task AddEditAsync(Person person)
        {
            if (GetById(person.Id) != null)
            {
                await Edit(person);
            }
            else
            {
                await AddAsync(person);
            }
        }
        public async Task AddAsync(Person person)
        {
            await db.AddAsync(person);
            db.SaveChanges();
        }
        public async Task Edit(Person person)
        {
            var personOld = await GetById(person.Id);
            personOld.Name = person.Name;
            personOld.Surname1 = person.Surname1;
            personOld.Surname2 = person.Surname2;
            personOld.Age = person.Age;

            db.SaveChanges();
        }
        #endregion

        #region DELETE
        public async Task Delete(Guid id)
        {
            var personOld = await GetById(id);
            db.Remove(personOld);
            db.SaveChanges();
        }
        #endregion

        #region GET
        public async Task<Person> GetById(Guid id)
        {
            return await db.Person.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Person>> GetList()
        {
            return await db.Person.ToListAsync();
        } 
        #endregion
    }
}
