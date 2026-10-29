public static class PortRuleUtility
{
	public const int c_MinPortSeaFeatureCells = 20;

	public static bool IsSeaFeatureQualifiedForPort(World _world, int _featureId, int _minSeaFeatureCells = 20)
	{
		return false;
	}

	public static bool IsSeaCellQualifiedForPort(World _world, int _seaCell, int _minSeaFeatureCells = 20)
	{
		return false;
	}

	public static bool TryGetBestAdjacentSeaFeatureForPort(World _world, int _landCell, out int _featureId, int _minSeaFeatureCells = 20)
	{
		_featureId = default;
		return false;
	}

	public static bool IsBurgPortQualified(BurgData _burg, World _world = null, int _minSeaFeatureCells = 20)
	{
		return false;
	}
}
