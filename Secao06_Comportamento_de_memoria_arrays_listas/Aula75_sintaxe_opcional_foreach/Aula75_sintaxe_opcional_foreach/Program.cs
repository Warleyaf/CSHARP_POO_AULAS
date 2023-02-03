using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            for(int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("----------------------");
            // Percorrendo o vetor usando o foreach

            // nesse obj eu posso dar qualquer nome, lê-se "Para cada obj no vect imprima obj"
            foreach(string obj in vect) {
                Console.WriteLine(obj);
            }
            
        }
    }
}