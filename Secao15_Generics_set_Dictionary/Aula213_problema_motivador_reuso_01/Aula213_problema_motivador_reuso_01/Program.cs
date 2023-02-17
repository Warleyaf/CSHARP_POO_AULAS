using Aula213_problema_motivador_reuso_01;
using System;

namespace MyApp
{
    internal class Program {
        static void Main (string[] args) {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i<n; i++) {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            // agora terei que imprimir todos os meus elementos
            printService.Print();
            Console.WriteLine($"First: " + printService.First());
        }
    }
}
