using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController.Models
{
    public class Food : Product
    {
        // Properties
        public int Weight { get; set; }

        // Constructors
        public Food(int id, String name, int pricePerUnit, int weight) : base(id, name, pricePerUnit)
        {
            Name = name;
            PricePerUnit = pricePerUnit;
            Weight = weight;
        }

        // Methods
        public override String Examine()
        {
            return $"Food Id: {Id} - Name (price per unit; weight): {Name} ({PricePerUnit} kr; {Weight}g)\n";
        }
        public override String Use()
        {
            return "Use only under the supervision of adults!\n";
        }
    }
}
