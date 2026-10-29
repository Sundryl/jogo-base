using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class AllianceJoinedEvent : HistoryEvent
{
	public int AllianceId { get; set; }

	public int StateId { get; set; }

	public AllianceJoinedEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public AllianceJoinedEvent(Alliance alliance, State state, double timestamp)
		: base(HistoryEventType.Founded, 0.0)
	{
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

	public override List<int> GetRelatedStateIds()
	{
		return null;
	}
}
