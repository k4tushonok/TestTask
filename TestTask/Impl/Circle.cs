using System;

namespace ShapeLibrary
{
    /// <summary>
    /// Класс, представляющий круг.
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Конструктор класса Circle.
        /// </summary>
        /// <param name="radius">Радиус круга. Должен быть положительным.</param>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным числом.", nameof(radius));

            Radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь круга.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

