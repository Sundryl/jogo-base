using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using LiveWallpaperCore;
using UnityEngine;
using UnityEngine.Events;

public class LiveWallpaper
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CUpdateWindowPosition4_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LiveWallpaper _003C_003E4__this;

		public DisplayMonitor display;

		public IntPtr WindowHandle;

		public IntPtr WorkerWHandle;

		private int _003CdisplayWidth_003E5__2;

		private int _003CdisplayHeight_003E5__3;

		private int _003CvirtualScreenLeft_003E5__4;

		private int _003CvirtualScreenTop_003E5__5;

		private int _003CoffsetX_003E5__6;

		private int _003CoffsetY_003E5__7;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CEnableAsync_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LiveWallpaper _003C_003E4__this;

		public int displayIndex;

		private IntPtr _003CworkerWHandle_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private const string PROGMAN = "Progman";

	private const string WORKERW = "WorkerW";

	private const string SHELLDLL_DEF_VIEW = "SHELLDLL_DefView";

	private const string WALLPAPER_COMMANDLINE = "-wallpaper";

	private const uint SMTO_NORMAL = 0u;

	[SerializeField]
	private Rectangle m_positionBeforeLiveWallpaper;

	[SerializeField]
	private WindowStylesFlags m_flagsBeforeLiveWallpaper;

	[SerializeField]
	private bool m_isCurrentlyInWallpaperMode;

	[SerializeField]
	private DisplayMonitor m_currentScreen;

	private static LiveWallpaper m_main;

	private static readonly bool m_startedByCommandLine;

	private static List<DisplayMonitor> s_displays;

	public int pregameWidth;

	public int pregameHeight;

	private int displayIndex;

	public IntPtr WindowHandle { get; protected set; }

	public UnityAction OnLiveWallpaperStateChanged { get; set; }

	public static bool StartedByCommandLine => false;

	public static bool IsCurrentlyInWallpaperModeOutOfSync { get; private set; }

	public static bool IsCurrentPlatformSupported => false;

	public virtual bool IsCurrentlyInWallpaperMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public DisplayMonitor Screen { get; protected set; }

	public static IntPtr WorkerWHandle => (IntPtr)0;

	public static LiveWallpaper Main => null;

	[MonoPInvokeCallback(typeof(User32.MonitorEnumProc))]
	private static bool MonitorEnumProc(IntPtr hMonitor, IntPtr hdcMonitor, ref Rectangle lprcMonitor, IntPtr dwData)
	{
		return false;
	}

	public static DisplayMonitor[] GetDisplays()
	{
		return null;
	}

	public void SetToDisplay(DisplayMonitor display)
	{
	}

	private void UpdateWindowPosition2(DisplayMonitor display, IntPtr WindowHandle, IntPtr WorkerWHandle)
	{
	}

	private void RefreshDesktop()
	{
	}

	private void UpdateWindowPosition(DisplayMonitor display)
	{
	}

	private void UpdateWindowPosition3(DisplayMonitor display, IntPtr WindowHandle, IntPtr WorkerWHandle)
	{
	}

	[AsyncStateMachine(typeof(_003CUpdateWindowPosition4_003Ed__44))]
	private Task UpdateWindowPosition4(DisplayMonitor display, IntPtr WindowHandle, IntPtr WorkerWHandle)
	{
		return null;
	}

	[PreserveSig]
	public static extern IntPtr GetWorkerW();

	[PreserveSig]
	public static extern IntPtr GetWorkerW2();

	public LiveWallpaper(IntPtr windowHandle)
	{
	}

	[AsyncStateMachine(typeof(_003CEnableAsync_003Ed__53))]
	public virtual Task EnableAsync(int displayIndex = -1)
	{
		return null;
	}

	[Conditional("UNITY_STANDALONE_WIN")]
	public virtual void Enable(int displayIndex = -1)
	{
	}

	[Conditional("UNITY_STANDALONE_WIN")]
	public virtual void Disable()
	{
	}

	protected virtual void CallLiveWallpaperStateChanged()
	{
	}

	protected void ThrowExceptionIfStartedByCommandLine()
	{
	}
}
