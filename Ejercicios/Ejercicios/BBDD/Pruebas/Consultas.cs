using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Ejercicios.BBDD.Entities;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Prueba1
{
    public class Consultas
    {
        public BBDDTecnaraContext db;
        public Consultas(BBDDTecnaraContext _db)
        {
            db = _db;

            #region GET
            GetList();
            //GetById(2);
            //GetByName("Alfredo");
            //FilterByAge();
            #endregion

            #region AddEdit
            var person = new Persona();
            person.Name = "Alberto";
            person.Surname1 = "Alvarez";
            person.Surname2 = "Rus";
            person.Age = 22;
            CreatePersonAsync(person);

            //EditPersonAsync();
            #endregion

            #region DELETE
            DeletePerson();
            #endregion
        }

        #region GET
        public void GetList()
        {
            var personas = db.Persona.ToList();

            Console.WriteLine("Lista completa");
            foreach (var persona in personas)
            {
                Console.WriteLine("Id: {0} Nombre: {1} P. Apellido: {2} S. Apellido: {3} Edad: {4}", persona.Id, persona.Name, persona.Surname1, persona.Surname2, persona.Age);
            }
        }

        public Persona GetById(int id)
        {
            var persona = db.Persona.Where(x => x.Id == id).FirstOrDefault();
            Console.WriteLine("Filtro por Id");
            Console.WriteLine("Id: {0} Nombre: {1} P. Apellido: {2} S. Apellido: {3} Edad: {4}", persona.Id, persona.Name, persona.Surname1, persona.Surname2, persona.Age);
            return persona;
        }

        public void GetByName(string name)
        {
            var persona = db.Persona.Where(x => x.Name.Contains(name)).FirstOrDefault();
            Console.WriteLine("Filtro por Nombre");
            Console.WriteLine("Id: {0} Nombre: {1} P. Apellido: {2} S. Apellido: {3} Edad: {4}", persona.Id, persona.Name, persona.Surname1, persona.Surname2, persona.Age);
        }

        public void FilterByAge()
        {
            var personas = db.Persona.Where(x => x.Age >= 16 && x.Age <= 27).ToList();

            Console.WriteLine("Filtro por Edad");
            foreach (var persona in personas)
            {
                Console.WriteLine("Id: {0} Nombre: {1} P. Apellido: {2} S. Apellido: {3} Edad: {4}", persona.Id, persona.Name, persona.Surname1, persona.Surname2, persona.Age);
            }
        }
        #endregion

        #region SET
        public async Task CreatePersonAsync(Persona person)
        {
            await db.AddAsync(person);
            db.SaveChanges();

            GetList();
        }

        public async Task EditPersonAsync()
        {
            Console.WriteLine("ID:");
            var person = GetById(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Nombre:");
            person.Name = Console.ReadLine();
            person.Surname1 = person.Surname1;
            person.Surname2 = person.Surname2;
            person.Age = person.Age;

            db.SaveChanges();
            GetList();
        }
        #endregion

        #region DELETE
        public void DeletePerson()
        {
            Console.WriteLine("ID:");
            var person = GetById(Convert.ToInt32(Console.ReadLine()));
            db.Remove(person);
            db.SaveChanges();

            GetList();

        }
        #endregion

    }
}
