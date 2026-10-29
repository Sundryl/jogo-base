using System;
using System.Collections.Generic;

[Serializable]
public class ArmySerializationData
{
	public List<string> SerializedArmies { get; set; }

	public int ObjectCount { get; set; }

	public int UpdateIndex { get; set; }

	public int UpdateBatchSize { get; set; }
}
