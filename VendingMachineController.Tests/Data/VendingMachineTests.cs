using Xunit;
using VendingMachineController.Data;
using VendingMachineController.Models;
using System.Linq;
using System.Collections.Generic;

namespace VendingMachineController.Tests.Data
{
    public class VendingMachineTests
    {
        [Fact]
        public void Purchase_AllFineWorks()
        {
            // Arrange
            int expectedId = 5;
            int startSum = 20;
            int unitPrice = 7;
            int expectedChange = startSum - unitPrice;
            Product actualProduct;
            int actualChange;

            VendingMachine actualVendingMachine = new VendingMachine();
            actualVendingMachine.ProductArray.Add(new Drink(1, "Orange-flavored drink", 11, 330));
            actualVendingMachine.ProductArray.Add(new Drink(2, "Mineral water", 15, 500));
            actualVendingMachine.ProductArray.Add(new Drink(3, "Apple juice", 18, 250));
            actualVendingMachine.ProductArray.Add(new Food(4, "Cheese & ham sandwitch", 40, 140));
            actualVendingMachine.ProductArray.Add(new Food(expectedId, "Croissant", 7, 60));
            actualVendingMachine.ProductArray.Add(new Food(6, "Snack bar", 18, 30));
            actualVendingMachine.ProductArray.Add(new Toy(7, "Small figurine", 30, "blue"));
            actualVendingMachine.ProductArray.Add(new Toy(8, "Fidget spinner", 10, "red"));
            actualVendingMachine.ProductArray.Add(new Toy(9, "Whistle", 5, "yellow"));
            actualVendingMachine.InsertMoney(startSum);

            // Act
            actualProduct = actualVendingMachine.Purchase(expectedId);
            actualChange = actualVendingMachine.MoneyPool;

            // Assert
            Assert.Equal(expectedChange, actualChange);
            Assert.Equal(actualVendingMachine.ProductArray[4], actualProduct);
        }
        [Fact]
        public void Purchase_InsufficientMoneyWorks()
        {
            // Arrange
            int expectedId = 5;
            int startSum = 6;
            int unitPrice = 7;
            int expectedChange = startSum;
            Product expectedProduct = null;
            Product actualProduct;
            int actualChange;

            VendingMachine actualVendingMachine = new VendingMachine();
            actualVendingMachine.ProductArray.Add(new Drink(1, "Orange-flavored drink", 11, 330));
            actualVendingMachine.ProductArray.Add(new Drink(2, "Mineral water", 15, 500));
            actualVendingMachine.ProductArray.Add(new Drink(3, "Apple juice", 18, 250));
            actualVendingMachine.ProductArray.Add(new Food(4, "Cheese & ham sandwitch", 40, 140));
            actualVendingMachine.ProductArray.Add(new Food(expectedId, "Croissant", unitPrice, 60));
            actualVendingMachine.ProductArray.Add(new Food(6, "Snack bar", 18, 30));
            actualVendingMachine.ProductArray.Add(new Toy(7, "Small figurine", 30, "blue"));
            actualVendingMachine.ProductArray.Add(new Toy(8, "Fidget spinner", 10, "red"));
            actualVendingMachine.ProductArray.Add(new Toy(9, "Whistle", 5, "yellow"));
            // Starting sum should be 6
            actualVendingMachine.InsertMoney(5);
            actualVendingMachine.InsertMoney(1);

            // Act
            actualProduct = actualVendingMachine.Purchase(expectedId);
            actualChange = actualVendingMachine.MoneyPool;

            // Assert
            Assert.Equal(expectedChange, actualChange);
            Assert.Equal(expectedProduct, actualProduct);
        }
        [Fact]
        public void PurchaseNonExistentProductWorks()
        {
            // Arrange
            int expectedId = 99;
            int startSum = 100;
            int expectedChange = startSum;
            Product expectedProduct = null;
            Product actualProduct;
            int actualChange;

            VendingMachine actualVendingMachine = new VendingMachine();
            actualVendingMachine.ProductArray.Add(new Drink(1, "Orange-flavored drink", 11, 330));
            actualVendingMachine.ProductArray.Add(new Drink(2, "Mineral water", 15, 500));
            actualVendingMachine.ProductArray.Add(new Drink(3, "Apple juice", 18, 250));
            actualVendingMachine.ProductArray.Add(new Food(4, "Cheese & ham sandwitch", 40, 140));
            actualVendingMachine.ProductArray.Add(new Food(5, "Croissant", 7, 60));
            actualVendingMachine.ProductArray.Add(new Food(6, "Snack bar", 18, 30));
            actualVendingMachine.ProductArray.Add(new Toy(7, "Small figurine", 30, "blue"));
            actualVendingMachine.ProductArray.Add(new Toy(8, "Fidget spinner", 10, "red"));
            actualVendingMachine.ProductArray.Add(new Toy(9, "Whistle", 5, "yellow"));
            actualVendingMachine.InsertMoney(startSum);

            // Act
            actualProduct = actualVendingMachine.Purchase(expectedId);
            actualChange = actualVendingMachine.MoneyPool;

            // Assert
            Assert.Equal(expectedChange, actualChange);
            Assert.Equal(expectedProduct, actualProduct);
        }
        [Fact]
        public void AddMoney_GoodDenominatorsWorks()
        {
            // Arrange
            VendingMachine actualVendingMachine = new VendingMachine();
            int[] correctDenominators = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
            int expectedMoneySum = correctDenominators.Sum();

            // Act
            foreach (int denominator in correctDenominators)
            {
                actualVendingMachine.InsertMoney(denominator);
            }

            // Assert
            Assert.Equal(expectedMoneySum, actualVendingMachine.MoneyPool);
        }
        [Fact]
        public void AddMoney_BadDenominatorWorks()
        {
            // Arrange
            VendingMachine actualVendingMachine = new VendingMachine();
            int incorrectDenominator = 15;
            int expectedMoneySum = 50;

            actualVendingMachine.InsertMoney(expectedMoneySum);

            // Act
            actualVendingMachine.InsertMoney(incorrectDenominator);

            // Assert
            Assert.Equal(expectedMoneySum, actualVendingMachine.MoneyPool);
        }
        [Fact]
        public void EndTransaction_ReturnMoneyWorks()
        {
            // Arrange
            int expectedChange = 12;
            int actualChange = 0;
            Dictionary<int, int> actualMoneyDictionary;
            VendingMachine actualVendingMachine = new VendingMachine();
            actualVendingMachine.InsertMoney(10);
            actualVendingMachine.InsertMoney(1);
            actualVendingMachine.InsertMoney(1);

            // Act
            actualMoneyDictionary = actualVendingMachine.EndTransaction();
            foreach (var pair in actualMoneyDictionary)
            {
                actualChange += pair.Key * pair.Value;
            }

            // Assert
            Assert.Equal(expectedChange, actualChange);
        }
        [Fact]
        public void EndTransaction_MoneyPoolResetWorks()
        {
            // Arrange
            int[] moneyPool = { 10, 1, 1 };
            int expectedMoneyPool = 0;
            int actualMoneyPool;

            VendingMachine actualVendingMachine = new VendingMachine();
            actualVendingMachine.InsertMoney(moneyPool[0]);
            actualVendingMachine.InsertMoney(moneyPool[1]);
            actualVendingMachine.InsertMoney(moneyPool[2]);

            // Act
            actualVendingMachine.EndTransaction();
            actualMoneyPool = actualVendingMachine.MoneyPool;

            // Assert
            Assert.Equal(expectedMoneyPool, actualMoneyPool);
        }
    }
}
