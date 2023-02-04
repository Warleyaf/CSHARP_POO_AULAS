using System;
using Aula135_Heranca.Entities;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING
            Account acc1 = bacc; // aqui estou dizzendo que o meu "acc1" recebe os valores que estão no meu "bacc""
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);
            // Tenho essas formas ai de cima para se fazer UPCASTING


            // DOWNCASTING, Que é a conversão da superclasse para a subclasse
            BusinessAccount acc4 = (BusinessAccount)acc2; // para aceitar eu precisei fazer o "CASTING" do BusinessAccount
            acc4.Loan(100.0);

        }
    }
}