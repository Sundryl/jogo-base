using System.Collections.Generic;
using Newtonsoft.Json;

public class BurgData
{
	public int i;

	public string name;

	public string nameKey;

	public string cultureName;

	public Dictionary<string, string> translateNames;

	public int cell;

	public int culture;

	public int state;

	public int feature;

	public int population;

	public string type;

	public int capital;

	public int port;

	public int province;

	public bool isLand;

	[JsonIgnore]
	public bool isLocked;

	public bool isValid;

	public bool IsVisible()
	{
		return false;
	}
}
