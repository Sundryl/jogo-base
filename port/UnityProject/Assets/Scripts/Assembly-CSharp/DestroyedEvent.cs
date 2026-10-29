using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class DestroyedEvent : HistoryEvent
{
	public int StateId { get; set; }

	public int DestroyedByStateId { get; set; }

	public DestroyedEvent()
		: base(HistoryEventType.Founded, 0.0)
	{
	}

	public DestroyedEvent(State state, State destroyedByState, double timestamp)
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
