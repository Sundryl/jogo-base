using System;
using System.Collections.Generic;

[Serializable]
public class NavySerializationData
{
	public List<string> SerializedNavies { get; set; }

	public int UpdateIndex { get; set; }

	public int UpdateBatchSize { get; set; }
}
