using System;
using System.Collections.Generic;

[Serializable]
public class ProvinceExpansionRuntimeSnapshot
{
	public HashSet<int> ExistingLandProvinceIds;

	public DistrictRuntimeSnapshot DistrictSnapshot;

	public ReligionRuntimeSnapshot ReligionSnapshot;
}
