using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class AllianceFormedEvent : HistoryEvent
{
	public int AllianceId { get; set; }

	public int State1Id { get; set; }

	public int State2Id { get; set; }

	public AllianceFormedEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public AllianceFormedEvent(Alliance alliance, double timestamp)
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
