using System.Collections.Generic;

namespace csDelaunay
{
	public class Polygon
	{
		public List<Vector2f> Vertices { get; set; }

		public float Area => 0f;

		public Winding PolyWinding => Winding.CLOCKWISE;

		public Polygon(List<Vector2f> vertices)
		{
		}

		private float SignedDoubleArea()
		{
			return 0f;
		}
	}
}
