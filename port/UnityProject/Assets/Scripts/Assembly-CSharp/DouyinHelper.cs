using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DouyinHelper : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGameCountdown_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DouyinHelper _003C_003E4__this;

		private float _003CcountdownTime_003E5__2;

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
		public _003CGameCountdown_003Ed__18(int _003C_003E1__state)
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

	public CanvasGroup HelperPanel;

	public TextMeshProUGUI StateCountText;

	public TextMeshProUGUI CountDownText;

	public Slider StateCountSlider;

	public TextMeshProUGUI TimeLastText;

	public Slider TimeLastSlider;

	private float DesiredGameTime;

	private float LastGameTime;

	private Coroutine m_CountdownCoroutine;

	private bool m_IsCountingDown;

	private void Start()
	{
	}

	public void OnStateCountSliderValueChanged(float value)
	{
	}

	public void OnTimeLastSliderValueChanged(float value)
	{
	}

	public void OnGenerateMapButtonClicked()
	{
	}

	private void OnGameStart()
	{
	}

	public void OnGameFinish(GameFinishType InType = GameFinishType.TimeOver)
	{
	}

	private float CalculateScore(int rank, int totalPlayers)
	{
		return 0f;
	}

	public void StartGameCountdown()
	{
	}

	[IteratorStateMachine(typeof(_003CGameCountdown_003Ed__18))]
	private IEnumerator GameCountdown()
	{
		return null;
	}

	public void CancelCountdown()
	{
	}

	public void OnStartGameButtonClicked()
	{
	}

	private void OnEnable()
	{
	}
}
