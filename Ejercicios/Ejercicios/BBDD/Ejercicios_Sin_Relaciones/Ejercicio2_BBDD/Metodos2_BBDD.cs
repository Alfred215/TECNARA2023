using Ejercicios.BBDD.Ejercicios.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios.Ejercicio2_BBDD
{
    public class Metodos2_BBDD
    {
        dbContextEjercicios db;
        public Metodos2_BBDD(dbContextEjercicios _db)
        {
            db = _db;
        }

        #region Empleado

        #region GET
        public Empleado GetById(int id)
        {
            var empleado = db.Empleado.Where(x => x.Id == id).FirstOrDefault();
            return empleado;

        }

        public List<Empleado> GetListEmpleado()
        {
            var empleados = db.Empleado.ToList();

            if (empleados.Count == 0)
            {
                Console.WriteLine("\nNo hay datos");
            }
            else
            {
                Console.WriteLine("\nLista completa de empleados");
                foreach (var empleado in empleados)
                {
                    Console.WriteLine("Id: {0} Nombre: {1} Puesto: {2} Empresa: {3} Hora de entrada: {4} Hora de salida: {5} Precio por la hora: {6}", empleado.Id, empleado.Nombre, empleado.Puesto, empleado.Empresa, empleado.HoraEntrada, empleado.HoraSalida, empleado.PrecioPorHora);
                }
            }

            return empleados;
        }
        #endregion

        #region AddEDIT
        public void AddEdit(Empleado empleado)
        {
            if (GetById(empleado.Id) != null)
            {
                Edit(empleado);
            }
            else
            {
                AddAsync(empleado);
            }
        }

        public async Task AddAsync(Empleado empleado)
        {
            empleado.Id = 0;
            await db.AddAsync(empleado);
            db.SaveChanges();

            GetListEmpleado();
        }

        public void Edit(Empleado empleado)
        {
            var empleadoOld = GetById(empleado.Id);
            empleadoOld.Nombre = empleado.Nombre;
            empleadoOld.Empresa = empleado.Empresa;
            empleadoOld.Puesto = empleado.Puesto;
            empleadoOld.HoraEntrada = empleado.HoraEntrada;
            empleadoOld.HoraSalida = empleado.HoraSalida;
            empleadoOld.PrecioPorHora = empleado.PrecioPorHora;

            db.SaveChanges();
            GetListEmpleado();
        }
        #endregion

        public void Delete(int id)
        {
            var empleado = GetById(id);
            db.Remove(empleado);
            db.SaveChanges();

            GetListEmpleado();
        }
        #endregion

        #region Cliente

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
                    Console.WriteLine("Id: {0} Nombre: {1} Saldo: {2} Horas del servicio: {3}", cliente.Id, cliente.Nombre, cliente.Saldo, cliente.HoraDeServicio);
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
            clienteOld.Saldo = cliente.Saldo;
            clienteOld.HoraDeServicio = cliente.HoraDeServicio;
       

            db.SaveChanges();
            GetListClient();
        }
        #endregion

        public void DeleteClient(int id)
        {
            var cliente = GetClientById(id);
            db.Remove(cliente);
            db.SaveChanges();

            GetListClient();
        }
        #endregion

        public void CalcularCoste(int idCliente)
        {
            var cliente = GetClientById(idCliente);

            Random rmd = new Random();

            var empleado = GetById(rmd.Next(1,GetListEmpleado().Count()+1));

            if((cliente.HoraDeServicio * empleado.PrecioPorHora) <= cliente.Saldo)
            {
                Console.Clear();
                Console.WriteLine("Puedes pagar los servicios del empleado");
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("No puede pagar los servicios");
            }
        }
    }
}
