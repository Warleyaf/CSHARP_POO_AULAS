using Aula146_ex_proposto_metodos_abstrato.Entities;
using System;
using System.Globalization;

namespace Aula146_ex_proprosto_metodos_abstrato // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Tax Payer #{i} data:");
                Console.Write($"Individual or Company (i/c)? ");
                char ch = char.Parse( Console.ReadLine() );

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(healthExpenditures, name, anualIncome));
                } else {
                    Console.Write("Number of Employee: ");
                    int numberOfEmployee = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Company(numberOfEmployee, name, anualIncome));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            foreach(TaxPayer tp in list) {

                double tax = tp.Tax();
                Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}