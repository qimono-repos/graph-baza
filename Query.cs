

namespace GraphBaza
{
    public class Query
    {
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
    }
}
