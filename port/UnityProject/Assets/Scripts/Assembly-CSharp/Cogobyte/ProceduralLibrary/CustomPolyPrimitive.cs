using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	[Serializable]
	[CreateAssetMenu(fileName = "CustomPolyPrimitive", menuName = "Cogobyte/ProceduralLibrary/Primitives/CustomPolyPrimitive", order = 4)]
	public class CustomPolyPrimitive : Primitive
	{
		public class Vertex
		{
			public readonly Vector3 position;

			public readonly int index;

			public Vertex(Vector3 position, int index)
			{
			}
		}

		public List<Vector3> points;

		public Gradient[] gradient;

		private LinkedList<Vertex> unusedPoints;

		public static float ErrorRate;

		public override int getVertexCount()
		{
			return 0;
		}

		public override int getTrisCount()
		{
			return 0;
		}

		public void OnValidate()
		{
		}

		public static int CalculatePointSideOfPlane(Vector3 point, Vector3 planePoint, Vector3 planeNormal)
		{
			return 0;
		}

		public static Vector3 LinePlaneIntersection(Vector3 lineP1, Vector3 lineP2, Vector3 planePoint, Vector3 planeNormal)
		{
			return default;
		}

		public override void generate()
		{
		}

		private bool IsEar(Vector3 a, Vector3 b, Vector3 c)
		{
			return false;
		}

		public bool IsConvex(Vector3 a, Vector3 b, Vector3 c)
		{
			return false;
		}

		public static bool PointInTriangle(Vector3 a, Vector3 b, Vector3 c, Vector3 p)
		{
			return false;
		}

		public override void updateOutline()
		{
		}
	}
}
