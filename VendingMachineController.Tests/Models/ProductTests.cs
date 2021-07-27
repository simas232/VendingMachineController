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
            Toy actualDrink = new Toy(expectedId, "Fanta Orange", 5);

            // Act
            actualId = actualDrink.Id;

            // Assert
            Assert.Equal(expectedId, actualId);
        }
        [Fact]
        public void DrinkNameWorks()
        {
            // Arrange
            String expectedName = "Fanta Orange";
            String actualName;
            Drink actualDrink = new Drink(1, expectedName, 11);

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
            Drink actualDrink = new Drink(1, "Fanta Orange", expectedPrice);

            // Act
            actualPrice = actualDrink.PricePerUnit;

            // Assert
            Assert.Equal(expectedPrice, actualPrice);
        }
        [Fact]
        public void FoodIdWorks()
        {
            // Arrange
            int expectedId = 1;
            int actualId;
            Food actualToy = new Food(expectedId, "Croissant", 7);

            // Act
            actualId = actualToy.Id;

            // Assert
            Assert.Equal(expectedId, actualId);
        }
        [Fact]
        public void FoodNameWorks()
        {
            // Arrange
            String expectedName = "Croissant";
            String actualName;
            Food actualToy = new Food(1, expectedName, 7);

            // Act
            actualName = actualToy.Name;

            // Assert
            Assert.Equal(expectedName, actualName);
        }
        [Fact]
        public void FoodPriceWorks()
        {
            // Arrange
            int expectedPrice = 7;
            int actualPrice;
            Food actualToy = new Food(1, "Croissant", expectedPrice);

            // Act
            actualPrice = actualToy.PricePerUnit;

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
