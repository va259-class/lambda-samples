using Vektorel.Samples.Builder2.Enums;

namespace Vektorel.Samples.Builder2;

public class Meal
{
    public Meal()
    {
        Spices = new List<Spice>();
        WaterLimit = 300;
        Name = "Yemek";
        SaltStatus = SaltStatus.Normal;
        CookTime = new TimeOnly(0, 30);
        Ingredients = "Salça, Soğan";
    }
    /// <summary>
    /// yemeğin adı
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// tuzluluk oranı
    /// </summary>
    public SaltStatus SaltStatus { get; set; }
    /// <summary>
    /// eklenecek su (ml cinsinden)
    /// </summary>
    public short WaterLimit { get; set; }
    /// <summary>
    /// eklenecek baharatlar
    /// </summary>
    public List<Spice> Spices { get; set; }
    /// <summary>
    /// pişirme süresi
    /// </summary>
    public TimeOnly CookTime { get; set; }
    /// <summary>
    /// eklenecek ana malzemeler
    /// </summary>
    public string Ingredients { get; set; }
}
