using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Text;
using Aula132_ex_fixacao.Entities.Enums;

namespace Aula132_ex_fixacao.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        List <OrderItem> Items {get; set;} = new List<OrderItem>();

        public Order () {

        }

        public Order (DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item) {
            Items.Add(item);
        }

        public void removeItem(OrderItem item) {
            Items.Remove(item);
        }

        public double Total() {
            double sum = 0.0;

            foreach(OrderItem item in Items) {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMARY:");
            sb.Append($"Order moment: {Moment}");
            sb.Append($"Order status: {Status}");
            sb.Append($"Client: {Client.Name} ({Client.BirthDate}) - {Client.Email}");
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in Items) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}