using System;

namespace LiveWallpaperCore
{
	public struct KeyboardData
	{
		public HookKeyCode key;

		public ushort data;

		public uint flags;

		public uint time;

		public IntPtr dwExtraInfo;

		public override string ToString()
		{
			return null;
		}
	}
}
