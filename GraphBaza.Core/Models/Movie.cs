namespace GraphBaza.Core.Models;

public class Movie {
    
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public required string Synopsis { get; set; }

    public required string PosterUrl { get; set; }

    public required string TrailerUrl { get; set; }
    
    public DateTime ReleaseDate { get; set; }

    public Genre Genre { get; set; }

    //public List<Genre> Genres { get; set; } = new List<Genre>();
    // PlotTwist
    // Spoiler
    // SpoilerAlert
    // public List<Movie> RelatedMovies { get; set; } = new List<Movie>();
    

    //public IEnumerable<Actor> Actors { get; set; }  
    //public Director Director { get; set; }

}
