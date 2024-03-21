using MindBox.TestWork.Models.Abstracts;

namespace MindBox.TestWork.Models.Impl;

/// <summary>
/// Многоугольник
/// </summary>
public class Polygon : Shape
{

    public Polygon(Point[] points) : base(points) { }

    protected override double GetShapeSquare()
    {
        //https://csharp.webdelphi.ru/algoritm-vychisleniya-ploshhadi-mnogougolnika/ - формула вычисления 
        double sum = 0;

        for (int i = 0; i < Points.Length - 1; i++)
        {
            sum += 0.5 * Math.Abs((Points[i].X + Points[i + 1].X) * (Points[i].Y - Points[i + 1].Y));
        }

        return sum;
    }

    public override string ToString()
    {
        return "Многоугольник, описанный координатами:" + String.Join("/", Points.Select(x => $"X{x.X}Y{x.Y}"));
    }
}