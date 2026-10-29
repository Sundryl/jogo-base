using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class LeaderDeathEvent : HistoryEvent
{
	public int StateId { get; set; }

	public int LeaderId { get; set; }

	public string CauseOfDeath { get; set; }

	public int ReignYears { get; set; }

	public LeaderDeathEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public LeaderDeathEvent(State state, int leaderId, string causeOfDeath, int reignYears, double timestamp)
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
