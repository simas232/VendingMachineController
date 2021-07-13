using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController.Models
{
    public class Drink : Product
    {
        // Constructors
        public Drink(int id, String name, int pricePerUnit) : base(id, name, pricePerUnit)
        {
            Name = name;
            PricePerUnit = pricePerUnit;
        }

        // Methods
        public override String Examine()
        {
            return $"Drink Id: {Id} - Name (price per unit): {Name} ({PricePerUnit} kr)\n";
        }
        public override String Use()
        {
            return "Disinfect or wash your hands and read the instructions on the package before opening!\n";
        }
    }
}
