using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Obsolete("已弃用：请使用 HistoryInfoPanel 代替（Assets/Scripts/UI/HistoryInfoPanel.cs）", false)]
internal class HistoryInfoUI : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class _003CReviewHistoryCoroutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HistoryInfoUI _003C_003E4__this;

		private int _003CtotalPoints_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CReviewHistoryCoroutine_003Ed__14(int _003C_003E1__state)
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

	public TextMeshProUGUI HistoryYear;

	public TextMeshProUGUI HistoryText;

	public Slider HistoryTimeSlider;

	private static HistoryInfoUI _instance;

	public Coroutine reviewHistoryCoroutine;

	public bool IsDuringReviewingMode;

	public static HistoryInfoUI Instance => null;

	private void Start()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void BringToFront()
	{
	}

	public void InitHistoryInfo(int stateID)
	{
	}

	public void OnHistoryInfoPanelButtonClose()
	{
	}

	public void OnReviewHistoryButtonClicked()
	{
	}

	[IteratorStateMachine(typeof(_003CReviewHistoryCoroutine_003Ed__14))]
	public IEnumerator ReviewHistoryCoroutine()
	{
		return null;
	}

	public void OnBackToCurrentButtonClicked()
	{
	}

	public void OnViewFullHistoryButtonClicked()
	{
	}

	private void FixedUpdate()
	{
	}

	public void UpdateHistoryTimeLine(float value)
	{
	}

	public double GetHistoryTime()
	{
		return 0.0;
	}
}
