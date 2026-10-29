using System.Collections.Generic;
using UnityEngine;

public class Quadtree
{
	private const int MAX_CAPACITY = 4;

	private Rect boundary;

	private List<int> pointIndices;

	private List<Vector2> points;

	private Quadtree[] children;

	public Quadtree(Rect boundary, List<Vector2> points)
	{
	}

	public void Build()
	{
	}

	public void Insert(int index)
	{
	}

	public int FindNearestIndex(Vector2 point)
	{
		return 0;
	}

	private void Subdivide()
	{
	}
}
