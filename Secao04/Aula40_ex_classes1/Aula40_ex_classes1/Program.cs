using Aula40_ex_classes1;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Funcionarios fun1, fun2;

            fun1 = new Funcionarios();
            fun2 = new Funcionarios();
            
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            fun1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            fun1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            fun2.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            fun2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (fun1.salario + fun2.salario) / 2.0;

            Console.WriteLine($"Salário médio = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}