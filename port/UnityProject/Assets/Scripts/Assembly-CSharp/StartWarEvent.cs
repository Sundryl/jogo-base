using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class StartWarEvent : HistoryEvent
{
	public int AggressorStateId { get; set; }

	public int DefenderStateId { get; set; }

	public StartWarEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public StartWarEvent(State aggressor, State defender, double timestamp)
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
