using System;
using Newtonsoft.Json;

[Serializable]
public class Feature
{
	[JsonProperty]
	public int i { get; set; }

	[JsonProperty]
	public bool isLand { get; set; }

	[JsonProperty]
	public bool isBorder { get; set; }

	[JsonProperty]
	public string Type { get; set; }

	[JsonProperty]
	public string Group { get; set; }

	[JsonProperty]
	public int Cells { get; set; }

	[JsonProperty]
	public int FirstCell { get; set; }

	public Feature(int i, bool isLand, bool isBorder, string type, int cells, int firstCell, string group)
	{
	}

	public Feature()
	{
	}
}
