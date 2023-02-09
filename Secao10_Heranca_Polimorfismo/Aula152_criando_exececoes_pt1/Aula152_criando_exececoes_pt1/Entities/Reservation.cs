using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula152_criando_exececoes_pt1.Entities
{
    internal class Reservation

    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { 
            
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut) { 
            RoomNumber= roomNumber;
            CheckIn= checkIn;
            CheckOut= checkOut;
        }

        public int Duration() { // CheckOut.Subtract(CheckIn) = está me dizendo que vou pegar a diferença entre um instante e outro
            TimeSpan duration = CheckOut.Subtract(CheckIn); // TimeSpan = a duração
            return (int) duration.TotalDays; // me retorna a diferença em dias entre as duas datas
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut) { 
            CheckIn= checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyyy")}, check-outt: " +
                $"{CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }
    }
}
