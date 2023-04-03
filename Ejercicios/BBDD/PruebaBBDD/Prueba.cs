using BBDD.PruebaBBDD.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.PruebaBBDD
{
    public class Prueba
    {
        dbContextPrueba db;
        public Prueba(dbContextPrueba _db) 
        {
            db = _db;
        }

        #region GET
        public Persona GetById(int id)
        {
            var result = db.Persona.Where(x => x.Id == id).FirstOrDefault();
            return result;
        } 

        public List<Persona> GetListPersona()
        {
            return db.Persona.ToList();
        }
        #endregion

        #region SET
        public async Task AddPersonAsync(Persona persona)
        {
            persona.Id = 0;
            await db.AddAsync(persona);

            db.SaveChanges();
        }

        public void EditPerson(Persona persona)
        {
            var personaOld = GetById(persona.Id);

            personaOld.Name = persona.Name;
            personaOld.Surname1 = persona.Surname1;
            personaOld.Surname2 = persona.Surname2;
            personaOld.Age = persona.Age;

            db.SaveChanges();
        }

        public void AddEditAsync(Persona persona)
        {
            if (GetById(persona.Id) != null)
            {
                EditPerson(persona);
            }
            else
            {
                AddPersonAsync(persona);
            }

        }
        #endregion

        #region DELETE
        public void DeletePersona(int personaId)
        {
            var persona = GetById(personaId);

            db.Remove(persona);
            db.SaveChanges();
        } 
        #endregion
    }
}
