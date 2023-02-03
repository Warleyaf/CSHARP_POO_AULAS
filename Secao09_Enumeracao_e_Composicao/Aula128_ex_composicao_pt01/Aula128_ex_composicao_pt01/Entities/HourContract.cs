using System;

namespace Aula128_ex_composicao_pt01.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; } // propriedade datetime que vai ser a data do contrato
        public double ValuePerHour { get; set; } // propriedade
        public int Hours { get; set; } // Propriedade, esse get e set é o getters e setters

        public HourContract() { //Construtor padrão
        }

        public HourContract(DateTime date, double valuePerHour, int hours) // contrutores com os argumentos
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue() { // Método
            return Hours * ValuePerHour;
        }
    }
}
