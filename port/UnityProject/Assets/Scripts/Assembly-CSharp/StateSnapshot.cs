using System;

[Serializable]
public class StateSnapshot
{
	public int provinceCount;

	public int vassalCount;

	public int allianceCount;

	public bool atWar;

	public int totalWars;

	public StateSnapshot()
	{
	}

	public StateSnapshot(State state)
	{
	}

	private int CountWarsFromHistory(State state)
	{
		return 0;
	}
}
