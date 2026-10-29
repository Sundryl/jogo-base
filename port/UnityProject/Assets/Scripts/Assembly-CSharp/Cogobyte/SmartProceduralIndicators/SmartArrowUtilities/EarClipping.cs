using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators.SmartArrowUtilities
{
	public class EarClipping
	{
		public class EarVertex
		{
			public readonly Vector3 position;

			public readonly int index;

			public bool isConvex;

			public EarVertex(Vector3 position, int index, bool isConvex)
			{
			}
		}

		public class ColoredVertex
		{
			public Vector3 position;

			public Color32 color;

			public ColoredVertex(Vector3 pos, Color32 col)
			{
			}
		}

		public class HoleShape
		{
			public List<Vector3> holeVertices;

			public float maxX;

			public int maxIndex;
		}

		public static int CalculatePointSideOfPlane(Vector3 point, Vector3 planePoint, Vector3 planeNormal)
		{
			return 0;
		}

		public static void TriangulateFaceWithHoles(List<int> tris, List<ColoredVertex> points, List<List<ColoredVertex>> holes)
		{
		}

		public static LinkedList<EarVertex> FormList(List<ColoredVertex> points)
		{
			return null;
		}

		public static void TriangulateFace(List<int> tris, List<ColoredVertex> points)
		{
		}

		public static void EarClip(List<int> tris, LinkedList<EarVertex> unusedPoints)
		{
		}

		private static bool IsEar(LinkedList<EarVertex> unusedPoints, EarVertex a, EarVertex b, EarVertex c)
		{
			return false;
		}

		public static bool IsConvex(Vector3 a, Vector3 b, Vector3 c)
		{
			return false;
		}

		public static bool PointInTriangle(Vector3 a, Vector3 b, Vector3 c, Vector3 p)
		{
			return false;
		}
	}
}
