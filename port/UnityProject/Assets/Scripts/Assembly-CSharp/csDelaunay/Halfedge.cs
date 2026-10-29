using System.Collections.Generic;

namespace csDelaunay
{
	public class Halfedge
	{
		private static Queue<Halfedge> pool;

		public Halfedge EdgeListLeftNeighbor { get; set; }

		public Halfedge EdgeListRightNeighbor { get; set; }

		public Halfedge NextInPriorityQueue { get; set; }

		public Edge Edge { get; set; }

		public LR LeftRight { get; set; }

		public Vertex Vertex { get; set; }

		public float Ystar { get; set; }

		public static Halfedge Create(Edge edge, LR lr)
		{
			return null;
		}

		public static Halfedge CreateDummy()
		{
			return null;
		}

		public Halfedge(Edge edge, LR lr)
		{
		}

		private Halfedge Init(Edge edge, LR lr)
		{
			return null;
		}

		public void Dispose()
		{
		}

		public void ReallyDispose()
		{
		}

		public bool IsLeftOf(Vector2f p)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
