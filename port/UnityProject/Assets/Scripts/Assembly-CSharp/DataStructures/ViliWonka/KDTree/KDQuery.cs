using System.Collections.Generic;
using DataStructures.ViliWonka.Heap;
using UnityEngine;

namespace DataStructures.ViliWonka.KDTree
{
	public class KDQuery
	{
		protected KDQueryNode[] queueArray;

		protected MinHeap<KDQueryNode> minHeap;

		protected int count;

		protected int queryIndex;

		private SortedList<int, KSmallestHeap<int>> _heaps;

		protected int LeftToProcess => 0;

		private KDQueryNode PushGetQueue()
		{
			return null;
		}

		protected void PushToQueue(KDNode node, Vector3 tempClosestPoint)
		{
		}

		protected void PushToHeap(KDNode node, Vector3 tempClosestPoint, Vector3 queryPosition)
		{
		}

		protected KDQueryNode PopFromQueue()
		{
			return null;
		}

		protected KDQueryNode PopFromHeap()
		{
			return null;
		}

		protected void Reset()
		{
		}

		public KDQuery(int queryNodesContainersInitialSize = 2048)
		{
		}

		public void DrawLastQuery()
		{
		}

		public void ClosestPoint(KDTree tree, Vector3 queryPosition, List<int> resultIndices, List<float> resultDistances = null)
		{
		}

		public void Interval(KDTree tree, Vector3 min, Vector3 max, List<int> resultIndices)
		{
		}

		public void KNearest(KDTree tree, Vector3 queryPosition, int k, List<int> resultIndices, List<float> resultDistances = null)
		{
		}

		public void Radius(KDTree tree, Vector3 queryPosition, float queryRadius, List<int> resultIndices)
		{
		}
	}
}
