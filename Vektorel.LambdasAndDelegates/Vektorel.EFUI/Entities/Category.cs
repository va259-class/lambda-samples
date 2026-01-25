using System.ComponentModel.DataAnnotations.Schema;

namespace Vektorel.EFUI.Entities;

[Table("Categories")]
public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
}
