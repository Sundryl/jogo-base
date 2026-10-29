using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using UnityEngine;

public abstract class HistoryEvent
{
	public int Id { get; set; }

	public HistoryEventType Type { get; set; }

	public double Timestamp { get; set; }

	public HistoryEvent(HistoryEventType type, double timestamp)
	{
	}

	public abstract JObject Serialize();

	public abstract void Deserialize(JObject jobject);

	public abstract string GetDescription(bool isNeedDefaultFont = true, bool isExport = false);

	public abstract string GetDescriptionForState(State state, bool isNeedDefaultFont = true);

	public virtual List<int> GetRelatedStateIds()
	{
		return null;
	}

	public virtual List<int> GetRelatedFamilyIds()
	{
		return null;
	}

	protected Vector3 ParseVector3(string locationString)
	{
		return default;
	}
}
