using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PopupManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSlideInAnimation_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupNotification popup;

		public PopupManager _003C_003E4__this;

		private RectTransform _003Crect_003E5__2;

		private float _003CtargetX_003E5__3;

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
		public _003CSlideInAnimation_003Ed__16(int _003C_003E1__state)
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
	private sealed class _003CMoveToTarget_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupNotification popup;

		public PopupManager _003C_003E4__this;

		private RectTransform _003Crect_003E5__2;

		private float _003CminDistance_003E5__3;

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
		public _003CMoveToTarget_003Ed__18(int _003C_003E1__state)
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
	private Transform popupContainer;

	[SerializeField]
	private float spacingBetweenPopups;

	[SerializeField]
	private int maxPopups;

	[SerializeField]
	private float moveSpeed;

	[Header("入场动画")]
	[SerializeField]
	private float horizontalOffset;

	[SerializeField]
	private float slideInSpeed;

	private List<PopupNotification> activePopups;

	private Queue<string> messageQueue;

	public static PopupManager Instance { get; private set; }

	private void Awake()
	{
	}

	public void ShowMessage(string message, string secOpenId = null)
	{
	}

	private void CreateNewPopup(string message, string secOpenId)
	{
	}

	[IteratorStateMachine(typeof(_003CSlideInAnimation_003Ed__16))]
	private IEnumerator SlideInAnimation(PopupNotification popup)
	{
		return null;
	}

	private void UpdateTargetPositions()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveToTarget_003Ed__18))]
	private IEnumerator MoveToTarget(PopupNotification popup)
	{
		return null;
	}

	private void OnPopupComplete(PopupNotification popup)
	{
	}
}
