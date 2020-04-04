using System.Collections.Generic;
using System.Linq;
using GraphQL_PoC.Starwars;

namespace GraphQL_PoC.Repository
{
	public class CharacterRepository : ICharacterRepository
	{
		public IQueryable<ICharacter> GetCharacters(string name)
		{
			return CreateCharacters().AsQueryable().Where(c => c.Name.Contains(name));
		}


		private static IEnumerable<ICharacter> CreateCharacters()
		{
			yield return new Human
			(
				1000,
				"Luke Skywalker",
				new[] {Episode.NewHope, Episode.Empire, Episode.Jedi},
				height: 22d,
				homePlanet: "Tatooine"
			);

			yield return new Human
			(
				1001,
				"Darth Vader",
				new[] {Episode.NewHope, Episode.Empire, Episode.Jedi},
				height: 22d,
				homePlanet: "Tatooine"
			);

			yield return new Human
			(
				1002,
				"Han Solo",
				new[] {Episode.NewHope, Episode.Empire, Episode.Jedi},
				height: 22d
			);

			yield return new Human
			(
				1003,
				"Leia Organa",
				new[] {Episode.NewHope, Episode.Empire, Episode.Jedi},
				height: 22d,
				"Alderaan"
			);

			yield return new Human
			(
				1004,
				"Wilhuff Tarkin",
				new[] {Episode.NewHope},
				height: 22d,
				"Alderaan"
			);

			yield return new Droid
			(
				2000,
				"C-3PO",
				new[] {Episode.NewHope, Episode.Empire, Episode.Jedi},
				22d,
				"Protocol"
			);

			yield return new Droid
			(
				2001,
				"R2-D2",
				new[] {Episode.NewHope, Episode.Empire, Episode.Jedi},
				height: 10d,
				"Astromech"
			);
		}
	}
}