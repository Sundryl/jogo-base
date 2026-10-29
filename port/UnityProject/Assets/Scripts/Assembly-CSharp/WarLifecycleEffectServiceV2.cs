public static class WarLifecycleEffectServiceV2
{
	public static void ApplyWarStarted(WarV2 war)
	{
	}

	private static void PlayClaimedProvinceMarkers(WarV2 war)
	{
	}

	public static void ApplyWarEnded(WarV2 war, SettlementPlanV2 plan, WarEndReasonV2 reason)
	{
	}

	private static WarParticipationType ToParticipationType(WarRoleV2 role)
	{
		return WarParticipationType.Initiator;
	}

	private static State ResolveState(int stateId)
	{
		return null;
	}
}
