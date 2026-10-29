using DataStructures.ViliWonka.KDTree;
using UnityEngine;

namespace DataStructures.ViliWonka.Tests
{
	public class KDTreeQueryResizeTests : MonoBehaviour
	{
		public QType QueryType;

		public int K;

		[Range(0f, 100f)]
		public float Radius;

		public bool DrawQueryNodes;

		public Vector3 IntervalSize;

		private DataStructures.ViliWonka.KDTree.KDTree tree;

		private KDQuery query;

		private void Awake()
		{
		}

		private Vector3 LorenzStep(Vector3 p)
		{
			return default;
		}

		private void Update()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
