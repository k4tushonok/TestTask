using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;
using System;

namespace ShapeLibraryTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetArea_ValidSides_CorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double expectedArea = 6; // Для треугольника 3-4-5 площадь = 6

            // Act
            double actualArea = triangle.GetArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 1e-10, "Площадь треугольника вычислена некорректно.");
        }

        [TestMethod]
        public void IsRightAngled_RightAngledTriangle_ReturnsTrue()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            bool isRight = triangle.IsRightAngled();

            // Assert
            Assert.IsTrue(isRight, "Треугольник должен быть прямоугольным.");
        }

        [TestMethod]
        public void IsRightAngled_NonRightAngledTriangle_ReturnsFalse()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 3, 3);

            // Act
            bool isRight = triangle.IsRightAngled();

            // Assert
            Assert.IsFalse(isRight, "Треугольник не должен быть прямоугольным.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_InvalidSides_ThrowsException()
        {

            // Arrange & Act
            Triangle triangle = new Triangle(1, 2, 3); // Не образует треугольник

            // Assert - ожидается исключение
        }
    }
}

