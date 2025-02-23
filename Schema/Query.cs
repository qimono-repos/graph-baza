namespace GraphBaza.Schema;

public class Query
{
    [GraphQLDeprecated("Only for first version")]
    public string Welcome => "Say Hello to QiMono !!!";
    /*
    protected override void Configure(IObjectTypeDescriptor<Query> descriptor){
	descriptor
	    .Field(t => t.Welcome)
	    .Type<StringType>()
	    .Description("Welcome message")
	    ;
    }
    */
    public IEnumerable<MovieType> Movies => new List<MovieType>
    {
	new MovieType
	{
	    Id = Guid.NewGuid(),
	    Title = "The Matrix",
	    Synopsis = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
	    CoverUrl = "https://m.media-amazon.com/images/I/51lJ4G5H7fL._AC_.jpg",
	    TrailerUrl = "https://www.youtube.com/watch?v=m8e-FF8MsqU",
	    ReleaseDate = new DateTime(1999, 3, 31),
	    Genre = Genre.Action,
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
	new MovieType{
	    Id = Guid.NewGuid(),
	    Title = "Inception",
	    Synopsis = "Dreams within dreams",
	    Actors = new List<ActorType>(),
	},
    };
}
