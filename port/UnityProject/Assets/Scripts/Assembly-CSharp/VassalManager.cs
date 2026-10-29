using System.Collections.Generic;
using NodaTime;
using Unity.Profiling;

public class VassalManager
{
	private static readonly ProfilerMarker s_UpdateProfilerMarker;

	private static readonly ProfilerMarker s_ProcessPendingVassalsProfilerMarker;

	private static readonly ProfilerMarker s_MakeVassalProfilerMarker;

	private static VassalManager _instance;

	public Dictionary<int, VassalState> vassalStates;

	private Dictionary<int, List<State>> overlordToVassals;

	private Queue<(State vassal, State overlord)> pendingVassals;

	public static VassalManager Instance => null;

	public bool TryMakeVassal(State vassal, State overlord)
	{
		return false;
	}

	public bool TryMakeVassalImmediate(State vassal, State overlord, out string failureReason)
	{
		failureReason = null;
		return false;
	}

	public void MakeVassal(State vassal, State overlord)
	{
	}

	private bool MakeVassalCore(State vassal, State overlord, out string failureReason)
	{
		failureReason = null;
		return false;
	}

	private bool CanMakeVassal(State vassal, State overlord, bool checkPendingQueue, out string failureReason)
	{
		failureReason = null;
		return false;
	}

	private void RemovePendingVassal(State vassal)
	{
	}

	public void Update()
	{
	}

	public void ReleaseVassal(State vassal)
	{
	}

	public bool IsVassal(State state)
	{
		return false;
	}

	public bool IsOverlord(State state)
	{
		return false;
	}

	public State GetOverlord(State vassal)
	{
		return null;
	}

	public List<State> GetVassals(State overlord)
	{
		return null;
	}

	public VassalState GetVassalState(State vassal)
	{
		return null;
	}

	public bool IsVassalOf(State potentialVassal, State potentialOverlord)
	{
		return false;
	}

	public void Update(LocalDate currentDate)
	{
	}

	private bool IsVassalAtWarWithOverlord(VassalState vassalState)
	{
		return false;
	}

	private bool ShouldRebelAgainstOverlord(VassalState vassalState)
	{
		return false;
	}

	private void TriggerVassalRebellion(State vassal, State overlord, string reason, double vassalizationTime)
	{
	}

	private bool HasSharedAllianceMembers(State vassal, State overlord)
	{
		return false;
	}

	public void Start()
	{
	}

	public void Clear()
	{
	}

	public string Serialize()
	{
		return null;
	}

	public void Deserialize(string json)
	{
	}
}
