using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePOO.Models
{
    public class CheckingAccount
    {
        public CheckingAccount(int accountNumber, decimal initialBalance)
        {
            this.AccountNumber = accountNumber;
            this.balance = initialBalance;
        }
        public int AccountNumber { get; set; }
        private decimal balance;
        public void Withdraw(decimal amount) {
            if (balance >= amount) {
                balance -= amount;
            Console.WriteLine($"Withdraw successfully completed!");
            } else {
                Console.WriteLine($"The amount required is greater than the available balance.");
            }
        }

        public void ShowBalance() {
            Console.WriteLine($"Your available balance is R${balance}.");
        }
    }
}