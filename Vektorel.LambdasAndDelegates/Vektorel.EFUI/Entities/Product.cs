using System.ComponentModel.DataAnnotations.Schema;

namespace Vektorel.EFUI.Entities;

[Table("Products")]
public class Product
{
    [Column("ProductID")]
    public int Id { get; set; }
    [Column("ProductName")]
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    [Column("UnitsInStock")]
    public short Stock { get; set; }

    public int? CategoryID { get; set; }

    [ForeignKey(nameof(CategoryID))]
    public Category Category { get; set; } //Navigation Property
}
