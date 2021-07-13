using System;
using VendingMachineController.Data;
using VendingMachineController.Models;

namespace VendingMachineController
{
    class Program
    {
        static void Main(string[] args)
        {

            VendingMachine vMachine = new VendingMachine();
            vMachine.ProductArray.Add(new Drink(1, "Fanta Orange", 11));
            vMachine.ProductArray.Add(new Drink(2, "Mineral water", 15));
            vMachine.ProductArray.Add(new Drink(3, "Plum juice", 24));
            vMachine.ProductArray.Add(new Food(4, "Cheese & ham sandwitch", 40));
            vMachine.ProductArray.Add(new Food(5, "Croissant", 7));
            vMachine.ProductArray.Add(new Food(6, "Snack bar", 18));
            vMachine.ProductArray.Add(new Toy(7, "Doddo figurine", 30));
            vMachine.ProductArray.Add(new Toy(8, "Fidget spinner", 10));
            vMachine.ProductArray.Add(new Toy(9, "Whistle", 5));

            vMachine.ShowAll();

            int userSelection;
            do
            {
                Console.Clear();
                Console.WriteLine();
                userSelection = Convert.ToInt32(Console.ReadLine());

            } while (userSelection != 0);

            //Console.WriteLine("Hello World!");
        }
    }
}
