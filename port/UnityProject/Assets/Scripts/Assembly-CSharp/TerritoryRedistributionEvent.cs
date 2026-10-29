using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class TerritoryRedistributionEvent : HistoryEvent
{
	public int StateId { get; set; }

	public List<int> GainerFamilyIds { get; set; }

	public List<int> LoserFamilyIds { get; set; }

	public List<int> RedistributedProvinceIds { get; set; }

	public List<string> RedistributedProvinceNames { get; set; }

	public int TotalProvincesRedistributed { get; set; }

	public Dictionary<int, int> FamilyTerritoryChanges { get; set; }

	public TerritoryRedistributionEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public TerritoryRedistributionEvent(int stateId, Dictionary<int, int> familyTerritoryChanges, double timestamp)
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

	public string GetDescriptionForFamily(int familyId, bool isNeedDefaultFont = true)
	{
		return null;
	}
}
