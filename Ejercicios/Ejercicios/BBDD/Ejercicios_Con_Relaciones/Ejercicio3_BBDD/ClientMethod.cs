using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD
{
    public class ClientMethod
    {
        dbContextEjerciciosRelaciones db;
        public ClientMethod(dbContextEjerciciosRelaciones _db)
        {
            db = _db;
        }

        #region GET
        public Cliente GetClientById(int id)
        {
            var cliente = db.Cliente.Where(x => x.Id == id).FirstOrDefault();
            return cliente;

        }

        public List<Cliente> GetListClient()
        {
            var clientes = db.Cliente.ToList();

            if (clientes.Count == 0)
            {
                Console.WriteLine("\nNo hay datos");
            }
            else
            {
                Console.WriteLine("\nLista completa de clientes");
                foreach (var cliente in clientes)
                {
                    Console.WriteLine("Id: {0} Nombre: {1} Saldo: {2} Horas del servicio: {3}", cliente.Id, cliente.Nombre, cliente.Saldo, cliente.ContraseñaHash);
                }
            }

            return clientes;
        }
        #endregion

        #region AddEDIT
        public void AddEdit(Cliente cliente)
        {
            if (GetClientById(cliente.Id) != null)
            {
                Edit(cliente);
            }
            else
            {
                AddAsync(cliente);
            }
        }

        public async Task AddAsync(Cliente empleado)
        {
            empleado.Id = 0;
            await db.AddAsync(empleado);
            db.SaveChanges();

            GetListClient();
        }

        public void Edit(Cliente cliente)
        {
            var clienteOld = GetClientById(cliente.Id);
            clienteOld.Nombre = cliente.Nombre;
            clienteOld.ContraseñaHash = cliente.ContraseñaHash;


            db.SaveChanges();
            GetListClient();
        }
        #endregion

        #region DELETE
        public void DeleteClient(int id)
        {
            var cliente = GetClientById(id);
            db.Remove(cliente);
            db.SaveChanges();

            GetListClient();
        } 
        #endregion
    }
}
