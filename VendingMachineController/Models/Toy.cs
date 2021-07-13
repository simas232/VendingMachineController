using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController.Models
{
    public class Toy : Product
    {
        // Constructors
        public Toy(int id, String name, int pricePerUnit) : base(id, name, pricePerUnit)
        {
            Name = name;
            PricePerUnit = pricePerUnit;
        }

        // Methods
        public override String Examine()
        {
            return $"Toy Id: {Id} - Name (price per unit): {Name} ({PricePerUnit} kr)\n";
        }
        public override String Use()
        {
            return "Use only under the supervision of adults!\n";
        }
    }
}
