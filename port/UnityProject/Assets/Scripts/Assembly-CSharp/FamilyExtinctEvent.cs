using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class FamilyExtinctEvent : HistoryEvent
{
	public int FamilyId { get; set; }

	public string ExtinctionReason { get; set; }

	public int LastMemberId { get; set; }

	public string LastMemberName { get; set; }

	public FamilyExtinctEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public FamilyExtinctEvent(int familyId, string extinctionReason, int lastMemberId, double timestamp)
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
