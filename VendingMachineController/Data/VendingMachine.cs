﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachineController.Models;

namespace VendingMachineController.Data
{
    public class VendingMachine : IVending
    {
        // Fields
        private readonly int[] coinTypes = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
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
        public int MoneyPool { get; set; }

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
        public int EndTransaction()
        {
            int moneyToReturn = MoneyPool;
            MoneyPool = 0;
            return moneyToReturn;
        }
    }
}
