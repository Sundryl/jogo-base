using System;
using System.Collections.Generic;
using System.Diagnostics;
using DataStructures.ViliWonka.KDTree;
using UnityEngine;

namespace DataStructures.ViliWonka.Tests
{
	public class KDTreeBenchmark : MonoBehaviour
	{
		private Vector3[] points10k;

		private Vector3[] points100k;

		private Vector3[] points1m;

		private Vector3[] testingArray;

		private Stopwatch stopwatch;

		private DataStructures.ViliWonka.KDTree.KDTree tree;

		private KDQuery query;

		private List<int> results;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void TestSet()
		{
		}

		private void TestConstruction(int tests, string distributionName, Action randomize)
		{
		}

		private void TestQuery(int tests, string distributionName, Action randomize)
		{
		}

		private void RandomizeUniform()
		{
		}

		private void RandomizeTriangle()
		{
		}

		private void Randomize2DPlane()
		{
		}

		private void SortedRandomize2DPlane()
		{
		}

		private long Construct()
		{
			return 0L;
		}

		private long QueryRadius()
		{
			return 0L;
		}

		private long QueryClosest()
		{
			return 0L;
		}

		private long QueryKNearest()
		{
			return 0L;
		}

		private long QueryInterval()
		{
			return 0L;
		}
	}
}
