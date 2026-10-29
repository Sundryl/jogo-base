using System.Collections.Generic;

namespace RelativesTree
{
	public class Family
	{
		public int Id { get; set; }

		public FamilyType Type { get; set; }

		public bool IsMain { get; set; }

		public int? ParentFamilyId { get; set; }

		public int? ChildFamilyId { get; set; }

		public float X { get; set; }

		public float Y { get; set; }

		public List<Unit> Parents { get; set; }

		public List<Unit> Children { get; set; }

		public Family(int id, FamilyType type, bool isMain = false)
		{
		}
	}
}
