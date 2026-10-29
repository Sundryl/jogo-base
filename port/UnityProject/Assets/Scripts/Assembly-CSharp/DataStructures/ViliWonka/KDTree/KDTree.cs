using System.Collections.Generic;
using UnityEngine;

namespace DataStructures.ViliWonka.KDTree
{
	public class KDTree
	{
		private Vector3[] points;

		private int[] permutation;

		private int maxPointsPerLeafNode;

		private KDNode[] kdNodesStack;

		private int kdNodesCount;

		public KDNode RootNode { get; private set; }

		public Vector3[] Points => null;

		public int[] Permutation => null;

		public int Count { get; private set; }

		public KDTree(int maxPointsPerLeafNode = 32)
		{
		}

		public KDTree(Vector3[] points, int maxPointsPerLeafNode = 32)
		{
		}

		public void Build(Vector3[] newPoints, int maxPointsPerLeafNode = -1)
		{
		}

		public void Build(List<Vector3> newPoints, int maxPointsPerLeafNode = -1)
		{
		}

		public void Rebuild(int maxPointsPerLeafNode = -1)
		{
		}

		public void SetCount(int newSize)
		{
		}

		private void BuildTree()
		{
		}

		private KDNode GetKDNode()
		{
			return null;
		}

		private void ResetKDNodeStack()
		{
		}

		private KDBounds MakeBounds()
		{
			return default;
		}

		private void SplitNode(KDNode parent)
		{
		}

		private float CalculatePivot(int start, int end, float boundsStart, float boundsEnd, int axis)
		{
			return 0f;
		}

		private int Partition(int start, int end, float partitionPivot, int axis)
		{
			return 0;
		}

		private bool ContinueSplit(KDNode node)
		{
			return false;
		}
	}
}
