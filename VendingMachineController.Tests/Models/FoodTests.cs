using System;
using Xunit;
using VendingMachineController.Models;

namespace VendingMachineController.Tests.Models
{
    public class FoodTests
    {
        [Fact]
        public void WeightWorks()
        {
            // Arrange
            int expectedWeight = 140;
            int actualWeight;
            Food actualDrink = new Food(4, "Cheese & ham sandwitch", 40, expectedWeight);

            // Act
            actualWeight = actualDrink.Weight;

            // Assert
            Assert.Equal(expectedWeight, actualWeight);
        }
    }
}
