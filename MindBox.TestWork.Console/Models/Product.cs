using System.ComponentModel.DataAnnotations;

namespace MindBox.TestWork.Console.Models;

/// <summary>
/// Пример как реализовать связь многие к многим через EF
/// </summary>
public class Product //: IEntityTypeConfiguration<Product>
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Category> Categories { get; set; }

    /*public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder
            .HasMany(c => c.Categories)
            .WithMany(s => s.Products)
            .UsingEntity<Dictionary<string, object>>("ProductCategory",
                r => r.HasOne<Category>().WithMany().HasForeignKey("CategoryId"),
                l => l.HasOne<Product>().WithMany().HasForeignKey("ProductId"));
    }*/
}