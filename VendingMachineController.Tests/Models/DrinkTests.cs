using System;
using Xunit;
using VendingMachineController.Models;

namespace VendingMachineController.Tests.Models
{
    public class DrinkTests
    {
        [Fact]
        public void IdWorks()
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
        public void NameWorks()
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
        public void PriceWorks()
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
    }
}
