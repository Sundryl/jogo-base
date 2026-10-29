using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class ElectionHeldEvent : HistoryEvent
{
	public int StateId { get; set; }

	public int WinnerId { get; set; }

	public List<int> CandidateIds { get; set; }

	public List<float> VoteShares { get; set; }

	public ElectionHeldEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public ElectionHeldEvent(State state, int winnerId, List<int> candidateIds, List<float> voteShares, double timestamp)
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public override List<int> GetRelatedStateIds()
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
