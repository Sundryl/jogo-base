using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class EndWarEvent : HistoryEvent
{
	public int StateId { get; set; }

	public string TargetStateNames { get; set; }

	public EndWarEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public EndWarEvent(State state, string targetStateNames, double timestamp)
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
