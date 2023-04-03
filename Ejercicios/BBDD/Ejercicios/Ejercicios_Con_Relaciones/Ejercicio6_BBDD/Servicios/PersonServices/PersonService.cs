using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.PersonServices
{
    public class PersonService : IPersonService
    {
        public Task<Person> AddEditAsync(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<List<Person>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Person>> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
