namespace ShapesLib.Core
{
    /// <summary>
    /// Интерфейс фигуры.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Название фигуры.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Площадь фигуры.
        /// </summary>
        double Area { get; }
    }
}
