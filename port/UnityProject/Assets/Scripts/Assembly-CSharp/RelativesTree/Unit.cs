using System.Collections.Generic;

namespace RelativesTree
{
	public class Unit
	{
		public int FamilyId { get; set; }

		public bool IsChild { get; set; }

		public List<Node> Nodes { get; set; }

		public float Position { get; set; }

		public Unit(int familyId, bool isChild = false)
		{
		}
	}
}
