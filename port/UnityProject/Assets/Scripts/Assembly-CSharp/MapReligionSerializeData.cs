using System;
using System.Collections.Generic;

[Serializable]
public class MapReligionSerializeData
{
	public int updateBatchSize;

	public int updateIndex;

	public Dictionary<string, string> religions;

	public List<int> holyProvinces;
}
