namespace RelativesTree
{
	public class Relation
	{
		public string Id { get; set; }

		public RelType Type { get; set; }

		public Relation(string id, RelType type = RelType.Blood)
		{
		}
	}
}
