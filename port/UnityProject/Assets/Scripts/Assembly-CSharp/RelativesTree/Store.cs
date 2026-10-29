using System.Collections.Generic;

namespace RelativesTree
{
	public class Store
	{
		private int m_NextId;

		private Dictionary<int, Family> m_Families;

		private Dictionary<string, Node> m_Nodes;

		public Node Root { get; private set; }

		public Store(List<Node> nodes, string rootId)
		{
		}

		public int GetNextId()
		{
			return 0;
		}

		public Node GetNode(string id)
		{
			return null;
		}

		public List<Node> GetNodes(List<string> ids)
		{
			return null;
		}

		public void AddFamily(Family family)
		{
		}

		public Family GetFamily(int id)
		{
			return null;
		}

		public List<Family> GetFamiliesArray()
		{
			return null;
		}

		public List<Family> GetRootFamilies()
		{
			return null;
		}

		public Family GetRootFamily()
		{
			return null;
		}

		public List<Family> GetParentFamilies()
		{
			return null;
		}

		public List<Family> GetChildFamilies()
		{
			return null;
		}

		public bool HasNode(string id)
		{
			return false;
		}

		public Dictionary<string, Node> GetAllNodes()
		{
			return null;
		}
	}
}
