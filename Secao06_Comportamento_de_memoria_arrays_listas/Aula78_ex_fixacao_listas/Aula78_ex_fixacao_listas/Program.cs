using System;
using System.Globalization;
using System.Collections.Generic;
using Aula78_ex_fixacao_listas;

namespace MyApp
{
    internal class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registered? ");
            int qtdFuncionario = int.Parse(Console.ReadLine());

            List<Funcionarios> funcionarios= new List<Funcionarios>();

            for(int i = 1; i <= qtdFuncionario; i++) {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                funcionarios.Add(new Funcionarios(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int procurarId = int.Parse(Console.ReadLine());

            Funcionarios fun = funcionarios.Find(x => x.Id == procurarId);

            if(fun != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                fun.increaseSalary(percentage);
            } else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");
            foreach(Funcionarios obj in funcionarios) {
                Console.WriteLine(obj);
            }
        }
    }
}
