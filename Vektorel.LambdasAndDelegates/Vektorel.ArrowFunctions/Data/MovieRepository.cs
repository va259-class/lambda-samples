using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.ArrowFunctions.Enums;
using Vektorel.ArrowFunctions.Models;

namespace Vektorel.ArrowFunctions.Data
{
    class MovieRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Title = "Quantum Divide", ReleaseYear = 2024, Genre = Genre.SciFi, Country = Country.USA, Rating = 8.3m },
                new Movie { Id = 2, Title = "Velvet Silence", ReleaseYear = 2023, Genre = Genre.Drama, Country = Country.UK, Rating = 7.6m },
                new Movie { Id = 3, Title = "Neon Rebellion", ReleaseYear = 2025, Genre = Genre.Action, Country = Country.Canada, Rating = 8.1m },
                new Movie { Id = 4, Title = "The Last Signal", ReleaseYear = 2024, Genre = Genre.Thriller, Country = Country.Germany, Rating = 7.9m },
                new Movie { Id = 5, Title = "Ashes of Tomorrow", ReleaseYear = 2023, Genre = Genre.SciFi, Country = Country.USA, Rating = 8.0m },
                new Movie { Id = 6, Title = "Midnight Stage", ReleaseYear = 2022, Genre = Genre.Drama, Country = Country.France, Rating = 7.4m },
                new Movie { Id = 7, Title = "Static Hearts", ReleaseYear = 2024, Genre = Genre.Romance, Country = Country.UK, Rating = 7.8m },
                new Movie { Id = 8, Title = "Iron Pulse", ReleaseYear = 2025, Genre = Genre.Action, Country = Country.USA, Rating = 8.5m },
                new Movie { Id = 9, Title = "Fragments of Her", ReleaseYear = 2023, Genre = Genre.Mystery, Country = Country.SouthKorea, Rating = 8.2m },
                new Movie { Id = 10, Title = "Echo Protocol", ReleaseYear = 2024, Genre = Genre.TechThriller, Country = Country.Japan, Rating = 8.4m },

                new Movie { Id = 11, Title = "Inception", ReleaseYear = 2010, Genre = Genre.SciFi, Country = Country.USA, Rating = 8.8m },
                new Movie { Id = 12, Title = "The Social Network", ReleaseYear = 2010, Genre = Genre.Drama, Country = Country.USA, Rating = 7.7m },
                new Movie { Id = 13, Title = "Black Swan", ReleaseYear = 2010, Genre = Genre.Thriller, Country = Country.USA, Rating = 8.0m },
                new Movie { Id = 14, Title = "Drive", ReleaseYear = 2011, Genre = Genre.Thriller, Country = Country.USA, Rating = 7.8m },
                new Movie { Id = 15, Title = "Skyfall", ReleaseYear = 2012, Genre = Genre.Action, Country = Country.UK, Rating = 7.8m },

                new Movie { Id = 16, Title = "Interstellar", ReleaseYear = 2014, Genre = Genre.SciFi, Country = Country.USA, Rating = 8.7m },
                new Movie { Id = 17, Title = "Gone Girl", ReleaseYear = 2014, Genre = Genre.Mystery, Country = Country.USA, Rating = 8.1m },
                new Movie { Id = 18, Title = "Mad Max: Fury Road", ReleaseYear = 2015, Genre = Genre.Action, Country = Country.USA, Rating = 8.1m },
                new Movie { Id = 19, Title = "Ex Machina", ReleaseYear = 2015, Genre = Genre.TechThriller, Country = Country.UK, Rating = 7.7m },

                new Movie { Id = 20, Title = "Arrival", ReleaseYear = 2016, Genre = Genre.SciFi, Country = Country.USA, Rating = 7.9m },
                new Movie { Id = 21, Title = "La La Land", ReleaseYear = 2016, Genre = Genre.Romance, Country = Country.USA, Rating = 8.0m },
                new Movie { Id = 22, Title = "Blade Runner 2049", ReleaseYear = 2017, Genre = Genre.SciFi, Country = Country.USA, Rating = 8.0m },
                new Movie { Id = 23, Title = "Get Out", ReleaseYear = 2017, Genre = Genre.Thriller, Country = Country.USA, Rating = 7.8m },
                new Movie { Id = 24, Title = "Dunkirk", ReleaseYear = 2017, Genre = Genre.Action, Country = Country.UK, Rating = 7.8m },

                new Movie { Id = 25, Title = "Parasite", ReleaseYear = 2019, Genre = Genre.Thriller, Country = Country.SouthKorea, Rating = 8.5m },
                new Movie { Id = 26, Title = "Joker", ReleaseYear = 2019, Genre = Genre.Drama, Country = Country.USA, Rating = 8.4m },
                new Movie { Id = 27, Title = "1917", ReleaseYear = 2019, Genre = Genre.Action, Country = Country.UK, Rating = 8.2m },
                new Movie { Id = 28, Title = "Once Upon a Time in Hollywood", ReleaseYear = 2019, Genre = Genre.Drama, Country = Country.USA, Rating = 7.6m },
                new Movie { Id = 29, Title = "Tenet", ReleaseYear = 2020, Genre = Genre.SciFi, Country = Country.USA, Rating = 7.3m },
                new Movie { Id = 30, Title = "Soul", ReleaseYear = 2020, Genre = Genre.Drama, Country = Country.USA, Rating = 8.1m }
            };
        }

    }
}
