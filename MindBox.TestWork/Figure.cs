using System.Collections.Generic;
using MindBox.TestWork.Models.Abstracts;

namespace MindBox.TestWork;

//Напишите на C# библиотеку для поставки внешним клиентам,
//которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. -
//todo: НЕ СОВСЕМ ПОНЯТНО!!! ЕСЛИ ДАТЬ ПОЛЬЗОВАТЕЛЮ САМОСТОЯТЕЛЬНО НАЗНАЧАТЬ ДЛИНЫ СТОРОН, ТРЕУГОЛЬНИК ЛИБО НЕ ЗАМКНЕТСЯ ЛИБО БУДЕТ НЕВАЛИДНЫЙ
//todo: КАК ВАРИАНТ ДВЕ СТОРОНЫ НАЗНАЧАТЬ 3 ВЫЧИСЛЯТЬ, ИЛИ ПРЕДПОЛОЖИТЬ ЧТО ВАЛИДАЦИЯ ВЫШЕ, РЕАЛИЗОВАЛ ЧЕРЕЗ ТОЧКИ.

/// <summary>
/// Клиентский код, точка для доступа к получению площади любой фигуры
/// </summary>
public class Figure
{
    public static double GetSquare(Shape shape)
    {
        return shape.GetSquare();
    }
}


/* на чистом SQL

 SELECT P."Name", C."Name"
 FROM Products P
 LEFT JOIN ProductCategories PC
 ON P.Id = PC.ProductId
 LEFT JOIN Categories C
 ON PC.CategoryId = C.Id;

*/



/* EF */
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Category> Categories { get; set; }

}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public virtual ICollection<Product> Products { get; set; }
}

/*builder.Entity<Product>()
    .HasMany(c => c.Categories)
    .WithMany(s => s.Products)
    .UsingEntity<Dictionary<string, object>>("ProductCategory",
        r => r.HasOne<Category>().WithMany().HasForeignKey("CategoryId"),
        l => l.HasOne<Product>().WithMany().HasForeignKey("ProductId"),
        je =>
        {
            je.HasKey("RoleId", "RightId");
            je.HasData();
        });*/


//И ТАЩИТЬ ЧЕРЕЗ INCLUDE

/// <summary>
/// Возможно через связную таблицу
/// </summary>
public class ProductCategory
{
    public int CategoryId { get; set; }
    public int ProductId { get; set; }
}
