using System;
using Aula124_Enum.Entities.Enums; // para enchergar o meu enum preciso colocar isso ai
namespace Aula124_Enum.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
