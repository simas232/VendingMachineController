using System;
using Xunit;
using VendingMachineController.Models;

namespace VendingMachineController.Tests.Models
{
    public class ProductTests
    {
        [Fact]
        public void DrinkIdWorks()
        {
            // Arrange
            int expectedId = 1;
            int actualId;
            Drink actualDrink = new Drink(expectedId, "Orange-flavored drink", 11, 330);

            // Act
            actualId = actualDrink.Id;

            // Assert
            Assert.Equal(expectedId, actualId);
        }
        [Fact]
        public void DrinkNameWorks()
        {
            // Arrange
            String expectedName = "Orange-flavored drink";
            String actualName;
            Drink actualDrink = new Drink(1, expectedName, 11, 330);

            // Act
            actualName = actualDrink.Name;

            // Assert
            Assert.Equal(expectedName, actualName);
        }
        [Fact]
        public void DrinkPriceWorks()
        {
            // Arrange
            int expectedPrice = 11;
            int actualPrice;
            Drink actualDrink = new Drink(1, "Orange-flavored drink", expectedPrice, 330);

            // Act
            actualPrice = actualDrink.PricePerUnit;

            // Assert
            Assert.Equal(expectedPrice, actualPrice);
        }
        [Fact]
        public void FoodIdWorks()
        {
            // Arrange
            int expectedId = 4;
            int actualId;
            Food actualFood = new Food(expectedId, "Cheese & ham sandwitch", 40, 140);

            // Act
            actualId = actualFood.Id;

            // Assert
            Assert.Equal(expectedId, actualId);
        }
        [Fact]
        public void FoodNameWorks()
        {
            // Arrange
            String expectedName = "Cheese & ham sandwitch";
            String actualName;
            Food actualFood = new Food(4, expectedName, 40, 140);

            // Act
            actualName = actualFood.Name;

            // Assert
            Assert.Equal(expectedName, actualName);
        }
        [Fact]
        public void FoodPriceWorks()
        {
            // Arrange
            int expectedPrice = 40;
            int actualPrice;
            Food actualFood = new Food(4, "Cheese & ham sandwitch", expectedPrice, 140);

            // Act
            actualPrice = actualFood.PricePerUnit;

            // Assert
            Assert.Equal(expectedPrice, actualPrice);
        }
        [Fact]
        public void ToyIdWorks()
        {
            // Arrange
            int expectedId = 1;
            int actualId;
            Toy actualToy = new Toy(expectedId, "Whistle", 5);

            // Act
            actualId = actualToy.Id;

            // Assert
            Assert.Equal(expectedId, actualId);
        }
        [Fact]
        public void ToyNameWorks()
        {
            // Arrange
            String expectedName = "Whistle";
            String actualName;
            Toy actualToy = new Toy(1, expectedName, 5);

            // Act
            actualName = actualToy.Name;

            // Assert
            Assert.Equal(expectedName, actualName);
        }
        [Fact]
        public void ToyPriceWorks()
        {
            // Arrange
            int expectedPrice = 5;
            int actualPrice;
            Toy actualToy = new Toy(1, "Whistle", expectedPrice);

            // Act
            actualPrice = actualToy.PricePerUnit;

            // Assert
            Assert.Equal(expectedPrice, actualPrice);
        }
    }
}
