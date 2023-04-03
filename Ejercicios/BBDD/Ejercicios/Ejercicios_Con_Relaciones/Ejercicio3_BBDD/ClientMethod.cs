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

        public Cliente GetClientByNameAndPassword(string nombre, string contraseña)
        {
            return db.Cliente.Where(x => x.Nombre == nombre && x.ContraseñaHash == contraseña).FirstOrDefault();
        }

        public Cliente GetClientByName(string nombre)
        {
            return db.Cliente.Where(x => x.Nombre == nombre).FirstOrDefault();
        }
        #endregion

        #region SET
        public async Task AddAsync(Cliente cliente)
        {
            cliente.Id = 0;
            await db.AddAsync(cliente);

            db.SaveChanges();
        }
        #endregion

        #region DELETE
        public void DeleteClient(int id)
        {
            var cliente = GetClientById(id);
            db.Remove(cliente);
            db.SaveChanges();
        } 
        #endregion
    }
}
