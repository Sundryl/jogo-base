using System.Collections.Generic;
using Newtonsoft.Json;

public class Campaign
{
	public int id;

	public string warKey;

	public int locationProvinceId;

	public double startTime;

	public double endTime;

	public List<int> involvedArmyIds;

	public List<int> involvedStateIds;

	public int sequenceNumber;

	public bool isActive;

	public int warId;

	public int v2WarId;

	[JsonIgnore]
	public bool HasWar => false;

	public War GetWar()
	{
		return null;
	}

	public WarV2 GetWarV2()
	{
		return null;
	}

	public bool IsHiddenFromHistory()
	{
		return false;
	}

	public string GetName(bool isNeedDefaultFont = true)
	{
		return null;
	}
}
