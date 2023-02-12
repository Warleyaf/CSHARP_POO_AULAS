using System;

namespace Aula204_Solucao_interfaces.Entities {
    internal class CarRental {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental (DateTime start, DateTime finish, Vehicle vehicle) {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null; // esse invoice aqui não precisa, só coloquei por didática
        }
    }
}
