using System;

namespace LiveWallpaperCore
{
	public class DisplayMonitor
	{
		public IntPtr Handle { get; set; }

		public string DeviceName { get; set; }

		public Rectangle Bounds { get; set; }

		public bool IsPrimary { get; set; }

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
