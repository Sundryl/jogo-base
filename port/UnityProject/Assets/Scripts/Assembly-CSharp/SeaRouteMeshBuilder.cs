using System.Collections.Generic;
using UnityEngine;

public class SeaRouteMeshBuilder
{
	private const float c_Epsilon = 0.0001f;

	private readonly List<Vector3> m_Vertices;

	private readonly List<Color32> m_Colors;

	private readonly List<Vector2> m_UVs;

	private readonly List<int> m_Indices;

	public int VertexCount => 0;

	public void Begin()
	{
	}

	public void AddRoute(IReadOnlyList<Vector3> pathPoints, float halfWidth, Color32 color)
	{
	}

	public void Build(Mesh targetMesh)
	{
	}

	public void AddDashedRoute(IReadOnlyList<Vector3> pathPoints, float halfWidth, Color color, float dashLength, float gapLength, float dashOffset)
	{
	}
}
