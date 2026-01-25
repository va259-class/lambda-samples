using System.ComponentModel.DataAnnotations.Schema;

namespace Vektorel.EFUI.Entities;

[Table("Orders")]
public class Order
{
    [Column("OrderID")]
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Freigth { get; set; }

    [ForeignKey(nameof(EmployeeId))]
    public Employee Employee { get; set; }
}
