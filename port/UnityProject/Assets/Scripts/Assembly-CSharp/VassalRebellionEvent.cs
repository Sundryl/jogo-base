using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class VassalRebellionEvent : HistoryEvent
{
	public int VassalStateId { get; set; }

	public int OverlordStateId { get; set; }

	public string RebellionReason { get; set; }

	public float PowerRatio { get; set; }

	public float Destiny { get; set; }

	public int YearsAsVassal { get; set; }

	public VassalRebellionEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public VassalRebellionEvent(State vassal, State overlord, double timestamp, string reason, float powerRatio, float destiny, int yearsAsVassal)
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
