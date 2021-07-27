using System;
using Xunit;
using VendingMachineController.Models;

namespace VendingMachineController.Tests.Models
{
    public class ToyTests
    {
        [Fact]
        public void WeightWorks()
        {
            // Arrange
            String expectedColor = "blue";
            String actualColor;
            Toy actualToy = new Toy(7, "Small figurine", 30, expectedColor);

            // Act
            actualColor = actualToy.Color;

            // Assert
            Assert.Equal(expectedColor, actualColor);
        }
    }
}
