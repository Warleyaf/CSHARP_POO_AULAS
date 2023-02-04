
namespace Aula135_Heranca.Entities
{
    public class SavingsAccount : Account
    {
        public double InterestRate{ get; set; }

        public SavingsAccount() {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) // todas as operações da superclasse que tenha a palavra "virtual" vão aparecer nos override, como nessa linha de código
        {
            Balance -= amount;
        }
    }
}