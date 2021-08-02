using System;
using System.Collections.Generic;
using VendingMachineController.Data;
using VendingMachineController.Models;

namespace VendingMachineController
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vMachine = new VendingMachine();
            vMachine.ProductArray.Add(new Drink(1, "Orange-flavored drink", 11, 330));
            vMachine.ProductArray.Add(new Drink(2, "Mineral water", 15, 500));
            vMachine.ProductArray.Add(new Drink(3, "Apple juice", 18, 250));
            vMachine.ProductArray.Add(new Food(4, "Cheese & ham sandwitch", 40, 140));
            vMachine.ProductArray.Add(new Food(5, "Croissant", 7, 60));
            vMachine.ProductArray.Add(new Food(6, "Snack bar", 18, 30));
            vMachine.ProductArray.Add(new Toy(7, "Small figurine", 30, "blue"));
            vMachine.ProductArray.Add(new Toy(8, "Fidget spinner", 10, "red"));
            vMachine.ProductArray.Add(new Toy(9, "Whistle", 5, "yellow"));

            char userSelection;
            Dictionary<int, int> moneyDictionary;
            do
            {
                Console.Clear();
                Console.WriteLine(vMachine.ShowAll());
                Console.WriteLine($"Money Balance: {vMachine.MoneyPool} kr");
                Console.WriteLine("Press 1-9 to Buy An Item, R to Insert Money or Q to Finish Purchases");
                userSelection = Convert.ToChar(Console.ReadLine());

                switch (userSelection)
                {
                    case '1':
                        BuyItemFromVendingMachine(vMachine, 1);
                        break;
                    case '2':
                        BuyItemFromVendingMachine(vMachine, 2);
                        break;
                    case '3':
                        BuyItemFromVendingMachine(vMachine, 3);
                        break;
                    case '4':
                        BuyItemFromVendingMachine(vMachine, 4);
                        break;
                    case '5':
                        BuyItemFromVendingMachine(vMachine, 5);
                        break;
                    case '6':
                        BuyItemFromVendingMachine(vMachine, 6);
                        break;
                    case '7':
                        BuyItemFromVendingMachine(vMachine, 7);
                        break;
                    case '8':
                        BuyItemFromVendingMachine(vMachine, 8);
                        break;
                    case '9':
                        BuyItemFromVendingMachine(vMachine, 9);
                        break;
                    case 'R':
                        Console.WriteLine("Enter The Money Sum to Be Added (1000, 500, 100, 50, 20, 10, 5 or 1)");
                        vMachine.InsertMoney(Convert.ToInt32(Console.ReadLine()));
                        continue;
                    case 'Q':
                        Console.WriteLine($"Returned {vMachine.MoneyPool} kr");
                        moneyDictionary = vMachine.EndTransaction();
                        foreach (var pair in moneyDictionary)
                        {
                            Console.WriteLine($"{pair.Key} banknotes/coins: {pair.Value}");
                        }
                        return;
                }
                Console.WriteLine("Press <Spacebar> to Continue... ");
                while (Console.ReadKey().Key != ConsoleKey.Spacebar) { }
            } while (true);
        }

        public static void BuyItemFromVendingMachine(VendingMachine vMachine, int itemId)
        {
            Product boughtProduct;
            boughtProduct = vMachine.Purchase(itemId);
            if (boughtProduct == null)
            {
                Console.WriteLine("Not Enough Money! Insert More Money And Try Again.");
            }
            else
            {
                Console.WriteLine($"You Bought {vMachine.ProductArray[itemId-1].Name}");
                Console.WriteLine(boughtProduct);
            }
        }
    }
}
