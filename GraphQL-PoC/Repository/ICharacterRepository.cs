using System.Collections.Generic;
using System.Linq;
using GraphQL_PoC.Starwars;

namespace GraphQL_PoC.Repository
{
	public interface ICharacterRepository
	{
		IQueryable<ICharacter> GetCharacters(string name);
	}
}