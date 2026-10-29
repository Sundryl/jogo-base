using System;
using System.Collections.Generic;

[Serializable]
public class MapCultureSerializeData
{
	public int updateBatchSize;

	public int updateIndex;

	public Dictionary<string, string> cultures;
}
