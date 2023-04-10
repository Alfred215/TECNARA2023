using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.PersonServices;
using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Controllers
{
    public class PersonController
    {
        private PersonService personSV;
        public PersonController(dbContextEjerciciosRelaciones6 _db) 
        {
            personSV = new PersonService(_db);
        }

        public async Task AddEditPersonAsync()
        {
            var listPerson = await personSV.GetList();
            int i = 0;
            foreach(var person in listPerson)
            {
                Console.WriteLine("{0}- Nombre: {1} P. Apellido: {2} S. Apellido: {3} Edad: {4}", ++i, person.Name, person.Surname1, person.Surname2, person.Age);
            }

            Console.WriteLine("Elija una posición o escriba 0 para crear un nuevo registro");
            var position = Convert.ToInt32(Console.ReadLine());

            Person personAddEdit = new Person();
            personAddEdit.Id = position == 0 ? new Guid() : listPerson[position - 1].Id;
            Console.WriteLine("Nombre");
            personAddEdit.Name = Console.ReadLine();
            Console.WriteLine("P. Apellido");
            personAddEdit.Surname1 = Console.ReadLine();
            Console.WriteLine("S. Apellido");
            personAddEdit.Surname2 = Console.ReadLine();
            Console.WriteLine("Edad");
            personAddEdit.Age = Convert.ToInt32(Console.ReadLine());

            await personSV.AddEditAsync(personAddEdit);
        }

        public async Task DeletePersonAsync()
        {
            var listPerson = await personSV.GetList();
            int i = 0;
            foreach (var person in listPerson)
            {
                Console.WriteLine("{0}- Nombre: {1} P. Apellido: {2} S. Apellido: {3} Edad: {4}", ++i, person.Name, person.Surname1, person.Surname2, person.Age);
            }

            var position = Convert.ToInt32(Console.ReadLine());

            personSV.Delete(listPerson[position - 1].Id);
        }

        public async Task GetListPersonAsync()
        {
            var listPerson = await personSV.GetList();
            int i = 0;
            foreach (var person in listPerson)
            {
                Console.WriteLine("{0}- Nombre: {1} P. Apellido: {2} S. Apellido: {3} Edad: {4}", ++i, person.Name, person.Surname1, person.Surname2, person.Age);
            }
        }
    }
}
