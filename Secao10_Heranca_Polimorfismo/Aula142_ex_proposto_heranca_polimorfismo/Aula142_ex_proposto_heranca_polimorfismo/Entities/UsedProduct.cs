
using System.Globalization;

namespace Aula142_ex_proposto_heranca_polimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { 
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price  )
        {
            ManufactureDate = manufactureDate;    
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)}" +
                $" (Manufacture date: {ManufactureDate})";
        }

    }
}
