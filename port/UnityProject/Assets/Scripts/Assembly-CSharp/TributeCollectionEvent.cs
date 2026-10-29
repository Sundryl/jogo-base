using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class TributeCollectionEvent : HistoryEvent
{
	public int VassalStateId { get; set; }

	public int OverlordStateId { get; set; }

	public int TributeAmount { get; set; }

	public TributeCollectionEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public TributeCollectionEvent(State vassal, State overlord, int tributeAmount, double timestamp)
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
