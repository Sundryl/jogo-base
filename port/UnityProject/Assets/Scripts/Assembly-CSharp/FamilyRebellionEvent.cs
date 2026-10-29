using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class FamilyRebellionEvent : HistoryEvent
{
	public int StateId { get; set; }

	public int FamilyId { get; set; }

	public int LeaderId { get; set; }

	public List<int> ProvinceIds { get; set; }

	public string RebellionReason { get; set; }

	public int NewStateId { get; set; }

	public bool IsRestoration { get; set; }

	public int RestoredStateId { get; set; }

	public FamilyRebellionEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public FamilyRebellionEvent(State state, int familyId, int leaderId, List<int> provinceIds, string rebellionReason, double timestamp, int newStateId = 0)
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
