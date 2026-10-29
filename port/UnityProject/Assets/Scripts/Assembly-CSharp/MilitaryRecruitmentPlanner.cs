using System.Collections.Generic;

public static class MilitaryRecruitmentPlanner
{
	public static List<string> BuildUnitSpawnPlan(State _state, IReadOnlyList<Province> _spawnProvinces, string _explicitUnitKey = null)
	{
		return null;
	}

	public static string PickSingleUnitKey(State _state, Province _spawnProvince, string _explicitUnitKey = null)
	{
		return null;
	}

	private static string PickWeightedRandomUnitKey(State _state, Province _spawnProvince, MilitaryProfile _profile, List<MilitaryUnitDefinition> _definitions)
	{
		return null;
	}

	private static float CalculateRecruitmentWeight(MilitaryUnitDefinition _definition, MilitaryTerrainContext _stateTerrainContext, MilitaryTerrainContext _localTerrainContext)
	{
		return 0f;
	}

	private static List<string> DistributeByLargestRemainder(Dictionary<string, float> _weights, int _totalCount)
	{
		return null;
	}

	private static void Shuffle(List<string> _values)
	{
	}
}
