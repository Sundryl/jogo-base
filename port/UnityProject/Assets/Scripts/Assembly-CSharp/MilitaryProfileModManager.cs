using System.Collections.Generic;

public static class MilitaryProfileModManager
{
	public const string MetadataPackageNameKey = "StandalonePackageName";

	public const string MetadataExportSourceKey = "StandaloneExportSource";

	public const string MetadataExportedAtUtcKey = "StandaloneExportedAtUtc";

	private const string c_LocalModsRelativePath = "Mods/Military";

	private const string c_BaseCultureRelativePath = "Base/Culture";

	private const string c_ModCultureRelativePath = "Mods/Culture";

	public static string GetLocalModsRootPath()
	{
		return null;
	}

	public static bool ExportProfilePackage(MilitaryProfile sourceProfile, string requestedDisplayName, string sourceDisplayName, out string packageRootPath, out string resolvedDisplayName, out string errorMessage)
	{
		packageRootPath = null;
		resolvedDisplayName = null;
		errorMessage = null;
		return false;
	}

	public static MilitaryProfile LoadProfilePackage(string packageRootPath)
	{
		return null;
	}

	public static List<MilitaryProfilePackageInfo> GetLocalPackages()
	{
		return null;
	}

	public static List<MilitaryProfilePackageInfo> GetWorkshopPackages()
	{
		return null;
	}

	public static bool HasPackageAtRoot(string packageRootPath)
	{
		return false;
	}

	public static bool TryResolveCultureDirectory(CultureData cultureData, string cultureNameId, out string cultureDirectoryPath)
	{
		cultureDirectoryPath = null;
		return false;
	}

	public static string GetPackageDisplayName(MilitaryProfile profile, string fallbackName)
	{
		return null;
	}

	private static void TryAddPackageInfo(List<MilitaryProfilePackageInfo> packages, HashSet<string> seenPaths, string packageRootPath, MilitaryProfilePackageSource source, string workshopItemId)
	{
	}

	private static bool TryResolveWorkshopCultureDirectory(CultureData cultureData, string cultureNameId, out string cultureDirectoryPath)
	{
		cultureDirectoryPath = null;
		return false;
	}

	private static bool TryExtractWorkshopItemId(string cultureNameId, out string workshopItemId)
	{
		workshopItemId = null;
		return false;
	}

	private static string GetStreamingPath(string relativePath)
	{
		return null;
	}

	private static string ResolvePackageDisplayName(string requestedDisplayName, string fallbackName)
	{
		return null;
	}

	private static string SanitizeFolderName(string requestedName, string fallbackName)
	{
		return null;
	}
}
