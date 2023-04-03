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
        public List<BankAccount> GetListIngresosClient(int idClient)
        {
            var banks = db.BankAccount.Where(x => x.ClientId == idClient && x.Retirada == 0).ToList();

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

        public List<BankAccount> GetListRetiradasClient(int idClient)
        {
            var banks = db.BankAccount.Where(x => x.ClientId == idClient && x.Ingreso == 0).ToList();

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

        public List<BankAccount> GetListMovimentClient(int idClient)
        {
            var banks = db.BankAccount.Where(x => x.ClientId == idClient).ToList();

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

        public BankAccount GetLastMovimentByClient(int? idClient)
        {
            return db.BankAccount.Where(x => x.ClientId == idClient).OrderBy(x => x.Id).LastOrDefault();
        }
        #endregion

        #region SET
        public async Task CreateAccountAsync(BankAccount bankAccount)
        {
            await db.AddAsync(bankAccount);
            db.SaveChanges();
        }

        public async Task IngresoAsync(BankAccount bankAccount)
        {
            var lastBankAccount = GetLastMovimentByClient(bankAccount.ClientId);

            bankAccount.Id = 0;
            bankAccount.Retirada = 0;
            bankAccount.Saldo = lastBankAccount.Saldo + bankAccount.Ingreso;

            await db.AddAsync(bankAccount);
            db.SaveChanges();
        }

        public async Task RetiradaAsync(BankAccount bankAccount)
        {
            var lastBankAccount = GetLastMovimentByClient(bankAccount.ClientId);

            bankAccount.Id = 0;
            bankAccount.Ingreso = 0;
            bankAccount.Saldo = lastBankAccount.Saldo - bankAccount.Retirada;

            await db.AddAsync(bankAccount);
            db.SaveChanges();
        }
        #endregion

        #region DELETE
        public void DeleteAccountBank(int idClient)
        {
            var listBankAccount = GetListMovimentClient(idClient);
            foreach (var account in listBankAccount) 
            {
                db.Remove(account);
                db.SaveChanges();
            }
            
        }
        #endregion
    }
}
