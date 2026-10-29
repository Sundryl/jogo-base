using System.Collections.Generic;
using UnityEngine;

public static class Biomes
{
	private class BiomeJsonData
	{
		public List<BiomeResource> resources { get; set; }

		public List<BiomeDistributionData> biomeDistribution { get; set; }
	}

	private class BiomeDistributionData
	{
		public string Name { get; set; }

		public List<BiomeResourceData> Resources { get; set; }
	}

	private class BiomeResourceData
	{
		public string Name { get; set; }

		public float Probability { get; set; }
	}

	public static readonly string[] name;

	public static readonly Color[] colors;

	public static readonly int[,] biomesMatrix;

	public static readonly int[] habitability;

	public static readonly int[] cost;

	public static readonly int[] foodProductionEfficiency;

	public static readonly float[] populationInitRange;

	public static readonly float[] SpeedModifier;

	public static readonly float[] CombatEfficiencyModifier;

	public static Color BiomDeepSea;

	public static Color BiomShallowSea;

	private static Dictionary<string, List<BiomeResource>> biomeResources;

	private static Dictionary<string, BiomeResource> biomeResourceDict;

	private static Dictionary<EthnicAttribute, float> ethnicModifiers;

	public static int GetBiomeNameIndex(string biomeName)
	{
		return 0;
	}

	public static void Initialize(string jsonFilePath)
	{
	}

	private static void InitializeEthnicModifiers()
	{
	}

	private static void LoadBiomeResourcesFromJson(string filePath)
	{
	}

	public static int CalculateResourceValue(string biomeName, string resourceName, List<EthnicAttribute> ethnicAttributes)
	{
		return 0;
	}

	public static void PrintBiomeResourceInfo(List<EthnicAttribute> ethnicAttributes)
	{
	}

	public static List<BiomeResource> GetBiomeResources(string biomeName)
	{
		return null;
	}

	public static List<string> GetAllBiomeNames()
	{
		return null;
	}

	public static void Init()
	{
	}
}
