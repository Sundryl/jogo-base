using System;
using System.Collections.Generic;

[Serializable]
public class DistrictSerializationData
{
	public List<string> SerializedDistricts { get; set; }

	public int NextDistrictId { get; set; }
}
