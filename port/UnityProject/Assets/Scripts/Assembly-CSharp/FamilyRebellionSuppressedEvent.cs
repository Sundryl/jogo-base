using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class FamilyRebellionSuppressedEvent : HistoryEvent
{
	public int FamilyId { get; set; }

	public int RebelStateId { get; set; }

	public int GovernmentStateId { get; set; }

	public int WarDurationMonths { get; set; }

	public FamilyRebellionSuppressedEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public FamilyRebellionSuppressedEvent(int familyId, int rebelStateId, int governmentStateId, int warDuration, double timestamp)
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
