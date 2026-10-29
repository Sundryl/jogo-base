using UnityEngine;

namespace LiveWallpaperCore
{
	public struct MousePosition
	{
		public int x;

		public int y;

		public override string ToString()
		{
			return null;
		}

		public static implicit operator Vector2(MousePosition other)
		{
			return default;
		}

		public static implicit operator MousePosition(Vector2 other)
		{
			return default;
		}
	}
}
