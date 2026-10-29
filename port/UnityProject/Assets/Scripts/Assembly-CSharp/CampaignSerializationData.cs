using System;
using System.Collections.Generic;

[Serializable]
public class CampaignSerializationData
{
	public List<Campaign> Campaigns { get; set; }

	public Dictionary<string, Dictionary<int, int>> StateProvinceCampaignCount { get; set; }
}
