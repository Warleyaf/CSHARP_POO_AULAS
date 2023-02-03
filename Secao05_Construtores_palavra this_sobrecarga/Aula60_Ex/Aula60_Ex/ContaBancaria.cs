using System;
using System.Globalization;
namespace Aula60_Ex {
    internal class ContaBancaria {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //Meu construtor
        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        // irei criar uma sobrecarga
        //Usei o this para reaproveitar o numero e o titular do meu primeiro construtor
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            //fica melhor eu já chamar o método Deposito que vai receber logo o depósito inicial
            // Mas por que isso é melhor?  é por que quem contém a lógica do Deposito e a operção depósito

            Deposito(depositoInicial);

            // Tava assim antes \/, mudei por causa da fácil manutenção do código de cima
            // Saldo = saldo
        }

        public void Deposito(double quantia) {
            Saldo += quantia; 
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5.0;
        }





        public override string ToString() {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
