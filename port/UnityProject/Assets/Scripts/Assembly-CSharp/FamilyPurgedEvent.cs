using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class FamilyPurgedEvent : HistoryEvent
{
	public int FamilyId { get; set; }

	public int ConquerorStateId { get; set; }

	public int TotalPurgedCount { get; set; }

	public FamilyPurgedEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public FamilyPurgedEvent(int familyId, int conquerorStateId, int memberCount, int collateralCount, double timestamp)
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
