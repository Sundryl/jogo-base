using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class LeaderAscensionEvent : HistoryEvent
{
	public int StateId { get; set; }

	public int NewLeaderId { get; set; }

	public int PreviousLeaderId { get; set; }

	public string SuccessionType { get; set; }

	public LeaderAscensionEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public LeaderAscensionEvent(State state, int newLeaderId, int previousLeaderId, string successionType, double timestamp)
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
