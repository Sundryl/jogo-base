namespace csDelaunay
{
	public class EdgeList
	{
		private float deltaX;

		private float xmin;

		private int hashSize;

		private Halfedge[] hash;

		public Halfedge LeftEnd { get; private set; }

		public Halfedge RightEnd { get; private set; }

		public EdgeList(float xmin, float deltaX, int sqrtSitesNb)
		{
		}

		public void Insert(Halfedge lb, Halfedge newHalfedge)
		{
		}

		public void Remove(Halfedge halfedge)
		{
		}

		public void Dispose()
		{
		}

		public Halfedge EdgeListLeftNeighbor(Vector2f p)
		{
			return null;
		}

		private Halfedge GetHash(int b)
		{
			return null;
		}
	}
}
