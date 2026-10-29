using System.Collections.Generic;

public static class WarProvinceQueryV2
{
	private const int c_MaxSeaApproachProvinceHops = 4;

	public static List<int> GetCedeableProvinces(State attacker, State defender)
	{
		return null;
	}

	public static bool HasCedeableProvince(State attacker, State defender)
	{
		return false;
	}

	public static List<int> GetCedeableSameCultureProvinces(State attacker, State defender)
	{
		return null;
	}

	public static bool HasCedeableSameCultureProvinces(State attacker, State defender, int minCount)
	{
		return false;
	}

	public static int CountLandProvinces(State state)
	{
		return 0;
	}

	public static List<int> BuildConnectedClaimProvinces(State attacker, State defender, int requiredCount)
	{
		return null;
	}

	private static void GrowClaimComponent(Province seed, int defenderStateId, int targetCount, List<int> result, HashSet<int> selectedProvinceIds)
	{
	}

	private static void GrowClaimFrontier(Province distanceAnchor, int defenderStateId, int targetCount, List<int> result, HashSet<int> selectedProvinceIds)
	{
	}

	private static Province SelectCompactFrontierProvince(HashSet<int> frontierProvinceIds, HashSet<int> selectedProvinceIds, Province seed, int defenderStateId)
	{
		return null;
	}

	private static void AppendDefenderLandNeighbors(Province province, int defenderStateId, HashSet<int> selectedProvinceIds, HashSet<int> frontierProvinceIds)
	{
	}

	private static Dictionary<int, int> GetSeaApproachDistances(State attacker, State defender)
	{
		return null;
	}

	private static void SortLandEntries(List<Province> entries, State attacker)
	{
	}

	private static void SortSeaEntries(List<Province> entries, State attacker, Dictionary<int, int> seaApproachDistances)
	{
	}

	private static void SortLegacySeaEntries(List<Province> entries, State attacker)
	{
	}

	private static int CountBorderContactCells(Province province, int attackerStateId)
	{
		return 0;
	}

	private static float GetDistanceToNearestStateProvince(Province province, State state)
	{
		return 0f;
	}

	private static Province GetStateCapitalProvince(State state)
	{
		return null;
	}

	private static float GetProvinceDistance(Province left, Province right)
	{
		return 0f;
	}

	private static bool IsPortProvince(Province province)
	{
		return false;
	}

	private static void AppendUniqueEntries(List<Province> source, List<Province> target, HashSet<int> seenProvinceIds)
	{
	}

	private static bool IsLandAdjacentTo(Province province, int stateId)
	{
		return false;
	}

	private static bool IsCoastal(Province province)
	{
		return false;
	}
}
