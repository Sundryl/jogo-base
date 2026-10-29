using System.Collections.Generic;
using FantasyWorld.CharacterSystem;
using NodaTime;
using Unity.Profiling;

public class StateManager
{
	private static readonly ProfilerMarker s_UpdateProfilerMarker;

	private static readonly ProfilerMarker s_ClearStateUnitsProfilerMarker;

	private static readonly ProfilerMarker s_RebuildArmyOwnershipProfilerMarker;

	private static readonly ProfilerMarker s_RebuildNavyOwnershipProfilerMarker;

	private static readonly ProfilerMarker s_SyncStateCountsProfilerMarker;

	private static readonly ProfilerMarker s_BatchUpdateProfilerMarker;

	public int updateBatchSize;

	private int updateIndex;

	private static StateManager _instance;

	public List<State> states;

	private List<State> validStatesForNextMonth;

	public static StateManager Instance => null;

	public List<State> GetstatisticalStates()
	{
		return null;
	}

	public List<State> GetValidStates()
	{
		return null;
	}

	public bool HasFamilyDistributionViewState()
	{
		return false;
	}

	public bool Contains(int StateID)
	{
		return false;
	}

	public string Serialize()
	{
		return null;
	}

	public void Deserialize(string json)
	{
	}

	public static ParsedStateData ParseJsonOnly(string json)
	{
		return null;
	}

	public void ApplyParsedData(ParsedStateData data)
	{
	}

	public void PostLoadSaveData()
	{
	}

	public void Update()
	{
	}

	public void SetStates(List<State> states)
	{
	}

	public void StartStateInitialPopulationPercentage()
	{
	}

	public void Start()
	{
	}

	public void BootstrapInitialNavies()
	{
	}

	private static Province ChooseInitialNavyBuildPort(List<Province> _controlledPorts)
	{
		return null;
	}

	public void Clear()
	{
	}

	public void CaptureHistroy(long t)
	{
	}

	public void ForceUpdateStateBorder()
	{
	}

	public void ForceUpdateStateName()
	{
	}

	public void AdvanceOneYear()
	{
	}

	private void RefreshBlankUnConquerableVisualOwnersYearly()
	{
	}

	private int CalculateUniqueNeighborNormalStateId(State blankUnConquerableState)
	{
		return 0;
	}

	public void RefreshBlankUnConquerableVisualOwnerNow(State state)
	{
	}

	private void RedrawBlankUnConquerableStateProvinces(State state)
	{
	}

	public void AssignRandomUpdateDays(LocalDate currentDate)
	{
	}

	public void UpdateStates(LocalDate currentDate)
	{
	}

	public void CaptureStateColor()
	{
	}

	public void ApplyCurrentStateColor()
	{
	}

	public State CreateRebelState()
	{
		return null;
	}

	public static void AppointLeader(State state, Character newLeader, string successionType = "appointment", Character previousLeader = null)
	{
	}

	private static string GetCorruptionLevelDescription(float corruption)
	{
		return null;
	}

	private static void TriggerReform(State state, Character reformer)
	{
	}

	private void BatchUpdate()
	{
	}

	internal State NewRandomState()
	{
		return null;
	}

	public State GetBlankUnonquerableState()
	{
		return null;
	}

	public State GetBlankConquerableState()
	{
		return null;
	}

	internal State NewRandomBlankUnConquerableState()
	{
		return null;
	}

	public void GenerateBlankUnConquerableStatesAfterWorldInit()
	{
	}

	internal void RefreshStateName()
	{
	}

	internal State GetState(int stateId)
	{
		return null;
	}
}
