using System.Collections.Generic;
using Newtonsoft.Json;
using Unity.Profiling;

public class DiplomacyManager
{
	private static readonly ProfilerMarker s_UpdateProfilerMarker;

	private static readonly ProfilerMarker s_ClearCachesProfilerMarker;

	private static readonly ProfilerMarker s_RebuildValidAlliancesProfilerMarker;

	public List<StateRelation> stateRelations;

	private Dictionary<long, StateRelation> stateRelationsDict;

	public List<Alliance> alliances;

	private List<Alliance> validAlliances;

	[JsonIgnore]
	public static int destinyToRebel;

	[JsonIgnore]
	public static int destniyToRebelConnected;

	private static DiplomacyManager _instance;

	[JsonIgnore]
	public List<State> sortedStatesByStrength;

	private Dictionary<long, float> affinityDict;

	private Dictionary<long, bool> isAtWarDict;

	private Dictionary<long, bool> isAtSameWarDict;

	public float strengthSum;

	public double lastRebelDesitinyRecalTimestamp;

	public bool isSuperSuperpowerExists;

	[JsonIgnore]
	public static DiplomacyManager Instance => null;

	private long GetRelationKey(int id1, int id2)
	{
		return 0L;
	}

	public List<Alliance> GetValidAlliances(State state)
	{
		return null;
	}

	public void Start()
	{
	}

	public void Update()
	{
	}

	public string Serialize()
	{
		return null;
	}

	public void Deserialize(string json)
	{
	}

	public static ParsedDiplomacyData ParseJsonOnly(string json)
	{
		return null;
	}

	public void ApplyParsedData(ParsedDiplomacyData data)
	{
	}

	public void AdvanceOneMonth()
	{
	}

	private void SortStatesByStrength()
	{
	}

	public void StartWar(State aggressor, State defender)
	{
	}

	public float GetAffinity(State source, State target)
	{
		return 0f;
	}

	internal void UpdateRelationOnWarEnd(State state, State targetstate)
	{
	}

	public int GetTruceYears(StateRelation relation)
	{
		return 0;
	}

	public bool IsSuperPower(State state)
	{
		return false;
	}

	public bool IsSuperSuperPower(State state)
	{
		return false;
	}

	public StateRelation GetRelation(State state1, State state2)
	{
		return null;
	}

	internal void Clear()
	{
	}

	private static float GetPoliticalSystemAffinity(PoliticalSystem source, PoliticalSystem target)
	{
		return 0f;
	}

	public Alliance CreateAlliance(State state1, State state2)
	{
		return null;
	}

	public void JoinAlliance(Alliance alliance, State state)
	{
	}

	public void EndAllAlliances()
	{
	}
}
