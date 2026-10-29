using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MergeUpdateLog : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRefreshMergedLogNextFrame_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MergeUpdateLog _003C_003E4__this;

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
		public _003CRefreshMergedLogNextFrame_003Ed__6(int _003C_003E1__state)
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

	private LocalizationText m_LocalizationText;

	public List<string> logKeyList;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshMergedLogNextFrame_003Ed__6))]
	private IEnumerator RefreshMergedLogNextFrame()
	{
		return null;
	}

	private void RefreshMergedLog()
	{
	}
}
