using Aula124_Enum.Entities;
using Aula124_Enum.Entities.Enums;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = Aula124_Enum.Entities.Enums.OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // Conversão de string para enumeração e vice versa

            // Convertendo para string
            string txt = OrderStatus.PendingPayment.ToString(); // dessa forma aqui eu converto para string, é só colocar o ToString no final
            
            // Agora eu tenho um valor no tipo string e quero converter para um tipo enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}