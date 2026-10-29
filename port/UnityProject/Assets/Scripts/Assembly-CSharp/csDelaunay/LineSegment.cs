using System.Collections.Generic;

namespace csDelaunay
{
	public class LineSegment
	{
		public Vector2f P0 { get; set; }

		public Vector2f P1 { get; set; }

		public static List<LineSegment> VisibleLineSegments(List<Edge> edges)
		{
			return null;
		}

		public static float CompareLengths_MAX(LineSegment segment0, LineSegment segment1)
		{
			return 0f;
		}

		public static float CompareLengths(LineSegment edge0, LineSegment edge1)
		{
			return 0f;
		}

		public LineSegment(Vector2f p0, Vector2f p1)
		{
		}
	}
}
