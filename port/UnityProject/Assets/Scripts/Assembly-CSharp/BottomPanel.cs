using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Michsky.MUIP;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BottomPanel : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	[CompilerGenerated]
	private sealed class _003CCheckFocusRoutine_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BottomPanel _003C_003E4__this;

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
		public _003CCheckFocusRoutine_003Ed__29(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCheckDesktopFocusRoutine_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BottomPanel _003C_003E4__this;

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
		public _003CCheckDesktopFocusRoutine_003Ed__33(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CFadeOutPanel_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BottomPanel _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

		private float _003CstartAlpha_003E5__3;

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
		public _003CFadeOutPanel_003Ed__50(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CHidePanelDelayed_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BottomPanel _003C_003E4__this;

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
		public _003CHidePanelDelayed_003Ed__52(int _003C_003E1__state)
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

	private static BottomPanel _instance;

	private bool isFocus;

	public ButtonManager SetAsWallPaperButton;

	public ButtonManager SpeedButton;

	public ButtonManager PauseGameButton;

	public GameObject SetAsWallPaperPanel;

	public CanvasScaler canvasScaler;

	[SerializeField]
	private float fadeOutTime;

	[SerializeField]
	private CanvasGroup panelCanvasGroup;

	private Coroutine fadeCoroutine;

	private Coroutine checkDesktopCoroutine;

	private bool isWallpaperMode;

	private bool m_IsEnabled;

	private Canvas[] allCanvases;

	private bool wasDesktopFocused;

	public static BottomPanel Instance => null;

	private void Awake()
	{
	}

	public void OnGameSpeedButtonClicked()
	{
	}

	public void OnEndGameButtonClicked()
	{
	}

	private void UpdateGameSpeedAndPauseButtonText()
	{
	}

	public void RefreshGameSpeedAndPauseButtonText()
	{
	}

	public void OnPauseGameButtonClicked()
	{
	}

	[PreserveSig]
	private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[PreserveSig]
	private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

	[PreserveSig]
	private static extern IntPtr GetForegroundWindow();

	[PreserveSig]
	private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckFocusRoutine_003Ed__29))]
	private IEnumerator CheckFocusRoutine()
	{
		return null;
	}

	private void HandleFocusState(bool isFocused)
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	public void EnableWallPaper(bool isEnabled)
	{
	}

	[IteratorStateMachine(typeof(_003CCheckDesktopFocusRoutine_003Ed__33))]
	private IEnumerator CheckDesktopFocusRoutine()
	{
		return null;
	}

	public void OnSetWallPaperButtonClicked()
	{
	}

	public void OnExitWallPaperButtonClicked()
	{
	}

	public void OnGenerateMapButtonClicked()
	{
	}

	public void GenerateMap()
	{
	}

	public void RefreshLocalization()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void AdjustUI(int taskbarHeight)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void ShowPanel()
	{
	}

	private void HidePanel()
	{
	}

	private bool IsDesktopFocused()
	{
		return false;
	}

	private void EnableUIInteractions()
	{
	}

	public bool GetIsFocus()
	{
		return false;
	}

	private void DisableUIInteractions()
	{
	}

	[IteratorStateMachine(typeof(_003CFadeOutPanel_003Ed__50))]
	private IEnumerator FadeOutPanel()
	{
		return null;
	}

	private void FixedUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CHidePanelDelayed_003Ed__52))]
	private IEnumerator HidePanelDelayed()
	{
		return null;
	}

	public void SetEnabled(bool _enabled)
	{
	}
}
