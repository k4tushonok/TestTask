using System;

namespace ShapeLibrary
{
    /// <summary>
    /// Класс, представляющий прямоугольник.
    /// </summary>
    public class Rectangle : IShape
    {
        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        public double Length { get; }

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        public double Width { get; }

        /// <summary>
        /// Конструктор класса Rectangle.
        /// </summary>
        /// <param name="length">Длина. Должна быть положительной.</param>
        /// <param name="width">Ширина. Должна быть положительной.</param>
        public Rectangle(double length, double width)
        {
            if (length <= 0 || width <= 0)
                throw new ArgumentException("Длина и ширина должны быть положительными числами.");

            Length = length;
            Width = width;
        }

        /// <summary>
        /// Вычисляет площадь прямоугольника.
        /// </summary>
        /// <returns>Площадь прямоугольника.</returns>
        public double GetArea()
        {
            return Length * Width;
        }
    }
}

