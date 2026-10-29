using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class CharacterMarriageEvent : HistoryEvent
{
	public int Character1Id { get; set; }

	public string Character1Name { get; set; }

	public int Character1FamilyId { get; set; }

	public int Character2Id { get; set; }

	public string Character2Name { get; set; }

	public int Character2FamilyId { get; set; }

	public string MarriageType { get; set; }

	public CharacterMarriageEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public CharacterMarriageEvent(int char1Id, int char1FamilyId, int char2Id, int char2FamilyId, string marriageType, double timestamp)
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
