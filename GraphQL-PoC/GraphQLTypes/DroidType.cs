using GraphQL_PoC.Starwars;
using HotChocolate.Types;

namespace GraphQL_PoC
{
	public class DroidType: ObjectType<Droid>
	{
		protected override void Configure(IObjectTypeDescriptor<Droid> descriptor)
		{
			descriptor.Field(d => d.PrimaryFunction).Type<StringType>();
		}
	}
}