using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class WarV2DeclaredEvent : HistoryEvent
{
	public int AggressorStateId { get; set; }

	public int DefenderStateId { get; set; }

	public int CasusBelliId { get; set; }

	public WarGoalTypeV2 PrimaryGoalType { get; set; }

	public int GoalScopeSize { get; set; }

	public int AttackerCount { get; set; }

	public int DefenderCount { get; set; }

	public WarV2DeclaredEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public WarV2DeclaredEvent(int aggressorId, int defenderId, int casusBelliId, WarGoalTypeV2 primaryGoalType, int goalScopeSize, int attackerCount, int defenderCount, double timestamp)
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
