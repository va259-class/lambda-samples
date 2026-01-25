using System.ComponentModel.DataAnnotations.Schema;

namespace Vektorel.EFUI.Entities;

[Table("Suppliers")]
public class Supplier
{
    [Column("SupplierId")]
    public int Id { get; set; }
    public string CompanyName { get; set; }
    [Column("ContactTitle")]
    public string Manager { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
}
