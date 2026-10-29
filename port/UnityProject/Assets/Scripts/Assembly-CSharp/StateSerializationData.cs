using System;
using System.Collections.Generic;

[Serializable]
public class StateSerializationData
{
	public List<string> SerializedStates { get; set; }

	public int UpdateBatchSize { get; set; }

	public int UpdateIndex { get; set; }
}
