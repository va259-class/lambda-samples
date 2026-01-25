using System.ComponentModel.DataAnnotations.Schema;

namespace Vektorel.EFUI.Entities;

[Table("Employees")]
public class Employee
{
    [Column("EmployeeID")]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime HireDate { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
}
