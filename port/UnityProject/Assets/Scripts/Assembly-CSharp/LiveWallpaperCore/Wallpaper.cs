using System.Diagnostics;
using UnityEngine;

namespace LiveWallpaperCore
{
	public static class Wallpaper
	{
		private const int MAX_WALLPAPER_PATH_LENGTH = 260;

		private const uint SPI_SETDESKWALLPAPER = 20u;

		private const uint SPI_GETDESKWALLPAPER = 115u;

		private const uint SPIF_UPDATEINIFILE = 1u;

		private const uint SPIF_SENDWININICHANGE = 2u;

		public static string GetWallpaperPath()
		{
			return null;
		}

		public static Texture2D GetWallpaperTexture()
		{
			return null;
		}

		[Conditional("UNITY_STANDALONE_WIN")]
		public static void SetWallpaper(string filePath)
		{
		}

		[Conditional("UNITY_STANDALONE_WIN")]
		public static void SetWallpaper(Texture2D image)
		{
		}

		[Conditional("UNITY_STANDALONE_WIN")]
		public static void RefreshWallpaper()
		{
		}
	}
}
