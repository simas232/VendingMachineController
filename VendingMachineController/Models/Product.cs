using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController.Models
{
    public abstract class Product
    {
        // Fields
        public readonly int id;

        // Properties
        public int Id
        {
            get
            {
                return id;
            }
        }
        public String Name { get; set; }
        public int PricePerUnit { get; set; }

        // Constructors
        public Product(int id, String name, int pricePerUnit)
        {
            this.id = id;
            Name = name;
            PricePerUnit = pricePerUnit;
        }

        // Methods
        public abstract String Examine();
        public abstract String Use();
    }
}
