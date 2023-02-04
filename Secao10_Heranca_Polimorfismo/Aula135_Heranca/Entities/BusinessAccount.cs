
namespace Aula135_Heranca.Entities
{
    public class BusinessAccount : Account // Com esse dois pontos e a classe "Account", eu estou dizendo que a classe "BusinessAccount" vai ter tudo que a classe "Account" tem, ou seja vai estar herdando.
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() {

        }
        // É dessa forma ai de baixo que faço o construtor da subclasse, coloco os mesmos parâmetros da classe "PAI" e depois os parâmetros da subclasse depois colo o " : base " para inserir os valores da classe "PAI"
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) {
            if(amount <= LoanLimit) {
                Balance += amount;
            }
        }
    }
}