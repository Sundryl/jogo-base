namespace RelativesTree
{
	public class ExtNode : Node
	{
		public float Top { get; set; }

		public float Left { get; set; }

		public bool HasSubTree { get; set; }

		public ExtNode(Node node)
			: base(null, Gender.Male)
		{
		}
	}
}
