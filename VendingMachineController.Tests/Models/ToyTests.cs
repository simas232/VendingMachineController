using System;
using Xunit;
using VendingMachineController.Models;

namespace VendingMachineController.Tests.Models
{
    public class ToyTests
    {
        [Fact]
        public void IdWorks()
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
        public void NameWorks()
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
        public void PriceWorks()
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
