using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula146_ex_proposto_metodos_abstrato.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        { 
            HealthExpenditures= healthExpenditures;
        }

        public override double Tax()
        {
            if(AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            } else {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
        }
    }
}
