using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            //criando a minha matriz
            int[,] math = new int[n, n];

            // criando um for para ir percorrer a linha e preencher a linha
            for(int i = 0; i < n; i++) {

                string[] values = Console.ReadLine().Split(' ');

                //criei outro for aqui dentro para percorrer as colunas
                for(int j = 0; j < n; j++) {
                    math[i, j] = int.Parse(values[j]);
                }
            }

            // fazendo a imprensão da diagonal
            Console.WriteLine("Main diagonal:");
            for(int i = 0; i < n; i++) {
                Console.Write(math[i, i] + " ");
            }
            Console.WriteLine();

            // descobrindo os números negativos, e para isso preciso percorrer a matriz inteira, e pra isso acontecer eu faço 2 for

            int count = 0;
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    if(math[i,j] < 0) {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative number: " + count);
        }
    }
}