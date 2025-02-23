using System;
using System.Collections.Generic;

namespace GraphBaza.Schema;

public class MovieType

{

    public Guid Id { get; set; }

    public string Title { get; set; }

    public string Synopsis { get; set; }

    public string CoverUrl { get; set; }

    public string TrailerUrl { get; set; }
    
    public DateTime ReleaseDate { get; set; }

    public Genre Genre { get; set; }

    //public List<Genre> Genres { get; set; } = new List<Genre>();
    // PlotTwist
    // Spoiler
    // SpoilerAlert
    // public List<Movie> RelatedMovies { get; set; } = new List<Movie>();
    

    public IEnumerable<ActorType> Actors { get; set; }  
    //public Director Director { get; set; }

}
