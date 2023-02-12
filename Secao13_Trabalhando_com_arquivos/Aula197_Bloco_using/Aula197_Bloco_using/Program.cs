using System;
using System.IO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main (string[] args) {

            string path = @"c:\temp\file1.txt";


            // Criei um bloco using, e entre parenteses eu vou instanciar os meus recursos.
            // o "path" é o meu caminho do arquivo e o "FileMode.Open" é o modo de abertura do meu arquivo
            try {
                // tudo que estiver dentro desse bloco vai ser executado, e ao final dele vai ser fechado automáticamente
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            } catch (IOException ex) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

