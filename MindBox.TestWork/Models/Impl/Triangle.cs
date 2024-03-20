using MindBox.TestWork.Models.Abstracts;

namespace MindBox.TestWork.Models.Impl;

public class Triangle : Shape
{
    public Triangle(Point first, Point second, Point third) : base(new []{ first, second, third }){}

    internal override double GetSquare()
    {
        var lines = GetLineLength();

        var p = (lines.firstLine + lines.secondLine + lines.thirdLine) / 2;
        return Math.Sqrt(p * (p - lines.firstLine) * (p - lines.secondLine) * (p - lines.thirdLine));
    }

    /// <summary>
    /// Является прямоугольным
    /// </summary>
    /// <returns></returns>
    public bool IsStraight()
    {
        var lines = GetLineLength();

        bool isStraight = (lines.firstLine == Math.Sqrt(Math.Pow(lines.secondLine, 2) + Math.Pow(lines.thirdLine, 2))
                           || lines.secondLine == Math.Sqrt(Math.Pow(lines.firstLine, 2) + Math.Pow(lines.thirdLine, 2))
                           || lines.thirdLine == Math.Sqrt(Math.Pow(lines.firstLine, 2) + Math.Pow(lines.secondLine, 2)));

        return isStraight;
    }

    private (double firstLine, double secondLine, double thirdLine) GetLineLength()
    {
        var firstLine = base.GetLineLength(Points[0], Points[1]);
        var secondLine = base.GetLineLength(Points[1], Points[2]);
        var thirdLine = base.GetLineLength(Points[2], Points[0]);

        return (firstLine, secondLine, thirdLine);
    }

    public override string ToString()
    {
        return "Треугольник, описанный вершинами в координатах: " +
               $"x1-{Points[0].X}, y1-{Points[0].Y}/x2-{Points[1].X}, y2-{Points[1].Y}/x3-{Points[2].X}, y3-{Points[2].Y}";
    }
}