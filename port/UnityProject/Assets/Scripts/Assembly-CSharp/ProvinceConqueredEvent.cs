using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class ProvinceConqueredEvent : HistoryEvent
{
	public int StateId { get; set; }

	public int ProvinceId { get; set; }

	public bool IsConquered { get; set; }

	public int ConqueredByStateId { get; set; }

	public ProvinceConqueredEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public ProvinceConqueredEvent(int stateId, Province province, double timestamp, bool isConquered)
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
