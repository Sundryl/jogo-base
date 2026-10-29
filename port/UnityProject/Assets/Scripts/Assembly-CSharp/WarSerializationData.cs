using System;
using System.Collections.Generic;

[Serializable]
public class WarSerializationData
{
	public List<string> SerializedWars { get; set; }

	public List<int> ActiveWarIds { get; set; }
}
