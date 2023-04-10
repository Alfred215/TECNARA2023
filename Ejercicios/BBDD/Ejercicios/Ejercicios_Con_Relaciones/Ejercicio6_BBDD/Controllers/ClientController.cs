using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.ClientServices;
using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Servicios.EmployeeServices;
using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Controllers
{
    public class ClientController
    {
        private ClientService clientSV;
        
        public ClientController(dbContextEjerciciosRelaciones6 _db)
        {
            clientSV = new ClientService(_db);
        }

        public async Task AddEditClientAsync()
        {
            var listClient = await clientSV.GetList();
            int i = 0;
            foreach (var client in listClient)
            {
                Console.WriteLine("{0}- Nombre: {1} Saldo: {2} Horas de servicio: {3}", ++i, client.Person.Name, client.Saldo, client.HoraServicio);
            }

            Console.WriteLine("Elija una posición o escriba 0 para crear un nuevo registro");
            var position = Convert.ToInt32(Console.ReadLine());

            Client clientAddEdit = new Client();
            clientAddEdit.Id = position  == 0 ? new Guid() : listClient[position - 1].Id;

            #region Lista de Personas
            var listPerson = await clientSV.GetListPerson();

            foreach (var person in listPerson)
            {
                Console.WriteLine("{0}- Nombre: {1} P. Apellido: {2} S. Apellido: {3} Edad: {4}", ++i, person.Name, person.Surname1, person.Surname2, person.Age);
            } 
            
            Console.WriteLine("Elija una posición: ");
            var positionPerson = Convert.ToInt32(Console.ReadLine());
            clientAddEdit.PersonId = listPerson[positionPerson - 1].Id;
            #endregion

            Console.WriteLine("Saldo");
            clientAddEdit.Saldo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Horas de servicio");
            clientAddEdit.HoraServicio = Convert.ToInt32(Console.ReadLine());

            await clientSV.AddEditAsync(clientAddEdit);
        }

        public async Task DeleteClientAsync()
        {
            var listClient = await clientSV.GetList();
            int i = 0;
            foreach (var client in listClient)
            {
                Console.WriteLine("{0}- Nombre: {1} Saldo: {2} Horas de servicio: {3}", ++i, client.Person.Name, client.Saldo, client.HoraServicio);
            }

            var position = Convert.ToInt32(Console.ReadLine());

            await clientSV.Delete(listClient[position - 1].Id);
        }

        public async Task GetListClientAsync()
        {
            var listClient = await clientSV.GetList();
            int i = 0;
            foreach (var client in listClient)
            {
                Console.WriteLine("{0}- Nombre: {1} Saldo: {2} Horas de servicio: {3}", ++i, client.Person.Name, client.Saldo, client.HoraServicio);
            }
        }

    }
}
