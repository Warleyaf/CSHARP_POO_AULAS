using System;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program {
        static void Main(string[] args) {
            
            //Criando a lista
            List<string> list = new List<string>();

            //Adicionando elementos nessa lista, eu uso o "Add"
            list.Add("Warley");
            list.Add("Alex");
            list.Add("Walisson");
            list.Add("Lauana"); // o "Add" por padrão adiciona no final da lista
            list.Add("Ana");

            list.Insert(2, "Marco"); // o "Insert" eu já posso definir a posição

            foreach(string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine($"List count: {list.Count}"); // o "Count" vai mostrar o tamanho da lista

            // fazendo exemplo com o find, o find recebe uma função como parametro
            string s1 = list.Find(x => x[0] == 'A'); // aqui estou dizendo que eu quero encontrar o primeiro nome que comessa com a letra "A"
            Console.WriteLine("First 'A': " + s1);

            // fazendo exemplo com o findLast, que vai encontrar a última ocorrência que começa com a função A

            string s2 = list.FindLast(x => x[0] == 'A');

            // encontrando o primeiro elemento por index que começa com a letra "A"
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);
            // encontrando o ultimo index que o nome começa com "A"
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            Console.WriteLine("---------------------------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------");
            foreach(string obj in list2) {
                Console.WriteLine(obj);
            }
            list.Remove("Alex");
            Console.WriteLine("---------------------");
            foreach(string obj in list) {
                Console.WriteLine(obj);
            }
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------");
            foreach(string obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}