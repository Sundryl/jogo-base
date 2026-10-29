using System.Collections.Generic;

public static class SteamWorkshopPathResolver
{
	public const string c_DefaultAppId = "3035500";

	private const string c_LogTag = "[SteamWorkshopPathResolver]";

	private static readonly string[] s_WindowsCommonSteamRoots;

	private static readonly string[] s_MacCommonSteamRoots;

	private static readonly string[] s_LinuxCommonSteamRoots;

	public static string ResolveWorkshopContentDirectory(string _fallbackAppId = "3035500")
	{
		return null;
	}

	private static string ResolveAppId(string _fallbackAppId, bool _isSteamInitialized)
	{
		return null;
	}

	private static void LogResolvedMethod(string _method, string _appId, string _workshopDirectory, bool _isSteamInitialized)
	{
	}

	private static bool TryResolveFromSteamApi(string _appId, out string _workshopDirectory)
	{
		_workshopDirectory = null;
		return false;
	}

	private static bool TryResolveFromFallbackPaths(string _appId, out string _workshopDirectory)
	{
		_workshopDirectory = null;
		return false;
	}

	private static bool TryResolveFromExecutableDirectory(string _appId, out string _workshopDirectory)
	{
		_workshopDirectory = null;
		return false;
	}

	private static bool TryBuildWorkshopPathFromInstallDir(string _installDir, string _appId, out string _workshopDirectory)
	{
		_workshopDirectory = null;
		return false;
	}

	private static bool TryBuildWorkshopPathFromAnyPath(string _sourcePath, string _appId, out string _workshopDirectory)
	{
		_workshopDirectory = null;
		return false;
	}

	private static void AddPlatformSteamRoots(List<string> _steamRoots)
	{
	}

	private static void AddUniquePath(List<string> _paths, string _candidatePath)
	{
	}

	private static void AddWindowsRegistrySteamRoot(List<string> _steamRoots)
	{
	}
}
