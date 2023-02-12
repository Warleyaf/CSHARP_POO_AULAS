using System;
using Aula204_Solucao_interfaces.Entities;

namespace Aula204_Solucao_interfaces.Services {
    internal class RentalService {
        public double PricePerHour { get; private set; } // nesse private eu estou restringindo o acesso nos valores, onde estou dizendo que só posso acessar os valores e não auteralos
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService (double pricePerHour, double pricePerDay) {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice (CarRental carRental) { 
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0) {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            } else { 
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            // INSTANCIANDO O MEU INVOICE E ASSOCIAR COM O MEU CARRENTAL

            carRental.Invoice = new Invoice(basicPayment, tax); // isso aqui é processar o meu invoice
        }
    }
}
