using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TopPopupManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CProcessMessageQueue_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TopPopupManager _003C_003E4__this;

		private string _003Cmessage_003E5__2;

		private string _003Ctype_003E5__3;

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
		public _003CProcessMessageQueue_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003CCreateAndShowPopup_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TopPopupManager _003C_003E4__this;

		public string message;

		public string type;

		private RectTransform _003Crect_003E5__2;

		private float _003CstartPosition_003E5__3;

		private float _003CelapsedTime_003E5__4;

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
		public _003CCreateAndShowPopup_003Ed__18(int _003C_003E1__state)
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
	private sealed class _003CFadeOutAndDestroy_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TopPopupManager _003C_003E4__this;

		public TopPopupNotification popup;

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
		public _003CFadeOutAndDestroy_003Ed__19(int _003C_003E1__state)
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
	[Header("配置参数")]
	private GameObject popupPrefab;

	[SerializeField]
	private float slideInSpeed;

	private float messageDisplayTime;

	[SerializeField]
	[Header("位置设置")]
	private float startYOffset;

	private float targetYPosition;

	private Queue<string> messageQueue;

	private TopPopupNotification currentPopup;

	private bool isProcessingQueue;

	public Canvas parentCanvas;

	public float popupScale;

	public static TopPopupManager Instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void ShowMessage(string message, string type = "")
	{
	}

	[IteratorStateMachine(typeof(_003CProcessMessageQueue_003Ed__17))]
	private IEnumerator ProcessMessageQueue()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCreateAndShowPopup_003Ed__18))]
	private IEnumerator CreateAndShowPopup(string message, string type = "")
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFadeOutAndDestroy_003Ed__19))]
	private IEnumerator FadeOutAndDestroy(TopPopupNotification popup)
	{
		return null;
	}
}
