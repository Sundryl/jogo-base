public static class WarScoreCalculatorV2
{
	private const float c_OccWeight = 0.5f;

	private const float c_BattleWeight = 0.2f;

	private const float c_GoalWeight = 0.3f;

	private const float c_ForceSettleBase = 75f;

	private const float c_ForceSettleFatigued = 40f;

	public const float WearinessSueThreshold = 0.5f;

	public const float DistressFloor = 0.45f;

	public const float DistressGap = 0.25f;

	private const float c_CasualtyWeight = 0.35f;

	private const float c_StrengthWeight = 0.25f;

	private const float c_TerritoryWeight = 0.25f;

	private const float c_EconomyWeight = 0.15f;

	private const float c_DistressCasualtyWeight = 0.45f;

	private const float c_DistressStrengthWeight = 0.35f;

	private const float c_DistressEconomyWeight = 0.2f;

	private const float c_EcoBurnWeight = 0.5f;

	private const float c_EcoTreasuryWeight = 0.5f;

	private const int c_TreasuryBaselineMonths = 6;

	private const float c_CasualtyMagnitude = 2000f;

	private const float c_CasualtyDisadvantageSlope = 3f;

	private const int c_TerritorySatisfactionProvinces = 3;

	private const int c_WearyTimeFloorStart = 60;

	private const int c_WearyTimeFloorFull = 120;

	private const float c_DecisiveIntentWearinessScale = 0.6f;

	private const float c_CapitalHeldWeariness = 0.15f;

	public static float CalculateWarScore(WarV2 war)
	{
		return 0f;
	}

	public static float OccupationComponent(WarV2 war)
	{
		return 0f;
	}

	public static float BattleComponent(WarV2 war)
	{
		return 0f;
	}

	public static float GoalComponent(WarV2 war)
	{
		return 0f;
	}

	public static float TerritorialComponent(WarV2 war)
	{
		return 0f;
	}

	public static float FatigueFactor(WarV2 war)
	{
		return 0f;
	}

	public static float WarWeariness(WarV2 war, int stateId)
	{
		return 0f;
	}

	private static float CapitalHeldPressure(WarV2 war, int stateId)
	{
		return 0f;
	}

	private static bool HasDecisiveIntent(WarV2 war)
	{
		return false;
	}

	public static float Distress(WarV2 war, int stateId)
	{
		return 0f;
	}

	internal static float CasualtyStress(WarV2 war, WarSideV2 side, WarSideV2 enemy)
	{
		return 0f;
	}

	internal static float StrengthStress(WarV2 war, WarSideV2 side, WarSideV2 enemy)
	{
		return 0f;
	}

	internal static float EconomyStress(State state)
	{
		return 0f;
	}

	private static float TerritorySatisfaction(WarV2 war, int stateId)
	{
		return 0f;
	}

	private static float WearinessTimeFloor(WarV2 war)
	{
		return 0f;
	}

	private static int GainedProvinces(WarV2 war, int stateId)
	{
		return 0;
	}

	private static float SideDeaths(WarV2 war, WarSideV2 side)
	{
		return 0f;
	}

	private static float SideStrength(WarV2 war, WarSideV2 side)
	{
		return 0f;
	}

	private static int CurrentOwner(int provinceId)
	{
		return 0;
	}

	private static bool IsLand(int provinceId)
	{
		return false;
	}

	public static string WearinessDebug(WarV2 war, int stateId)
	{
		return null;
	}

	private static State ResolveState(int stateId)
	{
		return null;
	}

	public static float EffectiveForceSettleThreshold(WarV2 war)
	{
		return 0f;
	}

	public static bool ShouldForceSettle(WarV2 war)
	{
		return false;
	}

	public static bool HasStateCollapsed(WarV2 war, int stateId)
	{
		return false;
	}

	private static float TerritoryLossThreshold(int stateId)
	{
		return 0f;
	}

	private static float SideLossFraction(WarV2 war, WarSideV2 side)
	{
		return 0f;
	}

	private static float SideKills(WarV2 war, WarSideV2 side)
	{
		return 0f;
	}

	private static float AverageGoalProgress(WarV2 war, WarSideV2 side)
	{
		return 0f;
	}

	private static int CurrentProvinceCount(int stateId)
	{
		return 0;
	}
}
