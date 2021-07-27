using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController.Models
{
    public class Drink : Product
    {
        // Properties
        public int Volume { get; set; }

        // Constructors
        public Drink(int id, String name, int pricePerUnit, int volume) : base(id, name, pricePerUnit)
        {
            Name = name;
            PricePerUnit = pricePerUnit;
            Volume = volume;
        }

        // Methods
        public override String Examine()
        {
            return $"Drink Id: {Id} - Name (price per unit; volume (mL)): {Name} ({PricePerUnit} kr; {Volume}\n";
        }
        public override String Use()
        {
            return "Disinfect or wash your hands and read the instructions on the package before opening!\n";
        }
    }
}
