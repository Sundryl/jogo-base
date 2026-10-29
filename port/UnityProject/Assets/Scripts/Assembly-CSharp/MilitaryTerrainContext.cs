using System.Collections.Generic;

public readonly struct MilitaryTerrainContext
{
	public Dictionary<int, float> BiomeRatios { get; }

	public float MountainWeight { get; }

	public MilitaryTerrainContext(Dictionary<int, float> _biomeRatios, float _mountainWeight)
	{
		BiomeRatios = null;
		MountainWeight = 0f;
	}
}
