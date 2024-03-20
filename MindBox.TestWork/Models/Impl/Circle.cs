using MindBox.TestWork.Models.Abstracts;

namespace MindBox.TestWork.Models.Impl;

public class Circle : Shape
{
    public Circle(Point center, Point circleLine) : base(new[] {center, circleLine}) {}

    protected override double GetShapeSquare()
    {
        return Math.PI * Math.Pow(GetRadius(), 2);
    }

    private double GetRadius()
    {
        return base.GetLineLength(Points[0], Points[1]);
    }

    public override string ToString()
    {
        return $"Круг, описанный радиусом в координатах: x1-{Points[0].X}, y1-{Points[0].Y}/x2-{Points[1].X}, y2-{Points[1].Y}";
    }
}