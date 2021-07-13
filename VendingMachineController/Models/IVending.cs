using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController.Models
{
    interface IVending
    {
        public Product Purchase(int productId);
        public void ShowAll();
        public void InsertMoney(int moneyToAdd);
        public int EndTransaction();
    }
}
