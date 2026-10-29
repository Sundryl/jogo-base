using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class WarV2
{
	public int Id;

	public int PrimaryAttackerId;

	public int PrimaryDefenderId;

	public int CasusBelliId;

	public bool IsInternalWar;

	public WarType LegacyWarType;

	public int RebelStateId;

	public int MotherStateId;

	public List<WarParticipantV2> Participants;

	public List<WarParticipantV2> DestroyedParticipants;

	public List<WarGoalInstanceV2> Goals;

	public double StartTime;

	public Dictionary<int, float> KillsByState;

	public Dictionary<int, float> DeathsByState;

	public Dictionary<int, int> InitialProvinceCountByState;

	public Dictionary<int, int> InitialCapitalProvinceByState;

	public Dictionary<int, int> InitialOwnerByProvinceId;

	public HashSet<int> ResolvedCapitalFallStateIds;

	[JsonIgnore]
	public int AnnexationConquerorId;

	[JsonIgnore]
	public IEnumerable<WarParticipantV2> ParticipantsForSettlement => null;

	public bool IsParticipant(int stateId)
	{
		return false;
	}

	public bool IsBlankConquerableWar()
	{
		return false;
	}

	public WarSideV2 SideOf(int stateId)
	{
		return WarSideV2.Attacker;
	}

	public IEnumerable<int> ParticipantIdsOnSide(WarSideV2 side)
	{
		return null;
	}

	public int GetWarMonth()
	{
		return 0;
	}

	public void RecordKillDeath(int killerStateId, int victimStateId, float amount)
	{
	}
}
