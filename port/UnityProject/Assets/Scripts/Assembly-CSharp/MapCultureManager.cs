using System.Collections.Generic;

public class MapCultureManager
{
	public int updateBatchSize;

	private int updateIndex;

	public Dictionary<string, MapCulture> cultures;

	private static MapCultureManager m_Instance;

	public static MapCultureManager Instance => null;

	public List<string> GetAllCultureNames()
	{
		return null;
	}

	public string GetCultureName(string _cultureName)
	{
		return null;
	}

	public MapCulture GetCulture(string _cultureName)
	{
		return null;
	}

	public MapCulture GetMapCultureByNameID(string _cultureNameID)
	{
		return null;
	}

	public string Serialize()
	{
		return null;
	}

	public void Deserialize(string json)
	{
	}

	public static ParsedMapCultureData ParseJsonOnly(string json)
	{
		return null;
	}

	public void ApplyParsedData(ParsedMapCultureData data)
	{
	}

	private void PostDeserialize()
	{
	}

	public void Start()
	{
	}

	public void Update()
	{
	}

	private void BatchUpdate()
	{
	}

	public void Clear()
	{
	}

	internal void InitCultures(HashSet<string> currentMapCultureNames)
	{
	}

	private string FindMatchingCultureReferenceName(string mapCultureName)
	{
		return null;
	}

	public List<Trait> GetCultureTraits(string m_CurrentCultureKey)
	{
		return null;
	}

	public string GetRandomCountryKeyExceptKeys(HashSet<string> _excludeKeys1, HashSet<string> _excludeKeys2, string _cultureNameID)
	{
		return null;
	}

	public string GetRandomCountryKeyExceptNames(HashSet<string> _usedStateNames, HashSet<string> _currentValidStateNames, string _cultureNameID)
	{
		return null;
	}

	public void CreateAllCultureLabels()
	{
	}

	private void CreateCultureLabel(MapCulture culture)
	{
	}

	public void ForceUpdateCultureBorder()
	{
	}

	public void ForceUpdateCultureName()
	{
	}

	public void UpdateCultureName(MapCulture culture)
	{
	}

	internal MapCulture GetMapCulture(string cultureName)
	{
		return null;
	}
}
