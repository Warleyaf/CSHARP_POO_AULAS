using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            double[,] mat = new double[2, 3];
            Console.WriteLine(mat.Length); // Me mostra o total de elementos que a minnha matriz tem

            Console.WriteLine(mat.Rank); // Fala quanto é a 1° dimensão da matriz que é a quantidade de linahs

            Console.WriteLine();
        }
    }
}