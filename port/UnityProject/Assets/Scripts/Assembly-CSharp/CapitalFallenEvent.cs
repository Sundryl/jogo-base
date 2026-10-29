using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class CapitalFallenEvent : HistoryEvent
{
	public int StateId { get; set; }

	public int ConquerorStateId { get; set; }

	public int CapitalProvinceId { get; set; }

	public CapitalFallenEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public CapitalFallenEvent(int stateId, int conquerorStateId, int capitalProvinceId, double timestamp)
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
