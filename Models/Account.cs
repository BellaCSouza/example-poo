using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePOO.Models
{
    public abstract class Account
    {
        protected decimal balance;

        public abstract void Credit(decimal amount);

        public void DisplayBalance() {
            Console.WriteLine($"Your balance is R${balance}");
        }
    }
}