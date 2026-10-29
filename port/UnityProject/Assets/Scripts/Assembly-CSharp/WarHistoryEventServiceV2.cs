public static class WarHistoryEventServiceV2
{
	public static void RecordWarStarted(WarV2 war)
	{
	}

	public static void RecordWarEnded(WarV2 war, SettlementPlanV2 plan, WarEndReasonV2 reason)
	{
	}

	private static void ResolvePrimaryGoal(WarV2 war, out WarGoalTypeV2 goalType, out int scopeSize)
	{
		goalType = default;
		scopeSize = default;
	}

	private static int DisplayCasualties(WarV2 war, int stateId)
	{
		return 0;
	}

	private static State ResolveState(int stateId)
	{
		return null;
	}
}
