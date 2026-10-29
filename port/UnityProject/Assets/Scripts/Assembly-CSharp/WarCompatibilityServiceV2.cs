using System.Collections.Generic;

public static class WarCompatibilityServiceV2
{
	public static bool IsAtWar(State state)
	{
		return false;
	}

	public static bool IsInCivilWar(State state)
	{
		return false;
	}

	public static bool IsAtWarWith(State a, State b)
	{
		return false;
	}

	public static HashSet<State> GetEnemyStates(State state)
	{
		return null;
	}

	public static List<State> GetRegularEnemyStates(State state)
	{
		return null;
	}

	public static List<State> GetRebelStates(State state)
	{
		return null;
	}

	private static bool IsV2RebelPhase(int a, int b)
	{
		return false;
	}

	private static bool IsCivilWarType(WarType warType)
	{
		return false;
	}

	private static void AddV2Enemies(State state, HashSet<State> result, bool includeRebelPhase = true)
	{
	}

	private static State ResolveState(int stateId)
	{
		return null;
	}
}
