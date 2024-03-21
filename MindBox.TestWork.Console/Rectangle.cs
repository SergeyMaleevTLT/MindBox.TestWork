using MindBox.TestWork.Models;
using MindBox.TestWork.Models.Abstracts;

namespace MindBox.TestWork.Console;

/// <summary>
/// Прямоугольник (Пример как легко добавить новую фигуру)
/// </summary>
public class Rectangle : Shape
{

    // second   ------------ third
    //         |           |
    //         |           |
    // first   |           |
    //         ------------- эту точку вычисляем самостоятельно при желании
    public Rectangle(Point first, Point second, Point third) : base(new []{first, second, third}) {}

    protected override bool IsValid(Point[] points)
    {
        if (!base.IsValid(points)) return false;

        return (points[0].X == points[1].X || points[0].Y == points[1].Y)
               && (points[1].X == points[2].X || points[1].Y == points[2].Y);
    }

    protected override double GetShapeSquare()
    {
        var firstLine = base.GetLineLength(Points[0], Points[1]);
        var secondLine = base.GetLineLength(Points[1], Points[2]);

        return firstLine * secondLine;
    }

    public override string ToString()
    {
        return "Прямоугольник, описанный вершинами в координатах: " +
               $"x1-{Points[0].X}, y1-{Points[0].Y}/x2-{Points[1].X}, y2-{Points[1].Y}/x3-{Points[2].X}, y3-{Points[2].Y}/x4-{Points[1].Y}, y4-{Points[1].X}";
    }
}