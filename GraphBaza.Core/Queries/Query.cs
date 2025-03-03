

using GraphBaza.Core.Models;
using GraphBaza.Core.Types;
//using HotChocolate.Authorization;

namespace GraphBaza.Core.Queries;

public class Query
{
    [GraphQLDeprecated("Only for first version")]
    public string Welcome => "Say Hello to QiMono !!!";

    //[Authorize]
    public IEnumerable<MovieType> Movies => new List<MovieType>
    {
        new MovieType
        {
            Id = Guid.NewGuid(),
            Title = "The Matrix",
            Synopsis = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
            PosterUrl = "https://m.media-amazon.com/images/I/51lJ4G5H7fL._AC_.jpg",
            TrailerUrl = "https://www.youtube.com/watch?v=m8e-FF8MsqU",
            ReleaseDate = new DateTime(1999, 3, 31),
            Genre = Genre.Action,
	    Director = new DirectorType{ Id =Guid.NewGuid(), Name="Wachowsky Sis",},
            Actors = new List<ActorType>
            {
                new ActorType
                {
                    Id = Guid.NewGuid(),
                    Name = "Keanu Reeves",
                },
                new ActorType
                {
                    Id = Guid.NewGuid(),
                    Name = "Laurence Fishburne",
                },
                new ActorType
                {
                    Id = Guid.NewGuid(),
                    Name = "Carrie-Anne Moss",
                },
            },
        },
        new MovieType
        {
            Id = Guid.NewGuid(),
            Title = "Inception",
            Synopsis = "Dreams within dreams",
            PosterUrl = "https://upload.wikimedia.org/wikipedia/en/2/2e/Inception_%282010%29_theatrical_poster.jpg",
            ReleaseDate = new DateTime(2010, 7, 16),
            Genre = Genre.SciFi,
	    Director = new DirectorType(){ Id =Guid.NewGuid(), Name="Christopher Nolan",},
            Actors = new List<ActorType>
            {
                new ActorType
                {
                    Id = Guid.NewGuid(),
                    Name = "Leonardo DiCaprio",
                },
                new ActorType
                {
                    Id = Guid.NewGuid(),
                    Name = "Joseph Gordon-Levitt",
                },
            },
        },
        new MovieType
        {
            Id = Guid.NewGuid(),
            Title = "Twisters",
            Synopsis = "A team of storm chasers investigates a series of tornadoes in a small town.",
            PosterUrl= "https://upload.wikimedia.org/wikipedia/en/2/24/Twisters_Official_US_Theatrical_Poster.jpg", 
            ReleaseDate = new DateTime(2024, 6, 14), 
            Genre = Genre.Action,
	    Director = new DirectorType(){ Id =Guid.NewGuid(), Name="Lee Isaac Chung",},
            Actors = new List<ActorType>
            {
                new ActorType
                {
                    Id = Guid.NewGuid(),
                    Name = "Daisy Edgar-Jones", 
                },
                new ActorType
                {
                    Id = Guid.NewGuid(),
                    Name = "Glenn Powell", 
                },
            },
        },
    };
}
