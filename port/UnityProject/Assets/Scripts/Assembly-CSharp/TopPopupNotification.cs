using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class TopPopupNotification : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFadeOut_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TopPopupNotification _003C_003E4__this;

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
		public _003CFadeOut_003Ed__9(int _003C_003E1__state)
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
	private TextMeshProUGUI textComponent;

	[SerializeField]
	private TextMeshProUGUI typeTextComponent;

	[SerializeField]
	private float fadeDuration;

	public RectTransform backgroundImage;

	public RectTransform panel;

	private CanvasGroup canvasGroup;

	private void Awake()
	{
	}

	public void SetMessage(string message, string type = "")
	{
	}

	private void UpdateTextHeight()
	{
	}

	[IteratorStateMachine(typeof(_003CFadeOut_003Ed__9))]
	public IEnumerator FadeOut()
	{
		return null;
	}
}
