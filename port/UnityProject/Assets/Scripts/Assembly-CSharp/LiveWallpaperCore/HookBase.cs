using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using AOT;

namespace LiveWallpaperCore
{
	public abstract class HookBase : IDisposable
	{
		protected delegate IntPtr LowLevelProc(int nCode, IntPtr wParam, IntPtr lParam);

		public class HookEventArgs : EventArgs
		{
			public int NCode;

			public IntPtr WParam;

			public IntPtr LParam;

			public HookEventArgs(int nCode, IntPtr wParam, IntPtr lParam)
			{
			}
		}

		protected const int WH_KEYBOARD_LL = 13;

		protected const int WH_MOUSE_LL = 14;

		protected IntPtr hookID;

		private static LowLevelProc procDelegate;

		private bool disposed;

		[CompilerGenerated]
		private static EventHandler<HookEventArgs> m_HookEvent;

		public static event EventHandler<HookEventArgs> HookEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		static HookBase()
		{
		}

		[PreserveSig]
		private static extern void GetMainModuleName(StringBuilder buffer, int bufferSize);

		protected void Intercept(int idHook)
		{
		}

		[AOT.MonoPInvokeCallback(typeof(LowLevelProc))]
		private static IntPtr HookCallbackStatic(int nCode, IntPtr wParam, IntPtr lParam)
		{
			return (IntPtr)0;
		}

		protected abstract void OnHookEvent(HookEventArgs e);

		[PreserveSig]
		protected static extern IntPtr SetWindowsHookEx(int idHook, LowLevelProc lpfn, IntPtr hMod, uint dwThreadId);

		[PreserveSig]
		protected static extern bool UnhookWindowsHookEx(IntPtr hhk);

		[PreserveSig]
		protected static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		[PreserveSig]
		protected static extern IntPtr GetModuleHandle(string lpModuleName);

		~HookBase()
		{
		}

		public void Dispose()
		{
		}
	}
}
