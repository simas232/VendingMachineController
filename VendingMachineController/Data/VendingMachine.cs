using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachineController.Models;

namespace VendingMachineController.Data
{
    public class VendingMachine : IVending
    {
        // Fields
        private readonly int[] coinTypes = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
        private List<Product> productArray = new List<Product>();

        // Properties
        public int[] CoinTypes
        {
            get
            {
                return coinTypes;
            }
        }
        public List<Product> ProductArray
        {
            get
            {
                return productArray;
            }
            set
            {
                productArray = value;
            }
        }
        public int MoneyPool { get; private set; }

        // Methods
        public Product Purchase(int productId)
        {
            foreach (Product productItem in ProductArray)
            {
                if (productItem.Id.Equals(productId))
                {
                    if (MoneyPool >= productItem.PricePerUnit)
                    {
                        MoneyPool -= productItem.PricePerUnit;
                        return productItem;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
        }
        public String ShowAll()
        {
            StringBuilder productInfo = new StringBuilder();
            productInfo.Append("*** Available Products ***\n");
            foreach (Product productItem in ProductArray)
            {
                productInfo.Append(productItem.Examine());
            }
            productInfo.Append("**************************\n");
            return productInfo.ToString();
        }
        public void InsertMoney(int moneyToAdd)
        {
            if (CoinTypes.Contains(moneyToAdd))
            {
                MoneyPool += moneyToAdd;
            }
            else
            {
                Console.WriteLine("Money to Be Added Is Not A Valid Denominator!");
            }
        }
        public Dictionary<int, int> EndTransaction()
        {
            int remainingMoney = MoneyPool;
            MoneyPool = 0;

            Dictionary<int, int> moneyDictionary = new Dictionary<int, int>();
            foreach (int coinType in CoinTypes)
            {
                moneyDictionary.Add(coinType, remainingMoney / coinType);
                remainingMoney %= coinType;
            }
            return moneyDictionary;
        }
    }
}
