using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Encapsulacion
{
    public class EjercicioEncapsulacion
    {
        /* En este ejemplo, la clase BankAccount encapsula su atributo balance 
         * y solo permite que se acceda y modifique a través de los métodos 
         * públicos Deposit, Withdraw y GetBalance. El método Withdraw verifica 
         * si hay suficientes fondos antes de permitir una retirada y emite un 
         * mensaje si no es así. */

        public EjercicioEncapsulacion()
        {
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            account.Withdraw(500);
            Console.WriteLine("Balance: " + account.GetBalance());
        }
    }
}
