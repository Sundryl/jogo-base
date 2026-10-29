using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class FamilyRebellionSucceededEvent : HistoryEvent
{
	public int FamilyId { get; set; }

	public int RebellionStateId { get; set; }

	public int GovernmentStateId { get; set; }

	public string FamilyName { get; set; }

	public string RebelStateName { get; set; }

	public string GovernmentStateName { get; set; }

	public int ProvinceCount { get; set; }

	public int WarMonths { get; set; }

	public string RebellionReason { get; set; }

	public FamilyRebellionSucceededEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public FamilyRebellionSucceededEvent(int familyId, int rebellionStateId, int governmentStateId, string familyName, string rebelStateName, string governmentStateName, int provinceCount, int warMonths, string rebellionReason, double timestamp)
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

	public override List<int> GetRelatedFamilyIds()
	{
		return null;
	}
}
