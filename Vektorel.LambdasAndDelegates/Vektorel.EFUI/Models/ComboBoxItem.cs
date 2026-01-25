namespace Vektorel.EFUI.Models;

public class ComboBoxItem
{
    public int Id { get; set; }
    public string Label { get; set; }
}


public record ProductListDTO(string Name, decimal Price, int Stock);