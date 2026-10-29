namespace csDelaunay
{
	public struct Rectf
	{
		public static readonly Rectf ZERO;

		public static readonly Rectf ONE;

		public float X { get; set; }

		public float Y { get; set; }

		public float Width { get; set; }

		public float Height { get; set; }

		public float Left => 0f;

		public float Right => 0f;

		public float Top => 0f;

		public float Bottom => 0f;

		public Vector2f TopLeft => default;

		public Vector2f BottomRight => default;

		public Rectf(float x, float y, float width, float height)
		{
			X = 0f;
			Y = 0f;
			Width = 0f;
			Height = 0f;
		}
	}
}
