using System.Collections.Generic;
using Newtonsoft.Json;

public class War
{
	private const float c_BaseArmyLossRatio = 0.7f;

	private const float c_BaseTerritoryLossRatio = 0.5f;

	private const bool c_CapitalLossMatters = true;

	public Dictionary<int, int> m_InitialProvinceCount;

	public Dictionary<int, int> m_InitialCapitalProvinceIds;

	private bool m_IsCivilWarEndEventRecorded;

	[JsonIgnore]
	public State aggressor;

	[JsonIgnore]
	public State defender;

	public int aggressorID;

	public int defenderID;

	public WarState warState;

	public WarType warType;

	public bool IsFightToTheEnd;

	public double startTime;

	public WarStatistics warStats;

	public int minMonthBeforeWarEnd;

	[JsonIgnore]
	public List<State> aggressorAllies;

	[JsonIgnore]
	public List<State> defenderAllies;

	[JsonIgnore]
	public HashSet<State> aggressorAlliesHashSet;

	[JsonIgnore]
	public HashSet<State> defenderAlliesHashSet;

	public List<int> aggressorAlliesID;

	public List<int> defenderAlliesID;

	public int id;

	private float GetArmyLossThreshold(State _state)
	{
		return 0f;
	}

	private float GetTerritoryLossThreshold(State _state)
	{
		return 0f;
	}

	private bool IsCapitalCritical(State _state)
	{
		return false;
	}

	private void InitializeWarState(State _state)
	{
	}

	private string FormatStateInfo(State _state)
	{
		return null;
	}

	private string FormatStateList(IEnumerable<State> _states)
	{
		return null;
	}

	public int GetMinMonthBeforeWarEnd()
	{
		return 0;
	}

	public string Serialize()
	{
		return null;
	}

	public static War Deserialize(string json)
	{
		return null;
	}

	public War()
	{
	}

	public War(State aggressor, State defender, WarType warType)
	{
	}

	public bool IsBlankConquerableWar()
	{
		return false;
	}

	public void Start(State aggressor, State defender, WarType warType)
	{
	}

	private void InitializeWarState()
	{
	}

	public bool IsWarValid()
	{
		return false;
	}

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

	public void End(bool isForceEnd = false)
	{
	}

	private void HandleFamilyRebellionEnd()
	{
	}

	private void HandleRegularRebellionEnd()
	{
	}

	private void RecordFamilyRebellionSuppressed()
	{
	}

	private void RecordRegularRebellionSuppressed()
	{
	}

	private void RecordRegularRebellionSucceeded()
	{
	}

	private void RecordFamilyRebellionSucceeded()
	{
	}

	private void HandleCivilWarEnd(bool isDefenderDefeated, bool isAggressorDefeated)
	{
	}

	private void RecordCivilWarEndEvent(State winner, State loser)
	{
	}

	private void HandleSuccessionClaim(State winner, State loser)
	{
	}

	private void HandlePoliticalReform(State winner, State loser)
	{
	}

	private void HandleIndependence(State winner, State loser)
	{
	}

	private void HandleRulerReplacement(State winner, State loser)
	{
	}

	private void HandlePreVassalization(State futureVassal)
	{
	}

	public int GetWarYear()
	{
		return 0;
	}

	public int GetWarMonth()
	{
		return 0;
	}

	public string GetWarName()
	{
		return null;
	}

	public float GetAggressorArmyCount()
	{
		return 0f;
	}

	public float GetDefenderArmyCount()
	{
		return 0f;
	}

	internal void PostLoadSaveData()
	{
	}

	public bool CheckStateDefeat(State _state)
	{
		return false;
	}

	public bool IsCivilWarType()
	{
		return false;
	}

	private bool CheckCivilWarDefeat(State _state)
	{
		return false;
	}

	public bool CanNegotiateIndependence()
	{
		return false;
	}

	public bool UsesSpecialMaximumDurationRules()
	{
		return false;
	}

	public bool ShouldForceEndByMaximumDuration()
	{
		return false;
	}

	public bool CanbeEnded(State initiator)
	{
		return false;
	}
}
