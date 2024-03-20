using System;
using MindBox.TestWork.Models;
using MindBox.TestWork.Models.Impl;
using Xunit;

namespace MindBox.TestWork.UnitTests;

public class FigureUnitTest
{
    [Fact]
    public void GetSquare_Circle_ReturnTrue()
    {
        //Arrange
        var circle = new Circle(new Point(0, 0), new Point(5, 0));

        //Act
        var square = Figure.GetSquare(circle);

        //Assert
        Assert.Equal(79,Math.Round(square));
    }
    
    [Fact]
    public void GetSquare_Triangle_ReturnTrue()
    {
        //Arrange
        var triangle = new Triangle(new Point(0, 0), new Point(10, 0), new Point(10, 10));

        //Act
        var square = Figure.GetSquare(triangle);

        //Assert
        Assert.Equal(50,Math.Round(square));
    }

    [Fact]
    public void IsValid_Ctr_Circle_ReturnTrue()
    {
        //Arrange
        //Act
        var circle = new Circle(new Point(0, 0), new Point(10, 0));

        //Assert
        Assert.NotNull(circle);
    }

    [Fact]
    public void NotValid_Ctr_Circle()
    {
        //Arrange
        //Act
        //Assert
        Assert.Throws<ArgumentException>(() => new Circle(new Point(0, 0), new Point(0, 0)));
    }

    [Fact]
    public void IsValid_Ctr_Triangle_ReturnTrue()
    {
        //Arrange
        //Act
        var circle = new Triangle(new Point(0, 0), new Point(10, 0), new Point(11, 25));

        //Assert
        Assert.NotNull(circle);
    }
    
    [Fact]
    public void NotValid_Ctr_Triangle()
    {
        //Arrange
        //Act
        //Assert
        Assert.Throws<ArgumentException>(() => new Triangle(new Point(0, 0), new Point(0, 0), new Point(10, 10)));
    }

    [Fact]
    public void IsStraightTriangle_NotStraight_ReturnTrue()
    {
        //Arrange
        var triangle = new Triangle(new Point(0, 0), new Point(10, 0), new Point(10, 10));

        //Act
        var isStraight = triangle.IsStraight();

        //Assert
        Assert.True(isStraight);
    }

    [Fact]
    public void IsStraightTriangle_NotStraight_ReturnFalse()
    {
        //Arrange
        var triangle = new Triangle(new Point(0, 0), new Point(10, 4), new Point(10, 14));

        //Act
        var isStraight = triangle.IsStraight();

        //Assert
        Assert.False(isStraight);
    }
}