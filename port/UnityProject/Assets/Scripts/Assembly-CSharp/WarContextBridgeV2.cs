using System;
using System.Collections.Generic;

public static class WarContextBridgeV2
{
	private sealed class SettlementWarFrame
	{
		public WarV2 War;

		public readonly HashSet<int> RecordedOutcomeStateIds;
	}

	private sealed class SettlementWarScope : IDisposable
	{
		private readonly SettlementWarFrame frame;

		private bool disposed;

		public SettlementWarScope(WarV2 war)
		{
		}

		public void Dispose()
		{
		}
	}

	private static readonly Dictionary<WarType, War> s_v2Contexts;

	private static readonly List<SettlementWarFrame> s_settlementWars;

	private static War GetOrCreateContext(WarType warType)
	{
		return null;
	}

	public static IDisposable PushSettlementWar(WarV2 war)
	{
		return null;
	}

	public static void RecordSettlementDestroyedStateLoss(State destroyedState)
	{
	}

	public static bool WasSettlementOutcomeRecorded(int warId, int stateId)
	{
		return false;
	}

	public static War ResolveWarForFamilyFate(State newOwner, State oldOwner)
	{
		return null;
	}

	private static WarType MapWarType(WarV2 war)
	{
		return WarType.Conquest;
	}

	private static bool AreOpposingParticipants(WarV2 war, int stateA, int stateB)
	{
		return false;
	}

	private static WarSideV2 SettlementSideOf(WarV2 war, int stateId)
	{
		return WarSideV2.Attacker;
	}
}
