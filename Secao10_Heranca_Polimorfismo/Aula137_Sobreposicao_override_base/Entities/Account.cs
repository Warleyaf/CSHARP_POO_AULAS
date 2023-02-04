using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula135_Heranca.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; }

        public Account() {

        }

        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) { // esse "virtual" me diz que o método Withdraw pode ser sobrescrito
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }

    }
}