using System;
using System.Collections.Generic;

[Serializable]
public class WarManagerV2SaveData
{
	public int NextWarId;

	public List<WarV2> Wars;

	public List<int> ActiveWarIds;

	public List<CapitalFallIncidentV2> CapitalFallIncidents;
}
