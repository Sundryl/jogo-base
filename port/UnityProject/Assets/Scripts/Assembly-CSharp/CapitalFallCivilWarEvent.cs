using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class CapitalFallCivilWarEvent : HistoryEvent
{
	public int StateId { get; set; }

	public int RebelStateId { get; set; }

	public string RebelFamilyName { get; set; }

	public CapitalFallCivilWarEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public CapitalFallCivilWarEvent(int stateId, int rebelStateId, string rebelFamilyName, double timestamp)
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
