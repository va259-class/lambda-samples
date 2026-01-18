using System.ComponentModel.DataAnnotations;
using Vektorel.ArrowFunctions.Data;
using Vektorel.ArrowFunctions.Enums;
using Vektorel.ArrowFunctions.Extensions;

namespace Vektorel.ArrowFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sample
            //var a = 5M;
            //var b = MovieExtensions.MultiplyBy2(a);
            //var c = a.MultiplyBy2();
            //Console.WriteLine(c);

            //var t1 = "Fıstıkçı Şahap";
            //var ent1 = t1.NormalizeFromTurkish();
            //Console.WriteLine(ent1); 
            #endregion

            var repo = new MovieRepository();
            var movies = repo.GetMovies();
            var count = movies.GetMovieCount();
            var usaMovieCount = movies.GetCountByCountry(Country.USA);
            Console.WriteLine($"USA film adedi: {usaMovieCount}");
            var jpMovieCount = movies.GetCountByCountry(Country.Japan);
            Console.WriteLine($"Japan film adedi: {jpMovieCount}");

            var countries = Enum.GetValues<Country>();

            foreach (var country in countries)
            {
                var avg = movies.GetRatingAveragebyCountry(country);
                Console.WriteLine("{0,-15} {1}", country, avg);
            }
            Console.WriteLine("Temizlemek için bir tuşa basınız");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Tüm Filmler");
            ConsoleTableHelper.PrintMoviesTable(movies);

            // 2018 yılında çıkan filmler
            movies.GetByYear(2018);
            // Rating'i 8.5 üstü olanlar
            movies.GetByRating(8.5M);
            // Bilim Kurgu filmleri
            movies.GetByGenre(Genre.SciFi);
        }
    }
}

