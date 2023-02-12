using System;
using System.Globalization;
using Aula204_Solucao_interfaces.Entities;
using Aula204_Solucao_interfaces.Services;

namespace MyApp
{
    internal class Program {
        static void Main (string[] args) {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            // Agora irei instanciar o Objeto "CarRental" já associado com o objeto "Vehicle"
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            // Para processar esse aluguel eu vou ter que instanciar um rental service
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental); // Isso aqui tem que gerar o meu objeto invoice e associar ele ao meu aluguel que no caso é o "carRental"
            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}