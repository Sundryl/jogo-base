namespace csDelaunay
{
	public class HalfedgePriorityQueue
	{
		private Halfedge[] hash;

		private int count;

		private int minBucked;

		private int hashSize;

		private float ymin;

		private float deltaY;

		public bool Empty => false;

		public HalfedgePriorityQueue(float ymin, float deltaY, int sqrtSitesNb)
		{
		}

		public void Dispose()
		{
		}

		public void Insert(Halfedge halfedge)
		{
		}

		public void Remove(Halfedge halfedge)
		{
		}

		public Vector2f Min()
		{
			return default;
		}

		public Halfedge ExtractMin()
		{
			return null;
		}

		private void Init()
		{
		}

		private int Bucket(Halfedge halfedge)
		{
			return 0;
		}

		private bool IsBucketEmpty(int bucket)
		{
			return false;
		}

		private void AdjustMinBucket()
		{
		}
	}
}
