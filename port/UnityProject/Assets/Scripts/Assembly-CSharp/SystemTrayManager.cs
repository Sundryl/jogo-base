using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class SystemTrayManager : MonoBehaviour
{
	[StructLayout((LayoutKind)0, CharSet = CharSet.Unicode)]
	private struct NOTIFYICONDATA
	{
		public int cbSize;

		public IntPtr hWnd;

		public int uID;

		public int uFlags;

		public int uCallbackMessage;

		public IntPtr hIcon;

		public string szTip;

		public int dwState;

		public int dwStateMask;

		public string szInfo;

		public int uTimeoutAndVersion;

		public string szInfoTitle;

		public int dwInfoFlags;
	}

	private struct POINT
	{
		public int X;

		public int Y;
	}

	private struct MSG
	{
		public IntPtr hwnd;

		public uint message;

		public IntPtr wParam;

		public IntPtr lParam;

		public uint time;

		public POINT pt;
	}

	private class MonoPInvokeCallbackAttribute : Attribute
	{
	}

	private delegate IntPtr WndProcDelegate(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

	[CompilerGenerated]
	private sealed class _003CProcessWindowMessages_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SystemTrayManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CProcessWindowMessages_003Ed__70(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const int WM_USER = 1024;

	private const int WM_TRAYICON = 1025;

	private const int WM_NULL = 0;

	private const int WM_COMMAND = 273;

	private const int WM_SYSCOMMAND = 274;

	private const int WM_RBUTTONDOWN = 516;

	private const int WM_RBUTTONUP = 517;

	private const int WM_LBUTTONDOWN = 513;

	private const int WM_LBUTTONUP = 514;

	private const int NIM_ADD = 0;

	private const int NIM_MODIFY = 1;

	private const int NIM_DELETE = 2;

	private const int NIF_MESSAGE = 1;

	private const int NIF_ICON = 2;

	private const int NIF_TIP = 4;

	private const int NIF_STATE = 8;

	private const int NIF_INFO = 16;

	private const uint TPM_RETURNCMD = 256u;

	private const uint TPM_RIGHTBUTTON = 2u;

	private const uint MF_STRING = 0u;

	private const uint MF_SEPARATOR = 2048u;

	private const int ID_TOGGLE_INTERACTION = 1000;

	private const int ID_DISABLE_WALLPAPER = 1001;

	private const int ID_EXIT = 1002;

	private static readonly IntPtr IDI_APPLICATION;

	private static SystemTrayManager s_Instance;

	private NOTIFYICONDATA m_NotifyIconData;

	private bool m_IsInteractionEnabled;

	private bool m_IsInitialized;

	private IntPtr m_ApplicationIcon;

	private HandleRef m_MainWindowHandle;

	private WndProcDelegate m_WndProcDelegate;

	private static IntPtr m_OldWndProcPtr;

	private IntPtr m_NewWndProcPtr;

	private const float c_MinNotificationInterval = 2f;

	private float m_LastNotificationTime;

	private bool m_IsProcessingMessages;

	public static SystemTrayManager Instance => null;

	[PreserveSig]
	private static extern bool Shell_NotifyIcon(int dwMessage, ref NOTIFYICONDATA lpData);

	[PreserveSig]
	private static extern IntPtr CreatePopupMenu();

	[PreserveSig]
	private static extern bool AppendMenu(IntPtr hMenu, uint uFlags, uint uIDNewItem, string lpNewItem);

	[PreserveSig]
	private static extern bool SetForegroundWindow(IntPtr hWnd);

	[PreserveSig]
	private static extern int TrackPopupMenu(IntPtr hMenu, uint uFlags, int x, int y, int nReserved, IntPtr hWnd, IntPtr prcRect);

	[PreserveSig]
	private static extern bool DestroyMenu(IntPtr hMenu);

	[PreserveSig]
	private static extern bool GetCursorPos(out POINT lpPoint);

	[PreserveSig]
	private static extern IntPtr GetForegroundWindow();

	[PreserveSig]
	private static extern IntPtr ExtractIcon(IntPtr hInst, string lpszExeFileName, uint nIconIndex);

	[PreserveSig]
	private static extern bool PeekMessage(out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);

	[PreserveSig]
	private static extern bool TranslateMessage(ref MSG lpMsg);

	[PreserveSig]
	private static extern IntPtr DispatchMessage(ref MSG lpMsg);

	[PreserveSig]
	private static extern bool PostMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	[PreserveSig]
	private static extern bool DestroyIcon(IntPtr handle);

	[PreserveSig]
	private static extern IntPtr LoadIcon(IntPtr hInstance, IntPtr lpIconName);

	[PreserveSig]
	private static extern IntPtr CallWindowProc(IntPtr lpPrevWndFunc, IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	[PreserveSig]
	private static extern IntPtr SetWindowLongPtr64(HandleRef hWnd, int nIndex, IntPtr dwNewLong);

	[PreserveSig]
	private static extern IntPtr SetWindowLongPtr32(HandleRef hWnd, int nIndex, IntPtr dwNewLong);

	private void Awake()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void InitializeTrayIcon()
	{
	}

	[MonoPInvokeCallback]
	private static IntPtr WndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
	{
		return (IntPtr)0;
	}

	private void ShowContextMenu()
	{
	}

	private void ToggleInteraction()
	{
	}

	private void EnableWallpaperInteraction()
	{
	}

	private void DisableWallpaperInteraction()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessWindowMessages_003Ed__70))]
	private IEnumerator ProcessWindowMessages()
	{
		return null;
	}

	private static IntPtr SetWindowLongPtr(HandleRef hWnd, int nIndex, IntPtr dwNewLong)
	{
		return (IntPtr)0;
	}

	public bool IsInteractionEnabled()
	{
		return false;
	}

	public void ShowNotification(string _title, string _content, int _timeoutMs = 10000)
	{
	}

	public bool EnableTrayIcon()
	{
		return false;
	}

	public void DisableTrayIcon()
	{
	}
}
