using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;
using System;

namespace ShapeLibraryTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetArea_ValidRadius_CorrectArea()
        {
            // Arrange
            double radius = 3;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;

            // Act
            double actualArea = circle.GetArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 1e-10, "Площадь круга вычислена некорректно.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_NegativeRadius_ThrowsException()
        {
            // Arrange & Act
            Circle circle = new Circle(-5);

            // Assert - ожидается исключение
        }
    }
}

