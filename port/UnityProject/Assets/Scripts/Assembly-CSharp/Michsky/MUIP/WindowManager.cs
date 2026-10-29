using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace Michsky.MUIP
{
	public class WindowManager : MonoBehaviour
	{
		[Serializable]
		public class WindowChangeEvent : UnityEvent<int>
		{
		}

		[Serializable]
		public class WindowItem
		{
			public string windowName;

			public GameObject windowObject;

			public GameObject buttonObject;

			public GameObject firstSelected;
		}

		[CompilerGenerated]
		private sealed class _003CDisablePreviousWindow_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WindowManager _003C_003E4__this;

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
			public _003CDisablePreviousWindow_003Ed__38(int _003C_003E1__state)
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

		public List<WindowItem> windows;

		public int currentWindowIndex;

		private int currentButtonIndex;

		private int newWindowIndex;

		public bool cullWindows;

		public bool initializeButtons;

		private bool isInitialized;

		public WindowChangeEvent onWindowChange;

		private GameObject currentWindow;

		private GameObject nextWindow;

		private GameObject currentButton;

		private GameObject nextButton;

		private Animator currentWindowAnimator;

		private Animator nextWindowAnimator;

		private Animator currentButtonAnimator;

		private Animator nextButtonAnimator;

		private string windowFadeIn;

		private string windowFadeOut;

		private string buttonFadeIn;

		private string buttonFadeOut;

		private float cachedStateLength;

		public bool altMode;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void InitializeWindows()
		{
		}

		public void OpenFirstTab()
		{
		}

		public void OpenWindow(string newWindow)
		{
		}

		public void OpenPanel(string newPanel)
		{
		}

		public void OpenWindowByIndex(int windowIndex)
		{
		}

		public void NextWindow()
		{
		}

		public void PrevWindow()
		{
		}

		public void ShowCurrentWindow()
		{
		}

		public void HideCurrentWindow()
		{
		}

		public void ShowCurrentButton()
		{
		}

		public void HideCurrentButton()
		{
		}

		public void AddNewItem()
		{
		}

		[IteratorStateMachine(typeof(_003CDisablePreviousWindow_003Ed__38))]
		private IEnumerator DisablePreviousWindow()
		{
			return null;
		}
	}
}
