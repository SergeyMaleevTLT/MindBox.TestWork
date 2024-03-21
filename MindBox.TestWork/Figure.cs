using MindBox.TestWork.Models;
using MindBox.TestWork.Models.Abstracts;
using MindBox.TestWork.Models.Impl;

namespace MindBox.TestWork;

//НЕМНОГО УСЛОЖНИЛ И РЕАЛИЗОВАЛ ЧЕРЕЗ КООРДИНАТЫ.

/// <summary>
/// Клиентский код, точка для доступа к получению площади любой фигуры
/// </summary>
public class Figure
{
    private Shape _shape;

    /// <summary>
    /// Фигура описаная конкретной формой (т.к. круг, квадрат, треугольник и т.д.)
    /// </summary>
    /// <param name="shape"></param>
    public Figure(Shape shape)
    {
        _shape = shape;
    }

    /// <summary>
    /// Фигура описаная координатами, форма подберется системно
    /// 2 координаты - круг, 3 - треугольник, более - многоугольник
    /// </summary>
    /// <param name="points">Координаты</param>
    public Figure(Point[] points) : this(points, x => 
        x.Length switch 
        {
            2 => new Circle(x[0], x[1]), 
            3 => new Triangle(x[0], x[1], x[2]), 
            _ => new Polygon(x)
        }) {}

    /// <summary>
    /// Фигура описаная координатами, с пользовательским вычислителем формы фигуры
    /// </summary>
    /// <param name="points">Координаты</param>
    /// <param name="definitionShape">пользовательский вычислитель формы фигуры по координатам</param>
    public Figure(Point[] points, Func<Point[], Shape> definitionShape)
    {
        if (points is null || points.Length < 2)
        {
            throw new ArgumentException("Points error");
        }

        _shape = definitionShape(points);
    }

    /// <summary>
    /// Возвращает площадь фигуры
    /// </summary>
    /// <returns></returns>
    public double GetSquare()
    {
        return _shape.GetSquare();
    }

    /// <summary>
    /// Является прямоугольным треугольником
    /// </summary>
    /// <returns></returns>
    public bool IsStraightTriangle()
    {
        if (!(_shape is Triangle triangle))
        {
            return false;
        }

        return triangle.IsStraight();
    }

    public static double GetSquare(Shape shape)
    {
        return shape.GetSquare();
    }

    public override string ToString()
    {
        return (_shape?.ToString() ?? base.ToString())!;
    }
}
