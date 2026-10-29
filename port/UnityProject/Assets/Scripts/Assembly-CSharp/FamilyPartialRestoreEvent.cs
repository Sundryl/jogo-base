using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class FamilyPartialRestoreEvent : HistoryEvent
{
	public int FamilyId { get; set; }

	public int ConquerorStateId { get; set; }

	public List<int> RestoredProvinceIds { get; set; }

	public int TotalHistoricalProvinces { get; set; }

	public FamilyPartialRestoreEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public FamilyPartialRestoreEvent(int familyId, int conquerorStateId, List<int> restoredProvinces, int totalHistorical, float oldInfluence, float newInfluence, double timestamp)
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
