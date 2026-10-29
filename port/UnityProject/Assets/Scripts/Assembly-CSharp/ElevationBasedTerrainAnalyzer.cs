using System.Collections.Generic;

public class ElevationBasedTerrainAnalyzer
{
	public class TerrainClassification
	{
		public bool IsMountainous { get; set; }

		public bool IsPlateau { get; set; }

		public float HighElevationPercentage { get; set; }

		public float VeryHighElevationPercentage { get; set; }

		public float ElevationStandardDeviation { get; set; }

		public float AverageElevation { get; set; }
	}

	public static TerrainClassification AnalyzeTerrain(List<int> elevations, float standardDeviationThreshold = 5f, float plateauElevationThreshold = 60f)
	{
		return null;
	}
}
