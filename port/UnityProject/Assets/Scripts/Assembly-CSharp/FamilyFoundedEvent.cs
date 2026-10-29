using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class FamilyFoundedEvent : HistoryEvent
{
	public int FamilyId { get; set; }

	public int FounderId { get; set; }

	public string FoundingReason { get; set; }

	public FamilyFoundedEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public FamilyFoundedEvent(int familyId, int founderId, string foundingReason, double timestamp)
		: base(HistoryEventType.Founded, 0.0)
	{
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
