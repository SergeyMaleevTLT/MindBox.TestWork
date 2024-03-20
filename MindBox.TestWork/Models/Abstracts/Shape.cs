namespace MindBox.TestWork.Models.Abstracts;

public abstract class Shape
{
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
    /// Возвращает площадь фигуры
    /// </summary>
    /// <returns></returns>
    internal abstract double GetSquare();

    private bool IsValid(Point[] points)
    {
        return points is not null && points.Length > 1 && points.Distinct().Count() == points.Length;
    }

    protected double GetLineLength(Point first, Point second)
    {
        return Math.Sqrt( Math.Pow( first.X - second.X, 2 ) + Math.Pow( first.Y - second.Y, 2 ) );
    }
}