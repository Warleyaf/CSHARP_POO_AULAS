using System;
using System.Collections.Generic;

using Aula128_ex_composicao_pt01.Entities.Enums; // usando isso aqui para pegar o WorkerLevel

namespace Aula128_ex_composicao_pt01.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // dessa forma aqui que faço a composição
        //Composição é tipo associação entre as classes como nesse ai de cima
        //É tipo eu estar dizendo que a classe "Woker" tem as propriedades dele e també as propriedades da classe "Department"
        // Objetos associados entre si, entre outras palavras uma composição de objetos

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        // Agora iremos fazer o construtor
        // o primeirot construtor vai ser um construtor vazio

        public Worker() { 
        
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Adicionar contrato
        public void AddContract(HourContract contract) { 
            Contracts.Add(contract);
        }

        // Remover o contrato
        public void RemoveContract(HourContract contract) { 
            Contracts.Remove(contract); 
        }

        // income = ganho, quantos que o funcionário ganhou

        public double Income(int year, int month) {

            double sum = BaseSalary;
            foreach(HourContract contract in Contracts) {
                if(contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
