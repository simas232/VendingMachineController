using System;

namespace VendingMachineController.Models
{
    public class Toy : Product
    {
        // Properties
        public String Color { get; set; }

        // Constructors
        public Toy(int id, String name, int pricePerUnit, String color) : base(id, name, pricePerUnit)
        {
            Name = name;
            PricePerUnit = pricePerUnit;
            Color = color;
        }

        // Methods
        public override String Examine()
        {
            return $"Id: {Id} - Name: {Name} ({PricePerUnit} kr; {Color})\n";
        }
        public override String Use()
        {
            return "Use only under the supervision of adults!\n";
        }
    }
}
