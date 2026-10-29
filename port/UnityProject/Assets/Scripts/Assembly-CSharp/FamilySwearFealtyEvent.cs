using Newtonsoft.Json.Linq;

public class FamilySwearFealtyEvent : HistoryEvent
{
	public int FamilyId { get; set; }

	public int OldStateId { get; set; }

	public int NewStateId { get; set; }

	public float InfluenceReductionPercent { get; set; }

	public FamilySwearFealtyEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public FamilySwearFealtyEvent(int familyId, int oldStateId, int newStateId, float oldInfluence, float newInfluence, double timestamp)
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
}
