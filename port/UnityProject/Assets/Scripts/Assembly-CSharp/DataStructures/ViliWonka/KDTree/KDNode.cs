namespace DataStructures.ViliWonka.KDTree
{
	public class KDNode
	{
		public float partitionCoordinate;

		public int partitionAxis;

		public KDNode negativeChild;

		public KDNode positiveChild;

		public int start;

		public int end;

		public KDBounds bounds;

		public int Count => 0;

		public bool Leaf => false;
	}
}
