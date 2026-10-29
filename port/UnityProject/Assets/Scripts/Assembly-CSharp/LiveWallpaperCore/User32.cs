using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LiveWallpaperCore
{
	public static class User32
	{
		public delegate bool MonitorEnumProc(IntPtr hMonitor, IntPtr hdcMonitor, ref Rectangle lprcMonitor, IntPtr dwData);

		public const int SM_XVIRTUALSCREEN = 76;

		public const int SM_YVIRTUALSCREEN = 77;

		public const int SM_CXVIRTUALSCREEN = 78;

		public const int SM_CYVIRTUALSCREEN = 79;

		private static List<IntPtr> _windows;

		private static int _targetProcessId;

		public static void ThrowLastError()
		{
		}

		[PreserveSig]
		public static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, MonitorEnumProc lpfnEnum, IntPtr dwData);

		[PreserveSig]
		public static extern bool GetMonitorInfo(IntPtr hMonitor, ref MonitorInfoEx lpmi);

		[PreserveSig]
		private static extern WindowStylesFlags GetWindowLongPtr32(IntPtr hWnd, int nIndex);

		[PreserveSig]
		private static extern WindowStylesFlags GetWindowLongPtr64(IntPtr hWnd, int nIndex);

		[PreserveSig]
		private static extern int SetWindowLong32(IntPtr hWnd, int nIndex, WindowStylesFlags dwNewLong);

		[PreserveSig]
		private static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, WindowStylesFlags dwNewLong);

		public static WindowStylesFlags GetWindowLongPtr(IntPtr hWnd, int nIndex)
		{
			return WindowStylesFlags.WS_OVERLAPPED;
		}

		public static void SetWindowLongPtr(IntPtr hWnd, int nIndex, WindowStylesFlags dwNewLong)
		{
		}

		[PreserveSig]
		public static extern bool SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter, int x, int y, int width, int height, uint flags);

		[PreserveSig]
		public static extern bool GetWindowRect(IntPtr hwnd, ref Rectangle rectangle);

		[PreserveSig]
		public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

		[PreserveSig]
		public static extern IntPtr GetActiveWindow();

		[PreserveSig]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		[PreserveSig]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[PreserveSig]
		public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, IntPtr windowTitle);

		[PreserveSig]
		public static extern bool IsWindow(IntPtr hWnd);

		[PreserveSig]
		public static extern IntPtr SendMessageTimeout(IntPtr windowHandle, uint msg, IntPtr wParam, IntPtr lParam, uint flags, uint timeout, out IntPtr result);

		[PreserveSig]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		[PreserveSig]
		public static extern int GetSystemMetrics(int smIndex);

		[PreserveSig]
		public static extern bool MapWindowPoints(IntPtr hWndFrom, IntPtr hWndTo, ref Rectangle rect, uint cPoints);

		[PreserveSig]
		public static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

		[PreserveSig]
		public static extern int GetWindowThreadProcessId(IntPtr window, out int process);

		[PreserveSig]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		public static IntPtr GetActiveWindowSafe()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern uint GetCurrentProcessIdWrapper();

		public static IntPtr[] GetProcessWindows()
		{
			return null;
		}

		[MonoPInvokeCallback(typeof(EnumWindowsProc))]
		private static bool EnumWindowsCallback(IntPtr hwnd, IntPtr lParam)
		{
			return false;
		}

		public static IntPtr[] GetProcessWindows(int pid)
		{
			return null;
		}
	}
}
