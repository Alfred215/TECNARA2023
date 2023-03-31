﻿using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.PersonServices
{
    public interface IPersonService
    {
        public Task<Person> GetById(Guid id);
        public Task<List<Person>> GetList();
        public Task<Person> AddEditAsync(Person person);
        public Task<List<Person>> Delete(Guid id);
    }
}
