using System.Collections.Generic;

public class CampaignManager
{
	private static CampaignManager _instance;

	public List<Campaign> campaigns;

	private Dictionary<string, Dictionary<int, int>> stateProvinceCampaignCount;

	private readonly List<int> activeCampaignIds;

	private int sweepCursor;

	private const int c_SweepChecksPerFrame = 8;

	private const string c_UnresolvedWarKey = "__unresolved__";

	public static CampaignManager Instance => null;

	public int StartCampaign(Province province)
	{
		return 0;
	}

	public void EndCampaign(int campaignIndex)
	{
	}

	public string Serialize()
	{
		return null;
	}

	private void ResolveBelongingWar(Province province, Campaign campaign)
	{
	}

	private static string BuildV2WarKey(WarV2 war)
	{
		return null;
	}

	public void Deserialize(string json)
	{
	}

	public static CampaignSerializationData ParseJsonOnly(string json)
	{
		return null;
	}

	public void ApplyParsedData(CampaignSerializationData data)
	{
	}

	public void Update()
	{
	}

	private void SweepActiveCampaigns()
	{
	}

	public void Clear()
	{
	}

	public Campaign GetCampaignByID(int id)
	{
		return null;
	}
}
