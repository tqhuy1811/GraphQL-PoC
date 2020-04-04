using System.Collections.Generic;

namespace GraphQL_PoC.Starwars
{
	public class Human: ICharacter
	{
		public Human(int id,
			string name,
			IReadOnlyList<Episode> appearsIn,
			double height,
			string homePlanet = null)
		{
			Id = id;
			Name = name;
			AppearsIn = appearsIn;
			Height = height;
			HomePlanet = homePlanet;
		}
		public int Id { get; }
		public string Name { get; }
		public IReadOnlyList<Episode> AppearsIn { get; }
		public double Height { get; }
		public string HomePlanet { get; }
	}
}