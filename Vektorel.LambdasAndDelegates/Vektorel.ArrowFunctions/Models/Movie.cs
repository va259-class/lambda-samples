using Vektorel.ArrowFunctions.Enums;

namespace Vektorel.ArrowFunctions.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int ReleaseYear { get; set; }

    public Genre Genre { get; set; }
    public Country Country { get; set; }

    public decimal Rating { get; set; }
}
