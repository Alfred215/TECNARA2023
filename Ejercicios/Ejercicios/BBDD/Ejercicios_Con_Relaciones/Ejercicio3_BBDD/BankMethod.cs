using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD
{
    public class BankMethod
    {
        dbContextEjerciciosRelaciones db;
        public BankMethod(dbContextEjerciciosRelaciones _db)
        {
            db = _db;
        }

        #region GET
        public List<BankAccount> GetListIngresosClient(int id)
        {
            var banks = db.BankAccount.Where(x => x.ClientId == id && x.Retirada == 0).ToList();

            if (banks.Count == 0)
            {
                Console.WriteLine("\nNo hay datos");
            }
            else
            {
                Console.WriteLine("\nLista completa de ingresos");
                foreach (var bank in banks)
                {
                    Console.WriteLine("Id: {0} Nombre: {1} Saldo: {2} Horas del servicio: {3}", bank.Saldo, bank.Ingreso, bank.Retirada, bank.Client.Nombre);
                }
            }

            return banks;
        }

        public List<BankAccount> GetListRetiradasClient(int id)
        {
            var banks = db.BankAccount.Where(x => x.ClientId == id && x.Ingreso == 0).ToList();

            if (banks.Count == 0)
            {
                Console.WriteLine("\nNo hay datos");
            }
            else
            {
                Console.WriteLine("\nLista completa de retiradas");
                foreach (var bank in banks)
                {
                    Console.WriteLine("Id: {0} Nombre: {1} Saldo: {2} Horas del servicio: {3}", bank.Saldo, bank.Ingreso, bank.Retirada, bank.Client.Nombre);
                }
            }

            return banks;
        }

        public List<BankAccount> GetListMovimentClient(int id)
        {
            var banks = db.BankAccount.Where(x => x.ClientId == id).ToList();

            if (banks.Count == 0)
            {
                Console.WriteLine("\nNo hay datos");
            }
            else
            {
                Console.WriteLine("\nLista de movimientos");
                foreach (var bank in banks)
                {
                    Console.WriteLine("Id: {0} Nombre: {1} Saldo: {2} Horas del servicio: {3}", bank.Saldo, bank.Ingreso, bank.Retirada, bank.Client.Nombre);
                }
            }

            return banks;
        }

        public BankAccount GetLastMovimentByClient(int clientId)
        {
            return db.BankAccount.Where(x => x.ClientId == clientId).LastOrDefault();
        }
        #endregion

        #region SET
        public async Task IngresoAsync(int ingreso)
        {
            Console.WriteLine("Id del cliente");
            var clientId = Convert.ToInt32(Console.ReadLine());
            var lastBankAccount = GetLastMovimentByClient(clientId);

            var bank = new BankAccount();
            bank.Id = 0;
            bank.Saldo = lastBankAccount.Saldo + ingreso;
            bank.Retirada = 0;
            bank.Ingreso = ingreso;
            bank.ClientId = clientId;

            await db.AddAsync(bank);
            db.SaveChanges();
        }

        public async Task RetiradaAsync(int retirada)
        {
            Console.WriteLine("Id del cliente");
            var clientId = Convert.ToInt32(Console.ReadLine());
            var lastBankAccount = GetLastMovimentByClient(clientId);

            var bank = new BankAccount();
            bank.Id = 0;
            bank.Saldo = lastBankAccount.Saldo - retirada;
            bank.Retirada = retirada;
            bank.Ingreso = 0;
            bank.ClientId = clientId;

            await db.AddAsync(bank);
            db.SaveChanges();
        }

        public async Task CreateBankAccount(int clientId)
        {
            Console.WriteLine("Saldo inicial?");
            var saldo = Convert.ToInt32(Console.ReadLine());

            var bank = new BankAccount();
            bank.Id = 0;
            bank.Saldo = saldo;
            bank.Retirada = 0;
            bank.Ingreso = saldo;
            bank.ClientId = clientId;

            await db.AddAsync(bank);
            db.SaveChanges();
        }

        #endregion

    }
}
