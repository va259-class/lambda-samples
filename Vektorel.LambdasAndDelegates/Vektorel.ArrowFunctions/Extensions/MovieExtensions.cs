using Vektorel.ArrowFunctions.Enums;
using Vektorel.ArrowFunctions.Models;

namespace Vektorel.ArrowFunctions.Extensions;

public static class MovieExtensions
{
    public static int GetMovieCount(this List<Movie> movies)
    {
        return movies.Count;
    }

    public static int GetCountByCountry(this List<Movie> movies, Country country)
    {
        //var counter = 0;
        //foreach (var movie in movies)
        //{
        //    if (movie.Country == country)
        //    {
        //        counter++;
        //    }
        //}
        //return counter;
        return movies.Count(f => f.Country == country);
    }

    public static decimal GetRatingAveragebyCountry(this List<Movie> movies, Country country)
    {
        return Math.Round(movies.Where(m => m.Country == country)
                                .Average(m => m.Rating),
                          2);
    }

    public static void GetByYear(this List<Movie> movies, int year)
    {
        Console.WriteLine("Temizlemek için bir tuşa basınız");
        Console.ReadKey();
        Console.Clear();

        var moviesFrom2018 = movies.Where(m => m.ReleaseYear == 2018);
        
        Console.WriteLine("2018 yılı filmler");
        ConsoleTableHelper.PrintMoviesTable(moviesFrom2018);
    }

    public static decimal MultiplyBy2(this decimal value)
    {
        return value * 2;
    }

    public static string NormalizeFromTurkish(this string text)
    {
        return text.Replace("ğ", "g")
                   .Replace("Ğ", "g")
                   .Replace("ş", "s")
                   .Replace("Ş", "S")
                   .Replace("ı", "i")
                   .Replace("İ", "I")
                   .Replace("Ö", "o")
                   .Replace("O", "O")
                   .Replace("ü", "u")
                   .Replace("U", "U")
                   .Replace("ç", "c")
                   .Replace("Ç", "C");
    }
}
