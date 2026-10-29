using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public static class WarAIV2
{
	[CompilerGenerated]
	private sealed class _003CEnumerateCandidates_003Ed__20 : IEnumerable<State>, IEnumerable, IEnumerator<State>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private State _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private State attacker;

		public State _003C_003E3__attacker;

		private HashSet<int> _003Cseen_003E5__2;

		private IEnumerator<int> _003C_003E7__wrap2;

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
		public _003CEnumerateCandidates_003Ed__20(int _003C_003E1__state)
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

	private const float c_DeclareWeightThreshold = 0.55f;

	private const int c_MinWarMonthsBeforePeace = 36;

	private const float c_AcceptPeaceLosing = -50f;

	private const float c_AcceptPeaceWinning = 50f;

	private const float c_AnnexIntentAdvantage = 0.75f;

	private const int c_AnnexIntentMaxProvinces = 5;

	private const int c_AnnexIntentRelativeDivisor = 4;

	private const float c_AnnexIntentSelectionChance = 0.8f;

	private const int c_MinGoalsAchievedMonths = 12;

	private const float c_VassalizeAdvantage = 0.65f;

	private const int c_VassalizeMaxProvinces = 14;

	private const float c_ReligiousConversionChance = 0.35f;

	private const int c_MinRebellionMonths = 24;

	private const int c_MinCivilWarMonths = 36;

	public static WarV2 EvaluateDeclaration(State attacker)
	{
		return null;
	}

	private static CasusBelliDefinitionV2 ChooseCasusBelli(State attacker, State defender, CasusBelliDefinitionV2 fallback)
	{
		return null;
	}

	private static CasusBelliDefinitionV2 Usable(int cbId, State attacker, State defender)
	{
		return null;
	}

	public static void EvaluatePeace()
	{
	}

	private static bool CanConsiderDeclaring(State attacker)
	{
		return false;
	}

	private static bool IsSuppressed(State attacker)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CEnumerateCandidates_003Ed__20))]
	private static IEnumerable<State> EnumerateCandidates(State attacker)
	{
		return null;
	}

	private static bool ShouldExemptAffinityForUnification(State attacker, State target)
	{
		return false;
	}

	private static WarEndReasonV2? DecidePeaceReason(WarV2 war)
	{
		return null;
	}

	private static WarEndReasonV2? DecideInternalPeaceReason(WarV2 war)
	{
		return null;
	}

	private static bool AllInternalGoalsAchieved(WarV2 war, int minMonths)
	{
		return false;
	}

	private static int InternalMinMonths(WarV2 war)
	{
		return 0;
	}

	private static bool IsDeadOrZero(int stateId)
	{
		return false;
	}

	private static bool AllEnforceableGoalsAchieved(WarV2 war)
	{
		return false;
	}

	private static bool HasAutonomousDiplomacyParticipant(WarV2 war)
	{
		return false;
	}

	private static State ResolveState(int stateId)
	{
		return null;
	}
}
