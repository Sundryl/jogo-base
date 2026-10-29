using UnityEngine;

namespace LiveWallpaperCore
{
	public struct Rectangle
	{
		public int Left { get; set; }

		public int Top { get; set; }

		public int Right { get; set; }

		public int Bottom { get; set; }

		public static implicit operator Rectangle(Rect other)
		{
			return default;
		}

		public static implicit operator Rect(Rectangle other)
		{
			return default;
		}
	}
}
