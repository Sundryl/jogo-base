using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class CharacterBirthEvent : HistoryEvent
{
	public int CharacterId { get; set; }

	public string CharacterName { get; set; }

	public int FatherId { get; set; }

	public string FatherName { get; set; }

	public int MotherId { get; set; }

	public string MotherName { get; set; }

	public int FamilyId { get; set; }

	public CharacterBirthEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public CharacterBirthEvent(int characterId, int fatherId, int motherId, int familyId, double timestamp)
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
