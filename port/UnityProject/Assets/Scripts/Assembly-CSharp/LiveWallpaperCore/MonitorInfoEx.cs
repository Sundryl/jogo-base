using System.Runtime.InteropServices;

namespace LiveWallpaperCore
{
	[StructLayout((LayoutKind)0, CharSet = CharSet.Auto)]
	public struct MonitorInfoEx
	{
		public int Size;

		public Rectangle Monitor;

		public Rectangle WorkArea;

		public uint Flags;

		public string DeviceName;
	}
}
