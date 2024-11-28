using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;
using System;

namespace ShapeLibraryTests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void GetArea_ValidDimensions_CorrectArea()
        {
            // Arrange
            double length = 5;
            double width = 4;
            Rectangle rectangle = new Rectangle(length, width);
            double expectedArea = 20;

            // Act
            double actualArea = rectangle.GetArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 1e-10, "Площадь прямоугольника вычислена некорректно.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_NegativeDimensions_ThrowsException()
        {
            // Arrange & Act
            Rectangle rectangle = new Rectangle(-5, 4);

            // Assert - ожидается исключение
        }
    }
}

