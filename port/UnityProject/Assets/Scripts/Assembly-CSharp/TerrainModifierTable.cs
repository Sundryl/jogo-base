using System;
using System.Collections.Generic;

[Serializable]
public class TerrainModifierTable
{
	public Dictionary<string, float> BiomeModifiers { get; set; }

	public float MountainModifier { get; set; }

	public TerrainModifierTable Clone()
	{
		return null;
	}

	public void EnsureInitialized()
	{
	}

	public float Evaluate(Dictionary<int, float> _biomeRatios, float _mountainWeight)
	{
		return 0f;
	}

	private float ResolveBiomeModifier(string _biomeName)
	{
		return 0f;
	}

	public void SetBiomeModifier(string biomeName, float modifier)
	{
	}

	private static void SetModifierValue(Dictionary<string, float> dictionary, string key, float value)
	{
	}
}
