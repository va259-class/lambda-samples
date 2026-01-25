namespace Vektorel.EFUI.Models;

public class ComboBoxItem
{
    public int Id { get; set; }
    public string Label { get; set; }
}


public record ProductInfoListDTO(string Name, string Type, string Company);
public record ProductListDTO(string Name, decimal Price, int Stock);
public record SupplierListDTO(string CompanyName, string Country, string City, string Phone);
public record EmployeeSaleDTO(string FullName, decimal Total);
public record CategorySaleDTO(string Name, decimal Total);
