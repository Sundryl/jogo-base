using System;
using System.Collections.Generic;

[Serializable]
public class ReligionRuntimeSnapshot
{
	public string SerializedMapReligionManager;

	public Dictionary<int, Dictionary<string, float>> ProvinceReligionDistributions;
}
