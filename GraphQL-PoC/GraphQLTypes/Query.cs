using System.Collections.Generic;
using System.Linq;
using GraphQL_PoC.Repository;
using GraphQL_PoC.Starwars;
using HotChocolate;
using HotChocolate.Types;

namespace GraphQL_PoC
{
	public class Query : ObjectType
	{
		public Greetings GetGreetings => new Greetings();

		protected override void Configure(IObjectTypeDescriptor descriptor)
		{
			descriptor
				.Field<GetCharactersResolver>(d => d.GetCharacters(default, default))
				.Argument("name", argumentDescriptor => { argumentDescriptor.Type<StringType>(); });
		}
	}

	[ExtendObjectType(Name = "Query")]
	public class GetCharactersResolver
	{
		public IEnumerable<ICharacter> GetCharacters(
			string name,
			[Service]ICharacterRepository repository) =>
			repository.GetCharacters(name);
	}


	public class Greetings
	{
		public string Hello()
		{
			return "World";
		}
	}
}