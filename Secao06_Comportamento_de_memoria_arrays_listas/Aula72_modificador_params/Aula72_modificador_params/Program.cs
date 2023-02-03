using Aula72_modificador_params;
using System;

namespace MyApp
{
    internal class Program {
        static void Main(string[] args) {

            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
