using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula132_ex_fixacao.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() {

        }

        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal() {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, Qunatity: {Quantity}, Subtotal: ${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}