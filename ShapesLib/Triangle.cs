using System;
using ShapesLib.Core;

namespace ShapesLib
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Сторона 1 (длина).
        /// </summary>
        public double Side1 { get; }

        /// <summary>
        /// Сторона 2 (длина).
        /// </summary>
        public double Side2 { get; }

        /// <summary>
        /// Сторона 3 (длина).
        /// </summary>
        public double Side3 { get; }

        /// <summary>
        /// Инициализирует экземпляр треугольника.
        /// </summary>
        /// <param name="side1">Сторона 1.</param>
        /// <param name="side2">Сторона 2.</param>
        /// <param name="side3">Сторона 3.</param>
        public Triangle(double side1, double side2, double side3)
        {
            if ((side1 <= 0) || (side2 <= 0) || (side3 <= 0))
                throw new ArgumentException("Длина всех сторон треугольника должна быть > 0.");

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        /// <summary>
        /// Название фигуры.
        /// </summary>
        public string Name => GetType().Name;

        /// <summary>
        /// Площадь фигуры.
        /// </summary>
        public double Area
        {
            get
            {
                // Формула Герона
                double halfP = (Side1 + Side2 + Side3) / 2;
                return Math.Sqrt(halfP * (halfP - Side1) * (halfP - Side2) * (halfP - Side3));
            }
        }

        /// <summary>
        /// Правильный треугольник.
        /// </summary>
        public bool IsRight
        {
            get
            {
                return CheckPythagoreanTheorem(Side1, Side2, Side3)
                    || CheckPythagoreanTheorem(Side3, Side1, Side2)
                    || CheckPythagoreanTheorem(Side3, Side2, Side1);
            }
        }
        
        /// <summary>
        /// Проверяет теорему Пифагора.
        /// </summary>
        /// <param name="cathet1">Катет 1.</param>
        /// <param name="cathet2">Катет 2.</param>
        /// <param name="hypotenuse">Гипотенуза.</param>
        /// <returns>true, если выполняется условие теоремы Пифагора.</returns>
        private static bool CheckPythagoreanTheorem(double cathet1, double cathet2, double hypotenuse)
        {
            return Math.Pow(hypotenuse, 2) == Math.Pow(cathet1, 2) + Math.Pow(cathet2, 2);
        }

    }
}
