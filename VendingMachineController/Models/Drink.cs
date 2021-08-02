using System;

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
            return $"Id: {Id} - Name: {Name} ({PricePerUnit} kr; {Volume} mL)\n";
        }
        public override String Use()
        {
            return "Disinfect or wash your hands and read the instructions on the package before opening!\n";
        }
    }
}
