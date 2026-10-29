using System.Collections.Generic;

namespace csDelaunay
{
	public class Vertex : ICoord
	{
		public static readonly Vertex VERTEX_AT_INFINITY;

		private static Queue<Vertex> pool;

		private static int nVertices;

		public int VertexIndex { get; private set; }

		public Vector2f Coord { get; set; }

		public float X => 0f;

		public float Y => 0f;

		public static Vertex Intersect(Halfedge halfedge0, Halfedge halfedge1)
		{
			return null;
		}

		private static Vertex Create(float x, float y)
		{
			return null;
		}

		public Vertex(float x, float y)
		{
		}

		private Vertex Init(float x, float y)
		{
			return null;
		}

		public void Dispose()
		{
		}

		public void SetIndex()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
