using MindBox.TestWork;
using MindBox.TestWork.Console;
using MindBox.TestWork.Models;

var rectangle = new Rectangle(new Point(0, 0), new Point(10, 0), new Point(10, 10));
var figure = new Figure(rectangle);
var square = figure.GetSquare();

Console.WriteLine($"площадь {figure} = " + square);

figure = new Figure(new []{ new Point(0,0), new Point(10,0), new Point(10,10), new Point(0,10)});
square = figure.GetSquare();

Console.WriteLine($"площадь: {figure} = " + square);


Console.ReadKey();
