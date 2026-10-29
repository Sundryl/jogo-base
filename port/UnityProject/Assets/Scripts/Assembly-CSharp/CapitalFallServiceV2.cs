using System;
using System.Collections.Generic;

public static class CapitalFallServiceV2
{
	private const int c_HoldMonths = 1;

	private const float c_MajorCrisisBase = 0.15f;

	private const float c_MajorCrisisScale = 0.85f;

	private const float c_MajorCrisisCap = 0.85f;

	private const float c_AnnexBase = 0.35f;

	private const float c_AnnexScale = 0.45f;

	public const float c_CapitalHeldAnnexRemnantFraction = 0.7f;

	private const int c_SplitMinLandProvinces = 3;

	private const float c_PressureTerritoryWeight = 0.3f;

	private const float c_PressureCasualtyWeight = 0.15f;

	private const float c_PressureStrengthWeight = 0.15f;

	private const float c_PressureEconomyWeight = 0.1f;

	private const float c_PressureDestinyWeight = 0.15f;

	private const float c_PressureFamilyWeight = 0.15f;

	private const float c_PolityCentralizedBonus = 0.1f;

	private const float c_PolityFederalRelief = 0.05f;

	private const float c_FamilyInfluenceSaturation = 400f;

	private const float c_RelocationDestinyPenalty = 0f;

	private const float c_RelocationGoldCostRatio = 0f;

	private static readonly List<CapitalFallIncidentV2> s_Incidents;

	private static int s_SuppressDepth;

	public static void BeginSuppression()
	{
	}

	public static void EndSuppression()
	{
	}

	public static void NotifyCapitalConquered(Province province, State previousOwner, State conqueror)
	{
	}

	private static WarV2 FindTriggerWar(int loserId, int conquerorId, int provinceId)
	{
		return null;
	}

	public static void ProcessMonthly()
	{
	}

	private static bool EnemyHoldsCapital(WarV2 war, CapitalFallIncidentV2 incident)
	{
		return false;
	}

	private static void Resolve(WarV2 war, State state)
	{
	}

	private static bool TryAnnexOutcome(WarV2 war, State state, float pressure)
	{
		return false;
	}

	private static bool TryCivilWarOutcome(WarV2 war, State state, out string blockReason)
	{
		blockReason = null;
		return false;
	}

	private static string RulingFamilySurname(State rebelState)
	{
		return null;
	}

	private static void ApplyRelocationOutcome(WarV2 war, State state, string note)
	{
	}

	private static float ComputeCollapsePressure(WarV2 war, State state)
	{
		return 0f;
	}

	private static float TerritoryLossRatio(WarV2 war, State state)
	{
		return 0f;
	}

	private static float FamilySplitFactor(State state)
	{
		return 0f;
	}

	private static float PolityModifier(State state)
	{
		return 0f;
	}

	private static string PressureDebug(WarV2 war, State state)
	{
		return null;
	}

	private static bool HasPlayerParticipant(WarV2 war)
	{
		return false;
	}

	private static bool HasActiveInternalWar(int stateId)
	{
		return false;
	}

	private static int InitialLandCount(WarV2 war, int stateId)
	{
		return 0;
	}

	private static State ResolveState(int stateId)
	{
		return null;
	}

	public static void CancelIncidentsForWar(int warId)
	{
	}

	public static void Clear()
	{
	}

	public static List<CapitalFallIncidentV2> ExportIncidents()
	{
		return null;
	}

	public static void ImportIncidents(List<CapitalFallIncidentV2> incidents, Func<int, bool> isWarActive)
	{
	}
}
