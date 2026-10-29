using System.Collections.Generic;

namespace RelativesTree
{
	public class Node
	{
		public string Id { get; set; }

		public Gender Gender { get; set; }

		public List<Relation> Parents { get; set; }

		public List<Relation> Children { get; set; }

		public List<Relation> Siblings { get; set; }

		public List<Relation> Spouses { get; set; }

		public bool IsPlaceholder { get; set; }

		public Node(string id, Gender gender)
		{
		}
	}
}
