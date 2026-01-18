using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.ArrowFunctions.Models;

namespace Vektorel.ArrowFunctions
{

    public static class ConsoleTableHelper
    {
        public static void PrintMoviesTable(IEnumerable<Movie> movies)
        {
            var movieList = movies.ToList();

            if (!movieList.Any())
            {
                Console.WriteLine("No movies to display.");
                return;
            }

            // Column widths
            int idWidth = 4;
            int titleWidth = Math.Max(20, movieList.Max(m => m.Title.Length) + 2);
            int yearWidth = 6;
            int genreWidth = 14;
            int countryWidth = 14;
            int ratingWidth = 8;

            // Header
            PrintLine(idWidth, titleWidth, yearWidth, genreWidth, countryWidth, ratingWidth);
            PrintRow(idWidth, titleWidth, yearWidth, genreWidth, countryWidth, ratingWidth,
                     "ID", "Title", "Year", "Genre", "Country", "Rating");
            PrintLine(idWidth, titleWidth, yearWidth, genreWidth, countryWidth, ratingWidth);

            // Rows
            foreach (var m in movieList)
            {
                PrintRow(idWidth, titleWidth, yearWidth, genreWidth, countryWidth, ratingWidth,
                         m.Id.ToString(),
                         m.Title,
                         m.ReleaseYear.ToString(),
                         m.Genre.ToString(),
                         m.Country.ToString(),
                         m.Rating.ToString("0.0"));
            }

            PrintLine(idWidth, titleWidth, yearWidth, genreWidth, countryWidth, ratingWidth);
        }

        private static void PrintLine(params int[] widths)
        {
            Console.WriteLine("+" + string.Join("+", widths.Select(w => new string('-', w))) + "+");
        }

        private static void PrintRow(int idW, int titleW, int yearW, int genreW, int countryW, int ratingW, string id, string title, string year, string genre, string country, string rating)
        {
            Console.WriteLine(
                $"|{id.PadRight(idW)}" +
                $"|{title.PadRight(titleW)}" +
                $"|{year.PadRight(yearW)}" +
                $"|{genre.PadRight(genreW)}" +
                $"|{country.PadRight(countryW)}" +
                $"|{rating.PadLeft(ratingW)}|"
            );
        }
    }

    class PredicateHelper
    {
        //Func delegate kullanımı, tanıma bağlı olarak;
        //son generic parametre return olmak üzere diğerleri fonksiyon parametresi gibi düşünülnelidir
        public int MultiplyBy2(Func<int, int> function, int value)
        {
            return function(value) * 2;
        }
    }

    class PlayGround
    {
        public void Try()
        {
            var ph = new PredicateHelper();
            var a = ph.MultiplyBy2(x => x + 3, 9);
        }

        public int B(int v)
        {
            return v + 3;
        }

        public int Topla(int a)
        {
            Func<int, int> localFunction = x => x + 10;
            return localFunction(a);
        }
    }
}
