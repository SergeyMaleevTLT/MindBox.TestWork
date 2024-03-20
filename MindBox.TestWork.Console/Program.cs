// See https://aka.ms/new-console-template for more information

using MindBox.TestWork;
using MindBox.TestWork.Console;
using MindBox.TestWork.Models;

Console.WriteLine("Hello, World!");

var rectangle = new Rectangle(new Point(0, 0), new Point(10, 0), new Point(10, 10));
var square = Figure.GetSquare(rectangle);

Console.WriteLine("площадь прямоугольника = " + square);
Console.ReadKey();