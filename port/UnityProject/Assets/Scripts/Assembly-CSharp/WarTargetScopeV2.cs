using System;
using System.Collections.Generic;

[Serializable]
public class WarTargetScopeV2
{
	public WarTargetScopeTypeV2 ScopeType;

	public List<int> ProvinceIds;

	public int DistrictId;

	public int RequiredProvinceCount;

	public int SecondaryStateId;
}
