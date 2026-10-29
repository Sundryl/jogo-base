using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StateRelationsHighlighter
{
	[CompilerGenerated]
	private sealed class _003CBuildAllianceEnemyStates_003Ed__23 : IEnumerable<State>, IEnumerable, IEnumerator<State>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private State _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public StateRelationsHighlighter _003C_003E4__this;

		private HashSet<int> _003Cids_003E5__2;

		private List<State>.Enumerator _003C_003E7__wrap2;

		private HashSet<State>.Enumerator _003C_003E7__wrap3;

		State IEnumerator<State>.Current
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
		public _003CBuildAllianceEnemyStates_003Ed__23(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		private void _003C_003Em__Finally2()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<State> IEnumerable<State>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private readonly string m_ContextKey;

	private readonly HashSet<int> m_CachedAllianceStates;

	private readonly HashSet<int> m_CachedEnemyStates;

	private readonly HashSet<int> m_CachedVassalStates;

	private readonly HashSet<int> m_CachedAllianceEnemyStates;

	private State m_CurrentState;

	private Alliance m_CurrentAlliance;

	private int? m_CachedOverlordId;

	private int? m_HighlightedStateId;

	private int? m_HighlightedAllianceId;

	private bool m_ForceRefresh;

	private Color? m_LastAllianceHighlightColor;

	public StateRelationsHighlighter(string contextKey)
	{
	}

	public void SetState(State state)
	{
	}

	public void SetAlliance(Alliance alliance)
	{
	}

	public void UpdateHighlights(bool forceUpdate = false)
	{
	}

	public void Clear()
	{
	}

	private void UpdateStateHighlights(bool forceUpdate)
	{
	}

	private void UpdateAllianceHighlights(bool forceUpdate)
	{
	}

	private void SyncStateCollection(HashSet<int> cache, IEnumerable<State> states, Color? color, bool forceUpdate)
	{
	}

	private void SyncOverlord(bool forceUpdate)
	{
	}

	private void SyncCurrentState(bool forceUpdate)
	{
	}

	public void BringContextToFront()
	{
	}

	[IteratorStateMachine(typeof(_003CBuildAllianceEnemyStates_003Ed__23))]
	private IEnumerable<State> BuildAllianceEnemyStates()
	{
		return null;
	}

	private void ClearStateData()
	{
	}

	private void ClearAllianceData()
	{
	}

	private void ClearStateIdCache(HashSet<int> cache)
	{
	}

	private void TryClearContext()
	{
	}

	private HashSet<int> BuildStateIdSet(IEnumerable<State> states)
	{
		return null;
	}
}
