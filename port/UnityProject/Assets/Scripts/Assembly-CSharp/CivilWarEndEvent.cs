using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class CivilWarEndEvent : HistoryEvent
{
	public int StateId { get; set; }

	public int WinnerStateId { get; set; }

	public int LoserStateId { get; set; }

	public bool IsRebelVictory { get; set; }

	public WarType CivilWarType { get; set; }

	public int NewLeaderId { get; set; }

	public List<int> PurgedFamilyIds { get; set; }

	public int CasualtiesCount { get; set; }

	public CivilWarEndEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public CivilWarEndEvent(State originalState, State winnerState, State loserState, bool isRebelVictory, WarType civilWarType, int newLeaderId, List<int> purgedFamilies, int casualties, double timestamp)
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
