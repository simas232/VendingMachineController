using System;
using System.Collections.Generic;

namespace VendingMachineController.Models
{
    interface IVending
    {
        public Product Purchase(int productId);
        public String ShowAll();
        public void InsertMoney(int moneyToAdd);
        public Dictionary<int, int> EndTransaction();
    }
}
