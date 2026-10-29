using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class WarV2SettledEvent : HistoryEvent
{
	public int AggressorStateId { get; set; }

	public int DefenderStateId { get; set; }

	public WarEndReasonV2 EndReason { get; set; }

	public WarSideV2 WinnerSide { get; set; }

	public int CededProvinceCount { get; set; }

	public bool IsAnnexation { get; set; }

	public int AttackerCasualties { get; set; }

	public int DefenderCasualties { get; set; }

	public int DurationMonths { get; set; }

	public WarGoalTypeV2 PrimaryGoalType { get; set; }

	public int GoalScopeSize { get; set; }

	public WarV2SettledEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public WarV2SettledEvent(int aggressorId, int defenderId, WarEndReasonV2 endReason, WarSideV2 winnerSide, int cededProvinceCount, bool isAnnexation, int attackerCasualties, int defenderCasualties, int durationMonths, WarGoalTypeV2 primaryGoalType, int goalScopeSize, double timestamp)
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public override List<int> GetRelatedStateIds()
	{
		return null;
	}

	public override JObject Serialize()
	{
		return null;
	}

	public override void Deserialize(JObject jobject)
	{
	}

	public override string GetDescription(bool isNeedDefaultFont = true, bool isExport = false)
	{
		return null;
	}

	public override string GetDescriptionForState(State state, bool isNeedDefaultFont = true)
	{
		return null;
	}
}
