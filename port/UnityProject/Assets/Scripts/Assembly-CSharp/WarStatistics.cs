using System.Collections.Generic;

public class WarStatistics
{
	public Dictionary<int, float> killsByState;

	public Dictionary<int, float> deathsByState;

	public void RecordKillDeath(State killer, State victim, float amount)
	{
	}

	public float GetKills(State state)
	{
		return 0f;
	}

	public float GetDeaths(State state)
	{
		return 0f;
	}
}
