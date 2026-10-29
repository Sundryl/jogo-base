using UnityEngine;

namespace Cogobyte.ProceduralIndicators
{
	public class MeshGridTriangle
	{
		public int[] v;

		public int triangleSide;

		public MeshGridTriangle firstTris;

		public MeshGridTriangle secondTris;

		public Color32 triangleColor;

		private static float ErrorRate;

		public MeshGridTriangle(int v1, int v2, int v3, Color32 color)
		{
		}

		public void SliceByPlane(Vector3 planePoint, Vector3 planeNormal, MeshGridIndicator meshGridIndicator)
		{
		}

		public void AddNewTriangleVertex(MeshGridIndicator meshGridIndicator, int v)
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
	}
}
