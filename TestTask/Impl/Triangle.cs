using System;

namespace ShapeLibrary
{
    /// <summary>
    /// Класс, представляющий треугольник.
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Сторона a треугольника.
        /// </summary>
        public double SideA { get; }

        /// <summary>
        /// Сторона b треугольника.
        /// </summary>
        public double SideB { get; }

        /// <summary>
        /// Сторона c треугольника.
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// Конструктор класса Triangle.
        /// </summary>
        /// <param name="sideA">Сторона a. Должна быть положительной.</param>
        /// <param name="sideB">Сторона b. Должна быть положительной.</param>
        /// <param name="sideC">Сторона c. Должна быть положительной.</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            // Проверка на положительность сторон
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Все стороны треугольника должны быть положительными числами.");

            // Проверка треугольного неравенства
            if (sideA + sideB <= sideC ||
                sideA + sideC <= sideB ||
                sideB + sideC <= sideA)
                throw new ArgumentException("Стороны треугольника не удовлетворяют неравенству треугольника.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Вычисляет площадь треугольника с использованием формулы Герона.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public double GetArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>True, если треугольник прямоугольный, иначе - False.</returns>
        public bool IsRightAngled()
        {
            double a = SideA;
            double b = SideB;
            double c = SideC;

            double hypotenuse, side1, side2;

            if (a >= b && a >= c)
            {
                hypotenuse = a;
                side1 = b;
                side2 = c;
            }
            else if (b >= a && b >= c)
            {
                hypotenuse = b;
                side1 = a;
                side2 = c;
            }
            else
            {
                hypotenuse = c;
                side1 = a;
                side2 = b;
            }

            const double tolerance = 1e-10;
            return Math.Abs(side1 * side1 + side2 * side2 - hypotenuse * hypotenuse) < tolerance;
        }
    }
}


