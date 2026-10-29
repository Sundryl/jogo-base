using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class RebellionSucceededEvent : HistoryEvent
{
	public int RebellionStateId { get; set; }

	public int GovernmentStateId { get; set; }

	public string RebelStateName { get; set; }

	public string GovernmentStateName { get; set; }

	public int ProvinceCount { get; set; }

	public int WarMonths { get; set; }

	public RebellionSucceededEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public RebellionSucceededEvent(int rebellionStateId, int governmentStateId, string rebelStateName, string governmentStateName, int provinceCount, int warMonths, double timestamp)
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
