using System.Collections.Generic;

public static class MapEditRuntimePreservation
{
	public static ProvinceExpansionRuntimeSnapshot CaptureProvinceExpansionSnapshot(bool shouldPreserveDistricts = true, bool shouldPreserveReligions = true)
	{
		return null;
	}

	public static void RestoreProvinceExpansionSnapshot(ProvinceExpansionRuntimeSnapshot snapshot)
	{
	}

	public static void InitializeSplitProvinceRuntimeData(Province sourceProvince, Province newProvince)
	{
	}

	public static DistrictRuntimeSnapshot CaptureDistrictSnapshot(bool shouldPreserveDistricts)
	{
		return null;
	}

	public static void RestoreDistrictSnapshot(DistrictRuntimeSnapshot snapshot)
	{
	}

	public static ReligionRuntimeSnapshot CaptureReligionSnapshot(bool shouldPreserveReligions)
	{
		return null;
	}

	public static void RestoreReligionSnapshot(ReligionRuntimeSnapshot snapshot)
	{
	}

	private static HashSet<int> CaptureExistingLandProvinceIds()
	{
		return null;
	}

	private static List<Province> GetNewEditableLandProvinces(HashSet<int> existingLandProvinceIds)
	{
		return null;
	}

	private static void InitializeNewProvinceReligions(List<Province> newProvinces)
	{
	}

	private static void InitializeNewProvinceDistricts(List<Province> newProvinces)
	{
	}

	private static void InitializeReligionForProvince(Province province, Province preferredSourceProvince = null)
	{
	}

	private static void CopyReligionDistribution(Province sourceProvince, Province targetProvince)
	{
	}

	private static Province ResolveBestNeighborReligionSource(Province province)
	{
		return null;
	}

	private static int ResolveBestNeighborDistrictId(Province province)
	{
		return 0;
	}

	private static List<Province> GetNeighborEditableLandProvinces(Province province)
	{
		return null;
	}

	private static void RefreshAffectedStateReligions(IEnumerable<Province> provinces)
	{
	}

	private static bool IsEditableLandProvince(Province province)
	{
		return false;
	}

	private static bool IsDistrictEligibleProvince(Province province)
	{
		return false;
	}
}
