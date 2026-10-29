using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class RebellionSuppressedEvent : HistoryEvent
{
	public int RebelStateId { get; set; }

	public int GovernmentStateId { get; set; }

	public string RebelStateName { get; set; }

	public string GovernmentStateName { get; set; }

	public int ProvinceCount { get; set; }

	public int WarDurationMonths { get; set; }

	public RebellionSuppressedEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public RebellionSuppressedEvent(int rebelStateId, int governmentStateId, int provinceCount, int warDuration, double timestamp)
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
