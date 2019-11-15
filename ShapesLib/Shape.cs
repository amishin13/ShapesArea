using ShapesLib.Core;

namespace ShapesLib
{
    /// <summary>
    /// Любая фигура.
    /// </summary>
    public class Shape : IShape
    {
        /// <summary>
        /// Фигура.
        /// </summary>
        private IShape shape;

        /// <summary>
        /// Инициализирует экземпляр любой фигуры.
        /// </summary>
        /// <param name="shape">Фигура.</param>
        public Shape(IShape shape)
        {
            this.shape = shape;
        }

        /// <summary>
        /// Название фигуры.
        /// </summary>
        public string Name => shape.Name;

        /// <summary>
        /// Площадь фигуры.
        /// </summary>
        public double Area => shape.Area;
    }
}
