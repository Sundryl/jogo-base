using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.ProceduralIndicators
{
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class GridIndicator : MonoBehaviour
	{
		public float[] gridX;

		public float[] gridY;

		public float[] gridZ;

		public Color32 gridColor;

		public Vector3 gridOffset;

		public float thickness;

		[NonSerialized]
		public List<Vector3> finalVertices;

		[NonSerialized]
		public List<Vector3> finalNormals;

		[NonSerialized]
		public List<Vector2> finalUvs;

		[NonSerialized]
		public List<Color32> finalColors;

		private List<int> finalTriangles;

		[NonSerialized]
		public Mesh m;

		private int vertexCount;

		private void Start()
		{
		}

		public void SetGridColor(Color32 newColor)
		{
		}

		public void Generate()
		{
		}

		private void GenerateGridPart(float[] firstGrid, float[] secondGrid, float[] thirdGrid, float firstBorder, int side, int X, int Y, int Z)
		{
		}
	}
}
