using System;
using Xunit;
using VendingMachineController.Models;

namespace VendingMachineController.Tests.Models
{
    public class FoodTests
    {
        [Fact]
        public void IdWorks()
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
        public void NameWorks()
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
        public void PriceWorks()
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
    }
}
