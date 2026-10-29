using System;
using System.Collections.Generic;

[Serializable]
public class DistrictRuntimeSnapshot
{
	public List<District> Districts { get; set; }

	public int NextDistrictId { get; set; }
}
