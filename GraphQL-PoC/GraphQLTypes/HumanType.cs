using GraphQL_PoC.Starwars;
using HotChocolate.Types;

namespace GraphQL_PoC
{
	public class HumanType: ObjectType<Human>
	{
		protected override void Configure(IObjectTypeDescriptor<Human> descriptor)
		{
			descriptor.Field(h => h.HomePlanet).Type<StringType>();
		}
	}
}