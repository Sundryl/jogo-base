using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Michsky.MUIP;
using TMPro;
using UnityEngine;

public class RoundResultPanel : MonoBehaviour
{
	private class UserResult
	{
		public string openId;

		public long score;

		public long winningPoints;

		public long winningStreakCount;

		public int roundResult;

		public string groupId;
	}

	[CompilerGenerated]
	private sealed class _003CStartCountdown_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoundResultPanel _003C_003E4__this;

		private float _003CremainingTime_003E5__2;

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
		public _003CStartCountdown_003Ed__12(int _003C_003E1__state)
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
	private TextMeshProUGUI rank;

	[SerializeField]
	private TextMeshProUGUI nickname;

	[SerializeField]
	private TextMeshProUGUI score;

	[SerializeField]
	private TextMeshProUGUI worldRank;

	[SerializeField]
	private TextMeshProUGUI worldScore;

	public ButtonManager newGameButton;

	private float m_CountdownTime;

	private Coroutine m_CountdownCoroutine;

	public void ShowResults(Dictionary<string, UserData> userData, List<UserRoundData> userResults)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CStartCountdown_003Ed__12))]
	private IEnumerator StartCountdown()
	{
		return null;
	}

	public void OnNewGameButtonClicked()
	{
	}
}
