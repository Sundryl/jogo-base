using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.ProceduralIndicators
{
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class MeshGridIndicator : MonoBehaviour
	{
		public float[] gridX;

		public float[] gridY;

		public float[] gridZ;

		public Color32 defaultColor;

		public Color32 outsideColor;

		public Vector3 gridOffset;

		public Mesh mesh;

		public Vector3 meshPosition;

		public Vector3 meshRotation;

		public Vector3 meshScale;

		private Queue<MeshGridTriangle>[,,] triangleSeparation;

		private Queue<MeshGridTriangle> outside;

		[NonSerialized]
		public List<Vector3> finalVertices;

		[NonSerialized]
		public List<Vector3> finalNormals;

		[NonSerialized]
		public List<Vector2> finalUvs;

		[NonSerialized]
		public List<Color32> finalColors;

		private List<int> finalTriangles;

		private Mesh m;

		public void Start()
		{
		}

		public void SetColor(int x, int y, int z, Color32 color)
		{
		}

		public void ResetColor()
		{
		}

		public void MakeSeparation()
		{
		}

		private void SeperateTriangleZones(Vector3 planePoint, Vector3 planeNormal, ref Queue<MeshGridTriangle> mainZone, ref Queue<MeshGridTriangle> other)
		{
		}
	}
}
