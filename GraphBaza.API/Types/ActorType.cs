
using GraphBaza.Core.Models;
using HotChocolate.Types;

namespace GraphBaza.Core.Types;

public class ActorType //: ObjectType<Actor> 

{

    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Bio { get; set; }

    public string ImageUrl { get; set; }

    //public List<Movie> Movies { get; set; } = new List<Movie>();

}
