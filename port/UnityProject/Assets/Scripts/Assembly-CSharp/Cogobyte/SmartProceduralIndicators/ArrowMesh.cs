using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	[Serializable]
	public class ArrowMesh
	{
		public List<Vector3> vertices;

		public List<int> triangles;

		public List<Vector2> uvs;

		public List<Color32> colors;

		public List<Vector3> normals;

		public string name;

		public int startVertexIndex;

		public Mesh mesh;

		public ArrowMesh()
		{
		}

		public ArrowMesh(ArrowMesh m)
		{
		}

		public void ClearMesh()
		{
		}

		public void GenerateMesh()
		{
		}

		public void PushToMesh(MeshFilter meshFilter)
		{
		}

		public void AddVertex(Vector3 position, Vector2 uv, Vector3 normal, Color32 col)
		{
		}

		public void AddTriangle(int a, int b, int c)
		{
		}

		public void UpdateStartVertexIndex()
		{
		}
	}
}
