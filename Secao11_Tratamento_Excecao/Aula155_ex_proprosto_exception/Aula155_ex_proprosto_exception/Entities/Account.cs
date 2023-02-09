using System;
using Aula155_ex_proprosto_exception.Entities.Exceptions;

namespace Aula155_ex_proprosto_exception.Entities {
    internal class Account {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account () {

        }

        public Account (int number, string holder, double balance, double withdrawLimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit (double amount) {
            Balance += amount;
        }

        public void Withdraw (double amount) {
            if (Balance < amount) {
                throw new DomainException("Não tem saldo suficiente para retirar esse valor.");
            }

            if (amount > WithdrawLimit) {
                throw new DomainException("O saque excedeu o valor limite.");
            }

            Balance -= amount;
        }


    }
}
