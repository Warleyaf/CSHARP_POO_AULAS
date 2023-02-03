using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula132_ex_fixacao.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() {

        }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }
    }
}