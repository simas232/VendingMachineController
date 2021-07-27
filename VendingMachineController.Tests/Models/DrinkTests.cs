using System;
using Xunit;
using VendingMachineController.Models;

namespace VendingMachineController.Tests.Models
{
    public class DrinkTests
    {
        [Fact]
        public void VolumeWorks()
        {
            // Arrange
            int expectedVolume = 330;
            int actualVolume;
            Drink actualDrink = new Drink(1, "Orange-flavored drink", 11, expectedVolume);

            // Act
            actualVolume = actualDrink.Volume;

            // Assert
            Assert.Equal(expectedVolume, actualVolume);
        }
    }
}
