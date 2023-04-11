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
    public class DB_ClienteEmpleadoServicio
    {
        dbContextEjercicios db;
        public DB_ClienteEmpleadoServicio(dbContextEjercicios _db)
        {
            db = _db;
        }

        #region Empleado

        #region GET
        public Empleado GetById_EMP(int id)
        {
            var empleado = db.Empleado.Where(x => x.Id == id).FirstOrDefault();
            return empleado;

        }

        public List<Empleado> GetList_EMP()
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
        public void AddEdit_EMP(Empleado empleado)
        {
            if (GetById_EMP(empleado.Id) != null)
            {
                Edit(empleado);
            }
            else
            {
                Create(empleado);
            }
        }

        public async Task Create(Empleado empleado)
        {
            empleado.Id = 0;
            await db.AddAsync(empleado);
            db.SaveChanges();

            GetList_EMP();
        }

        public void Edit(Empleado empleado)
        {
            var empleadoOld = GetById_EMP(empleado.Id);
            empleadoOld.Nombre = empleado.Nombre;
            empleadoOld.Empresa = empleado.Empresa;
            empleadoOld.Puesto = empleado.Puesto;
            empleadoOld.HoraEntrada = empleado.HoraEntrada;
            empleadoOld.HoraSalida = empleado.HoraSalida;
            empleadoOld.PrecioPorHora = empleado.PrecioPorHora;

            db.SaveChanges();
            GetList_EMP();
        }
        #endregion

        public void Delete_EMP(int id)
        {
            var empleado = GetById_EMP(id);
            db.Remove(empleado);
            db.SaveChanges();

            GetList_EMP();
        }
        #endregion

        //---------------------------------------------------------------------------------

        #region Cliente

        #region GET
        public Cliente GetById_CLI(int id)
        {
            var cliente = db.Cliente.Where(x => x.Id == id).FirstOrDefault();
            return cliente;

        }

        public List<Cliente> GetList_CLI()
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
        public void AddEdit_CLI(Cliente cliente)
        {
            if (GetById_CLI(cliente.Id) != null)
            {
                Edit(cliente);
            }
            else
            {
                Create(cliente);
            }
        }

        public async Task Create(Cliente empleado)
        {
            empleado.Id = 0;
            await db.AddAsync(empleado);
            db.SaveChanges();

            GetList_CLI();
        }

        public void Edit(Cliente cliente)
        {
            var clienteOld = GetById_CLI(cliente.Id);
            clienteOld.Nombre = cliente.Nombre;
            clienteOld.Saldo = cliente.Saldo;
            clienteOld.HoraDeServicio = cliente.HoraDeServicio;
       

            db.SaveChanges();
            GetList_CLI();
        }
        #endregion

        public void Delete_CLI(int id)
        {
            var cliente = GetById_CLI(id);
            db.Remove(cliente);
            db.SaveChanges();

            GetList_CLI();
        }
        #endregion

        public void CalcularCoste(int idCliente)
        {
            var cliente = GetById_CLI(idCliente);

            Random rmd = new Random();

            var empleado = GetById_EMP(rmd.Next(1,GetList_EMP().Count()+1));

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
