using System;
using ShapesLib.Core;

namespace ShapesLib
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Инициализирует экземпляр круга.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус круга не может быть <= 0.");

            Radius = radius;
        }

        /// <summary>
        /// Название фигуры.
        /// </summary>
        public string Name => GetType().Name;

        /// <summary>
        /// Площадь фигуры.
        /// </summary>
        public double Area => Math.PI * Math.Pow(Radius, 2);
    }
}
