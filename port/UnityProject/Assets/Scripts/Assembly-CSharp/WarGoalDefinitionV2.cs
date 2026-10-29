using System.Collections.Generic;

public static class WarGoalDefinitionV2
{
	private const float c_IndependenceHoldRatio = 0.5f;

	public static float CalculateProgress(WarV2 war, WarGoalInstanceV2 goal)
	{
		return 0f;
	}

	public static bool IsAchieved(WarV2 war, WarGoalInstanceV2 goal)
	{
		return false;
	}

	private static HashSet<int> EnemyStateIds(WarV2 war, WarGoalInstanceV2 goal)
	{
		return null;
	}

	private static List<int> EffectiveProvinceRange(WarV2 war, WarGoalInstanceV2 goal, HashSet<int> enemyAtStart)
	{
		return null;
	}

	private static bool IsEnemyHeldNow(int provinceId, HashSet<int> enemySide)
	{
		return false;
	}

	private static bool IsLand(int provinceId)
	{
		return false;
	}

	private static float CalculateInternalProgress(WarV2 war, WarGoalInstanceV2 goal)
	{
		return 0f;
	}

	public static bool IsAchievedInternal(WarV2 war, WarGoalInstanceV2 goal, int minMonths)
	{
		return false;
	}

	private static int InitialLandCount(WarV2 war, int stateId)
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
