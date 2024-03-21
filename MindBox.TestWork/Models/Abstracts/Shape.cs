namespace MindBox.TestWork.Models.Abstracts;

/// <summary>
/// Объект, описывающий абстрактную форму, выраженную множеством координат на плоскости.
/// </summary>
public abstract class Shape
{
    /// <summary>
    /// Координаты, описывающие форму
    /// </summary>
    protected readonly Point[] Points;

    protected Shape(Point[] points)
    {
        if (!IsValid(points))
        {
            throw new ArgumentException("Points error");
        }

        Points = points;
    }

    /// <summary>
    /// Возвращает площадь реальной формы на плоскости
    /// </summary>
    /// <returns></returns>
    protected abstract double GetShapeSquare();

    /// <summary>
    /// Возвращает площадь формы,
    /// модификатор доступа ограничен на случай расширения в сторонней библиотеке, все операции с формами через класс Figure
    /// </summary>
    /// <returns></returns>
    internal double GetSquare()
    {
        return GetShapeSquare();
    }

    /// <summary>
    /// Проверка координат на валидность
    /// </summary>
    /// <param name="points">Координаты</param>
    /// <returns></returns>
    protected virtual bool IsValid(Point[] points)
    {
        return points is not null && points.Length > 1 && points.Distinct().Count() == points.Length;
    }

    /// <summary>
    /// Возращает растояние между координатами
    /// </summary>
    /// <param name="first">Первая координата</param>
    /// <param name="second">Вторая координата</param>
    /// <returns></returns>
    protected double GetLineLength(Point first, Point second)
    {
        return Math.Sqrt( Math.Pow( first.X - second.X, 2 ) + Math.Pow( first.Y - second.Y, 2 ) );
    }
}