using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Michsky.MUIP;
using TMPro;
using UnityEngine;

public class SwitcherUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetStateCoroutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SwitcherUI _003C_003E4__this;

		public bool state;

		public bool silent;

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
		public _003CSetStateCoroutine_003Ed__8(int _003C_003E1__state)
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

	public SwitchManager switchManager;

	public TextMeshProUGUI descriptionText;

	private float offsetHeight;

	private Action<int, SwitcherUI> onValueChangedCallback;

	public int index;

	public void Initialize(int index, string description, bool initialState, Action<int, SwitcherUI> callback)
	{
	}

	private void OnSwitchValueChanged(bool isOn)
	{
	}

	public void SetState(bool state, bool silent = false)
	{
	}

	[IteratorStateMachine(typeof(_003CSetStateCoroutine_003Ed__8))]
	private IEnumerator SetStateCoroutine(bool state, bool silent)
	{
		return null;
	}
}
