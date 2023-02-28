using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjemploClase.ListaDeContactos
{
    public class EjemploContactos
    {
        public void Ejercicio()
        {
            Agenda agendaDelTrabajo = new Agenda();

            List<string> opciones = new List<string>() {"1- Ingresar contacto", "2- Eliminar contacto", "3- Buscar telefono", "4- Listar contactos","5- Salir"};
            int posicion = 0;
            do
            {
                Console.WriteLine("Que desea realizar:");
                foreach (string opcion in opciones)
                {
                    Console.WriteLine(opcion);
                }
                posicion = Convert.ToInt32(Console.ReadLine());

                switch (posicion)
                {
                    case 1:
                        Console.WriteLine("Nombre:");
                        Console.WriteLine("Apellido:");
                        Console.WriteLine("Telefono:");
                        agendaDelTrabajo.CrearContacto(Console.ReadLine(),Console.ReadLine(),Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Nombre:");
                        Console.WriteLine("Apellido:");
                        agendaDelTrabajo.EliminarContacto(Console.ReadLine(), Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Nombre:");
                        Console.WriteLine("Apellido:");
                        Console.WriteLine("Numero de telefono: {0}",agendaDelTrabajo.BuscarContacto(Console.ReadLine(), Console.ReadLine()));
                        break;
                    case 4:
                        var listaContactos = agendaDelTrabajo.ListarContacto();
                        foreach(var contact in listaContactos)
                        {
                            Console.WriteLine("{0} {1} {2}",contact.Nombre, contact.Apellido, contact.Telefono);
                            
                        }
                        Console.WriteLine(listaContactos.Count());
                        break;
                }
            } while (posicion != 5);
            
        }
    }
}
