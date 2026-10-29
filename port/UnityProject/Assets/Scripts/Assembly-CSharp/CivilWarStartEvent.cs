using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class CivilWarStartEvent : HistoryEvent
{
	public int StateId { get; set; }

	public List<int> RebelFamilyIds { get; set; }

	public List<int> LoyalistFamilyIds { get; set; }

	public int RebelLeaderId { get; set; }

	public string CivilWarCause { get; set; }

	public int RebelStateId { get; set; }

	public bool IsRestoration { get; set; }

	public int RestoredStateId { get; set; }

	public CivilWarStartEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public CivilWarStartEvent(State state, List<int> rebelFamilies, List<int> loyalistFamilies, int rebelLeaderId, string cause, double timestamp, int rebelStateId = 0)
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public override List<int> GetRelatedStateIds()
	{
		return null;
	}

	public override List<int> GetRelatedFamilyIds()
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
