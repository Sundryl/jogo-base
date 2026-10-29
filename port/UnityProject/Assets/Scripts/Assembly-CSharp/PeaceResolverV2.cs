using System.Collections.Generic;

public static class PeaceResolverV2
{
	private const float c_AnnexDominanceRatio = 3f;

	private const int c_AnnexRemnantProvinces = 1;

	private const float c_AnnexIntentRemnantFraction = 0.4f;

	private const float c_VictorScoreThreshold = 50f;

	private const float c_TimeoutDecideGap = 0.1f;

	private const float c_TimeoutDecideScore = 10f;

	public static SettlementPlanV2 BuildSettlementPlan(WarV2 war, WarEndReasonV2 reason)
	{
		return null;
	}

	public static void ExecutePlan(WarV2 war, SettlementPlanV2 plan)
	{
	}

	private static ISettlementEffectV2 BuildEffect(WarGoalInstanceV2 goal)
	{
		return null;
	}

	private static bool IsCivilWar(WarV2 war)
	{
		return false;
	}

	private static SettlementPlanV2 BuildInternalSettlementPlan(WarV2 war, WarEndReasonV2 reason)
	{
		return null;
	}

	private static ISettlementEffectV2 BuildInternalEffect(WarV2 war, WarGoalInstanceV2 goal)
	{
		return null;
	}

	private static void ClassifyOutcomesInternal(WarV2 war, SettlementPlanV2 plan, bool useActualEffects)
	{
	}

	private static WarOutcome ClassifyStateInternal(WarV2 war, SettlementPlanV2 plan, WarParticipantV2 p, bool useActualEffects)
	{
		return WarOutcome.Victory;
	}

	private static bool RebelPrevailed(WarV2 war)
	{
		return false;
	}

	private static void CollectTransfers(WarV2 war, WarGoalInstanceV2 goal, HashSet<int> defenders, bool isAnnexation, Dictionary<int, ProvinceTransferTermV2> acc)
	{
	}

	private static IEnumerable<int> ResolveGoalProvinces(WarV2 war, WarGoalInstanceV2 goal)
	{
		return null;
	}

	private static bool DetermineAnnexation(WarV2 war)
	{
		return false;
	}

	private static bool ShouldDecisiveAnnex(WarV2 war, WarSideV2? victor)
	{
		return false;
	}

	private static bool AttackerSideHoldsDefenderSnapshotCapital(WarV2 war)
	{
		return false;
	}

	private static bool HasAnnexIntent(WarV2 war)
	{
		return false;
	}

	private static void CollectAnnexationTransfers(int loserId, int winnerId, Dictionary<int, ProvinceTransferTermV2> acc)
	{
	}

	private static WarSideV2? DetermineVictorSide(WarV2 war, WarEndReasonV2 reason)
	{
		return null;
	}

	private static void ClassifyOutcomes(WarV2 war, SettlementPlanV2 plan, HashSet<int> attackers, HashSet<int> defenders, WarSideV2? victor, bool includePendingTransfers, bool useActualEffects)
	{
	}

	private static WarOutcome ClassifyState(WarV2 war, SettlementPlanV2 plan, WarParticipantV2 p, HashSet<int> enemySide, bool includePendingTransfers, bool useActualEffects)
	{
		return WarOutcome.Victory;
	}

	private static bool AttackerEnforceableGoalsAllFailed(WarV2 war)
	{
		return false;
	}

	private static int NetGain(WarV2 war, SettlementPlanV2 plan, int stateId, HashSet<int> enemySideAtStart, bool includePendingTransfers)
	{
		return 0;
	}

	private static float LossFraction(WarV2 war, int stateId)
	{
		return 0f;
	}

	private static HashSet<int> SideIds(WarV2 war, WarSideV2 side)
	{
		return null;
	}

	private static bool HasEffectForBeneficiary(SettlementPlanV2 plan, int stateId, bool useActualEffects)
	{
		return false;
	}

	private static bool HasSuccessfulEffectForBeneficiary(SettlementPlanV2 plan, int stateId)
	{
		return false;
	}

	private static bool HasEffectForTarget(SettlementPlanV2 plan, int stateId, bool useActualEffects)
	{
		return false;
	}

	private static void LogOutcomeComparisonIfNeeded(WarV2 war, Dictionary<int, WarOutcome> plannedOutcomes, WarSideV2? plannedWinner, SettlementPlanV2 actualPlan, bool allPlannedChangesApplied)
	{
	}

	private static bool IsBeneficiary(WarV2 war, SettlementPlanV2 plan, int stateId, bool includePendingTransfers)
	{
		return false;
	}

	private static int CurrentOwner(int provinceId)
	{
		return 0;
	}

	private static bool IsLand(int provinceId)
	{
		return false;
	}

	private static int CurrentLandCount(int stateId)
	{
		return 0;
	}

	private static bool IsDeadOrZero(int stateId)
	{
		return false;
	}

	private static State ResolveState(int stateId)
	{
		return null;
	}
}
