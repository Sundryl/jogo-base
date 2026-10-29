using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class FamilyRiseEvent : HistoryEvent
{
	public int StateId { get; set; }

	public int FamilyId { get; set; }

	public int PreviousRulingFamilyId { get; set; }

	public string RiseReason { get; set; }

	public FamilyRiseEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public FamilyRiseEvent(State state, int familyId, int previousFamilyId, string riseReason, double timestamp)
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
