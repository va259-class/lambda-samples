using Vektorel.Samples.Builder2.Enums;

namespace Vektorel.Samples.Builder2;

public static class MealExtensions
{
    public static Meal SetName(this Meal meal, string name)
    {
        meal.Name = name;
        return meal;
    }

    public static Meal AddSpice(this Meal meal, Spice spice)
    {
        if (!meal.Spices.Contains(spice))
        {
            meal.Spices.Add(spice); 
        }
        return meal;
    }

    public static Meal DefineWater(this Meal meal, short waterLevel)
    {
        meal.WaterLimit = waterLevel;
        return meal;
    }

    public static Meal SetCookTime(this Meal meal, int minute)
    {
        meal.CookTime = new TimeOnly(0, minute);
        return meal;
    }

    public static Meal MakeSalty(this Meal meal)
    {
        meal.SaltStatus = SaltStatus.Salty;
        return meal;
    }

    public static Meal MakeLessSalty(this Meal meal)
    {
        meal.SaltStatus = SaltStatus.Less;
        return meal;
    }

    public static Meal AddMainContent(this Meal meal, string content)
    {
        meal.Ingredients = $"{meal.Ingredients}\n{content}";
        return meal;
    }

    public static string GiveReceipt(this Meal meal)
    {
        var spices = meal.Spices.Any()
            ? string.Join(", ", meal.Spices)
            : "Baharat eklenmemiş";

        var saltInfo = meal.SaltStatus switch
        {
            SaltStatus.Salty => "Tuzlu",
            SaltStatus.Less => "Az tuzlu",
            _ => "Tuz durumu belirtilmemiş"
        };

        return $"""
    Yemek Adı: {meal.Name}

    Malzemeler:
    {meal.Ingredients}

    Baharatlar: {spices}
    Tuz Durumu: {saltInfo}
    Su Miktarı: {meal.WaterLimit} ml
    Pişirme Süresi: {meal.CookTime.Minute} dakika

    Afiyet olsun!
    """;
    }
}
