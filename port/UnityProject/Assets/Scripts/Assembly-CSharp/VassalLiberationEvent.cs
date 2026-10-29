using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class VassalLiberationEvent : HistoryEvent
{
	public int VassalStateId { get; set; }

	public int OverlordStateId { get; set; }

	public bool IsOverlordDestroyed { get; set; }

	public VassalLiberationEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public VassalLiberationEvent(State vassal, State overlord, double timestamp, bool overlordDestroyed = false)
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
