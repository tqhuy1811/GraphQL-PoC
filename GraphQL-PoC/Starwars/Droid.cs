using System.Collections.Generic;

namespace GraphQL_PoC.Starwars
{
	public class Droid: ICharacter
	{
		public Droid(int id,
			string name,
			IReadOnlyList<Episode> appearsIn,
			double height,
			string primaryFunction)
		{
			Id = id;
			Name = name;
			AppearsIn = appearsIn;
			Height = height;
			PrimaryFunction = primaryFunction;
		}
		public int Id { get; }
		public string Name { get; }
		public IReadOnlyList<Episode> AppearsIn { get; }
		public double Height { get; }
		public string PrimaryFunction { get; }
	}
}