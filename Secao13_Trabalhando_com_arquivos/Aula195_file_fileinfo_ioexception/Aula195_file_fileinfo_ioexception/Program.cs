using System;
using System.IO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main (string[] args) {
            string sourcePath = @"c:\temp\file1.txt"; // coloco esse @ ai pra não precisar digitar as duas barrinhas
            string targetPath = @"c:\temp\file2.txt";

            try {
                FileInfo fileInfo = new FileInfo(sourcePath); // Aqui eu vou instancia um objeto que vai estar associado a este caminho do sourcePath que eu passar que no caso vai ser o "file1" 
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath); // aqui vai ler as linhas do meu arquivo file1
                foreach (string line in lines) {
                    Console.WriteLine(line);
                }

            } catch (IOException e) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
