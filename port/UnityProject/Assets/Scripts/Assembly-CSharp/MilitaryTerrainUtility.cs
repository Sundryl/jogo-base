using System.Collections.Generic;

public static class MilitaryTerrainUtility
{
	private static readonly Dictionary<string, string> s_BiomeGroupByName;

	public static string GetBiomeName(int _biomeIndex)
	{
		return null;
	}

	public static string GetBiomeGroup(int _biomeIndex)
	{
		return null;
	}

	public static string GetBiomeGroup(string biomeName)
	{
		return null;
	}

	public static List<string> GetBiomeNamesForGroup(string biomeGroup)
	{
		return null;
	}

	public static MilitaryTerrainContext BuildTerrainContext(Province _province)
	{
		return default;
	}

	public static MilitaryTerrainContext BuildStateTerrainContext(State _state)
	{
		return default;
	}

	private static Dictionary<int, float> BuildBiomeRatios(Dictionary<int, int> _biomeCounts)
	{
		return null;
	}

	private static bool IsMarineBiome(int _biomeIndex)
	{
		return false;
	}

	private static void EnsureProvinceTerrainData(Province _province)
	{
	}

	private static bool IsMountainous(Province _province)
	{
		return false;
	}
}
