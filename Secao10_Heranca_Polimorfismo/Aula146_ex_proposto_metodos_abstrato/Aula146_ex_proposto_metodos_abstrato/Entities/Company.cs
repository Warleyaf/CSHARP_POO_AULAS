using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula146_ex_proposto_metodos_abstrato.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployee { get; set; }

        public Company(int numberOfEmployee, string name, double anualIncome) : base(name, anualIncome) 
        { 
            NumberOfEmployee= numberOfEmployee;
        }

        public override double Tax()
        {
            if(NumberOfEmployee > 10)
            {
                return AnualIncome * 0.14;
            } else {
                return AnualIncome * 0.16;
            }
        }
    }
}
