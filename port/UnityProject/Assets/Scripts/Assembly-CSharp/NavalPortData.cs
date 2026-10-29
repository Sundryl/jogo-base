using System.Collections.Generic;

public class NavalPortData
{
	public int portProvinceId;

	public int landOwnerStateId;

	public int occupierStateId;

	public float occupationValue;

	public int seaAnchorCell;

	public int seaProvinceId;

	public int seaFeatureId;

	public readonly HashSet<int> portCells;
}
