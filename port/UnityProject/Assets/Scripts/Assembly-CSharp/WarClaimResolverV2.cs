using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public static class WarClaimResolverV2
{
	[CompilerGenerated]
	private sealed class _003CResolveClaimedProvinceIds_003Ed__4 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private int _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private WarGoalInstanceV2 goal;

		public WarGoalInstanceV2 _003C_003E3__goal;

		private List<Province>.Enumerator _003C_003E7__wrap1;

		private List<int>.Enumerator _003C_003E7__wrap2;

		int IEnumerator<int>.Current
		{
			[DebuggerHidden]
			get
			{
				return 0;
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
		public _003CResolveClaimedProvinceIds_003Ed__4(int _003C_003E1__state)
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
		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public static List<WarClaimAnimationData> CollectWarClaims(WarV2 war)
	{
		return null;
	}

	public static List<WarClaimAnimationData> CollectStateClaims(State state)
	{
		return null;
	}

	private static void AppendGoalClaims(WarV2 war, WarGoalInstanceV2 goal, State relatedState, List<WarClaimAnimationData> claims, HashSet<int> seenProvinceIds)
	{
	}

	public static bool IsTerritorialDemand(WarGoalTypeV2 goalType)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CResolveClaimedProvinceIds_003Ed__4))]
	public static IEnumerable<int> ResolveClaimedProvinceIds(WarGoalInstanceV2 goal)
	{
		return null;
	}

	private static State ResolveState(int stateId)
	{
		return null;
	}
}
