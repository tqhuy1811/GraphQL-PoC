using System.Collections.Generic;

namespace GraphQL_PoC.Starwars
{
	public interface ICharacter
	{
		int Id { get; }
		string Name { get; }
		IReadOnlyList<Episode> AppearsIn { get; }
		double Height { get; }
	}
}