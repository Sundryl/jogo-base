using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupNotification : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public PopupNotification _003C_003E4__this;

		public bool avatarLoadComplete;

		internal void _003CShowNotificationCoroutine_003Eb__0(bool success)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CShowNotificationCoroutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupNotification _003C_003E4__this;

		public string message;

		public string secOpenId;

		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		public Action<PopupNotification> completeCallback;

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
		public _003CShowNotificationCoroutine_003Ed__14(int _003C_003E1__state)
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
	private sealed class _003CAnimateNotification_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupNotification _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

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
		public _003CAnimateNotification_003Ed__15(int _003C_003E1__state)
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
	private sealed class _003CDelayDestroy_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupNotification _003C_003E4__this;

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
		public _003CDelayDestroy_003Ed__17(int _003C_003E1__state)
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

	[SerializeField]
	private float displayDuration;

	[SerializeField]
	private float fadeDuration;

	private TextMeshProUGUI textComponent;

	public Image avatarImage;

	private CanvasGroup canvasGroup;

	private Action<PopupNotification> onComplete;

	private bool isAnimating;

	public float targetY { get; set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void ShowNotification(string message, string secOpenId, Action<PopupNotification> completeCallback)
	{
	}

	[IteratorStateMachine(typeof(_003CShowNotificationCoroutine_003Ed__14))]
	private IEnumerator ShowNotificationCoroutine(string message, string secOpenId, Action<PopupNotification> completeCallback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAnimateNotification_003Ed__15))]
	private IEnumerator AnimateNotification()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayDestroy_003Ed__17))]
	private IEnumerator DelayDestroy()
	{
		return null;
	}
}
