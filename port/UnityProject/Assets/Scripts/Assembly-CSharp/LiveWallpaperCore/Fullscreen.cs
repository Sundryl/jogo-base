using System;
using System.Diagnostics;
using UnityEngine;

namespace LiveWallpaperCore
{
	public static class Fullscreen
	{
		private const int GWL_STYLE = -16;

		private const int SM_CXVIRTUALSCREEN = 78;

		private const int SM_CYVIRTUALSCREEN = 79;

		private const uint SWP_SHOWWINDOW = 64u;

		private const WindowStylesFlags WSF_BORDER = WindowStylesFlags.WS_CAPTION | WindowStylesFlags.WS_MINIMIZE | WindowStylesFlags.WS_MAXIMIZE | WindowStylesFlags.WS_SYSMENU | WindowStylesFlags.WS_THICKFRAME;

		private const int TOOLBARHEIGHT = 0;

		public static int VirtualScreenWidth => 0;

		public static int VirtualScreenHeight => 0;

		public static WindowStylesFlags GetWindowStyle(IntPtr windowHandle)
		{
			return WindowStylesFlags.WS_OVERLAPPED;
		}

		[Conditional("UNITY_STANDALONE_WIN")]
		public static void RestoreWindowBorders(IntPtr windowHandle)
		{
		}

		[Conditional("UNITY_STANDALONE_WIN")]
		public static void RemoveWindowBorders(IntPtr windowHandle)
		{
		}

		[Conditional("UNITY_STANDALONE_WIN")]
		public static void SetWindowStyle(IntPtr windowHandle, WindowStylesFlags newStyle)
		{
		}

		[Conditional("UNITY_STANDALONE_WIN")]
		public static void SetWindowFullscreen(IntPtr windowHandle)
		{
		}

		[Conditional("UNITY_STANDALONE_WIN")]
		public static void SetWindowPosition(IntPtr windowHandle, Rect rect)
		{
		}
	}
}
