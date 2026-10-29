using System;

[Serializable]
public class LeaderHistoryRecord
{
	public int leaderId;

	public string leaderName;

	public string leaderTitle;

	public int leaderOrder;

	public double reignStartTime;

	public double reignEndTime;

	public string successionType;

	public string endType;

	public StateSnapshot startSnapshot;

	public StateSnapshot endSnapshot;

	public int warsInitiated;

	public int warsDefended;

	public int warsAsAlly;

	public int warsWon;

	public int warsLost;

	public int warsDrawn;

	public int conquestWars;

	public int liberationWars;

	public int civilWars;

	public int vassalizationWars;

	public int rebelWars;

	public int regularRebelWars;

	public int familyRebelWars;

	public int rebellionsSuppressed;

	public int regularRebellionsSuppressed;

	public int familyRebellionsSuppressed;

	public int alliancesFormed;

	public int diplomacyEvents;

	public float GetReignYears()
	{
		return 0f;
	}

	public bool IsStillReigning()
	{
		return false;
	}

	public StateSnapshot GetCurrentSnapshot(State state)
	{
		return null;
	}

	public int GetProvinceChange(State currentState = null)
	{
		return 0;
	}

	public int GetProvincesGained(State currentState = null)
	{
		return 0;
	}

	public int GetProvincesLost(State currentState = null)
	{
		return 0;
	}

	public int GetVassalChange(State currentState = null)
	{
		return 0;
	}

	public int GetAllianceChange(State currentState = null)
	{
		return 0;
	}

	public int GetWarChange(State currentState = null)
	{
		return 0;
	}

	public int GetMaxTerritory(State currentState = null)
	{
		return 0;
	}
}
