using Aula71_ex_vetores;
using System;
using System.Numerics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Quantos quartos serão alugados? ");
            int N = int.Parse(Console.ReadLine());

            Estudante[] vetor = new Estudante[10];

            for(int i = 1; i <= N; i++ ) {
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vetor[quarto] = new Estudante { Nome = nome, Email = email };
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for(int i = 0; i < 10; i++ ) {
                if(vetor[i] != null) {
                    Console.WriteLine($"{i} : {vetor[i]}");
                }
            }
        }
    }
}