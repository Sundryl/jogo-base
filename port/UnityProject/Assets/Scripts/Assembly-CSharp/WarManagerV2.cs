using System.Collections.Generic;

public class WarManagerV2
{
	private static WarManagerV2 _instance;

	private readonly Dictionary<int, WarV2> wars;

	private readonly List<int> activeWarIds;

	private int nextWarId;

	public static WarManagerV2 Instance => null;

	public IReadOnlyList<int> ActiveWarIds => null;

	public IEnumerable<WarV2> ActiveWars => null;

	public WarV2 GetWar(int id)
	{
		return null;
	}

	public WarV2 GetWarBetween(int stateA, int stateB)
	{
		return null;
	}

	public WarV2 GetActiveWarBetweenParticipants(int stateA, int stateB)
	{
		return null;
	}

	public WarV2 StartWar(WarDeclarationV2 declaration)
	{
		return null;
	}

	private static void CaptureInitialSnapshot(WarV2 war)
	{
	}

	private static State ResolveState(int stateId)
	{
		return null;
	}

	public void EndWar(int warId, WarEndReasonV2 reason)
	{
	}

	public void ForceClearWarsBetween(int stateA, int stateB, WarEndReasonV2 reason)
	{
	}

	public void EndAllWars(WarEndReasonV2 reason = WarEndReasonV2.PlayerForcedClear)
	{
	}

	public void CheckMaximumDurationWars()
	{
	}

	public void LeaveAllWars(int stateId)
	{
	}

	public void Clear()
	{
	}

	public void HandleStateDestroyed(int deadStateId, int conquerorStateId)
	{
	}

	public void RecordDestroyedStateLosses(int deadStateId)
	{
	}

	public void RecordBattleKill(int killerStateId, int victimStateId, float amount)
	{
	}

	public void RecordBattleKill(int warId, int killerStateId, int victimStateId, float amount)
	{
	}

	public bool IsAtWar(int stateId)
	{
		return false;
	}

	public bool IsAtWarWith(int stateA, int stateB)
	{
		return false;
	}

	public IEnumerable<int> GetEnemyStateIds(int stateId)
	{
		return null;
	}

	public WarManagerV2SaveData ToSaveData()
	{
		return null;
	}

	public void LoadSaveData(WarManagerV2SaveData data)
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
