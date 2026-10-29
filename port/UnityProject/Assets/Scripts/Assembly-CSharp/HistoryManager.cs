using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class HistoryManager
{
	private static HistoryManager _instance;

	[JsonIgnore]
	private Dictionary<int, List<int>> stateEventIndices;

	[JsonIgnore]
	private Dictionary<int, List<int>> familyEventIndices;

	[JsonIgnore]
	private Dictionary<int, HistoryEvent> eventById;

	[JsonIgnore]
	private int nextEventId;

	[JsonIgnore]
	private static readonly HashSet<HistoryEventType> s_ExcludedEventTypesForSave;

	public static HistoryManager Instance => null;

	public Dictionary<int, List<HistoryEvent>> HistoryEventsByYear { get; private set; }

	internal static bool IsEventTypeExcludedFromSave(string _eventTypeName)
	{
		return false;
	}

	public void RecordEvent(HistoryEvent historyEvent)
	{
	}

	public void AddEvent(HistoryEvent historyEvent)
	{
	}

	private void AddToIndex(Dictionary<int, List<int>> index, int key, int eventId)
	{
	}

	public List<HistoryEvent> GetStateEvents(int stateId, int? startYear = null, int? endYear = null)
	{
		return null;
	}

	public List<HistoryEvent> GetFamilyEvents(int familyId, int? startYear = null, int? endYear = null)
	{
		return null;
	}

	public void RebuildIndices()
	{
	}

	private bool IsImportantEvent(HistoryEvent historyEvent)
	{
		return false;
	}

	public void Clear()
	{
	}

	public void Start()
	{
	}

	public string GetHistoryInYear(double t)
	{
		return null;
	}

	public string GetHistoryInYear(double t, HashSet<HistoryEventType> allowedEventTypes)
	{
		return null;
	}

	public static HistoryEventType MapToFilterType(HistoryEventType type)
	{
		return HistoryEventType.Founded;
	}

	public string Serialize()
	{
		return null;
	}

	public void Deserialize(string json)
	{
	}

	public static Dictionary<int, List<JObject>> ParseJsonOnly(string json)
	{
		return null;
	}

	public void ApplyParsedData(Dictionary<int, List<JObject>> serializedEvents)
	{
	}

	public void PostLoadSaveData()
	{
	}

	public HistoryEvent DeserializeEvent(JObject jobject)
	{
		return null;
	}

	private HistoryEvent CreateHistoryEvent(HistoryEventType type)
	{
		return null;
	}

	public void ExportHistoryEvents(string filePath = "", bool includeEmergencyMobilize = false)
	{
	}
}
