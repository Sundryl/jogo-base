using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class MajorEventMessageUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDisplayMessages_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MajorEventMessageUI _003C_003E4__this;

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
		public _003CDisplayMessages_003Ed__22(int _003C_003E1__state)
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

	private static MajorEventMessageUI instance;

	private TextMeshProUGUI messageText;

	private Queue<string> normalMessageQueue;

	private Queue<string> highPriorityMessageQueue;

	private bool isDisplaying;

	private Coroutine displayCoroutine;

	private const float HighPriorityDisplayTime = 8f;

	private const float NormalDisplayTime = 1f;

	public RectTransform backgroundImage;

	public RectTransform panel;

	private int previousYear;

	private int currentYear;

	public static MajorEventMessageUI Instance => null;

	private void Start()
	{
	}

	public void AddNormalMessage(string message)
	{
	}

	public void AddHighPriorityMessage(string message)
	{
	}

	public void AddSuggestionMessage(string message)
	{
	}

	public void ClearHighPriorityMessages()
	{
	}

	public void ClearCurrentHighPriorityMessageIfContains(string keyword)
	{
	}

	public void ClearAllMessages()
	{
	}

	private void StopCurrentDisplay()
	{
	}

	[IteratorStateMachine(typeof(_003CDisplayMessages_003Ed__22))]
	private IEnumerator DisplayMessages()
	{
		return null;
	}

	private void UpdateTextHeight()
	{
	}

	private void RefreshLocalization()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
