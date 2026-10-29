using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class ReformEvent : HistoryEvent
{
	public int StateId { get; set; }

	public int ReformerId { get; set; }

	public int OldDestiny { get; set; }

	public int NewDestiny { get; set; }

	public bool IsSuccess { get; set; }

	public ReformEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public ReformEvent(State state, int reformerId, int oldDestiny, int newDestiny, bool isSuccess, double timestamp)
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

	private string GetCorruptionLevelKey(float corruption)
	{
		return null;
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
