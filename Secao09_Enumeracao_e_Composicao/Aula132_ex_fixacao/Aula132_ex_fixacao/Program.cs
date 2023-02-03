using Aula132_ex_fixacao.Entities;
using Aula132_ex_fixacao.Entities.Enums;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter cliente data:");
            
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Enter order data: ");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int qtdpedido = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtdpedido; i++) {
                Console.WriteLine($"#{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(productQuantity ,productPrice, product);
                order.addItem(orderItem);
            }

            Console.WriteLine();

            Console.WriteLine("ORDER SUMARY:");
            Console.WriteLine(order);
        }
    }
}