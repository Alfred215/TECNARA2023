using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjemploClase.ListaDeContactos
{
    public class Agenda
    {
        List<Contacto> contactos = new List<Contacto>();

        public void CrearContacto(string nombre, string apellido, int telefono)
        {
            contactos.Add(new Contacto { Nombre = nombre, Apellido = apellido, Telefono = telefono });
        }

        public void EliminarContacto(string nombre, string apellido)
        {
            var contactoAEliminar = contactos.Where(x => x.Nombre == nombre && x.Apellido == apellido).FirstOrDefault();

            if(contactoAEliminar != null)
            {
                Console.WriteLine("Quieres eliminar el contacto {0}: (Si/No)", contactoAEliminar.Nombre);
                string confirmacion = Console.ReadLine().ToUpper();

                if (confirmacion[0].ToString().Equals("S"))
                { 
                    contactos.Remove(contactoAEliminar);
                }
            }
        }

        public int BuscarContacto(string nombre, string apellido)
        {
            var telefonoEncontrado = contactos
                .Where(x => x.Nombre == nombre && x.Apellido == apellido) //-> filtro.
                .Select(x => x.Telefono)    //-> Convertir de lista de contactos a lista de telefonos.
                .FirstOrDefault();          // -> Elegimos el primero de la lista.

            return telefonoEncontrado;
        }

        public List<Contacto> ListarContacto()
        {
            var listaDeContactos = contactos
                .OrderBy(x => x.Nombre) //-> Para ordenar el listado por orden alfabetico ascendente de nombre
                .ToList();              //-> cómo no es de tipo list, lo convertimos.

            return listaDeContactos;
        }
    }
}
