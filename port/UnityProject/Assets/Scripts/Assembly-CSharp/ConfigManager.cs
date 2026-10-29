using System.Collections.Generic;
using UnityEngine;

public class ConfigManager : MonoBehaviour
{
	private static ConfigManager s_Instance;

	private static bool s_IsSaveConfigWriteDisabled;

	private static bool s_HasLoggedSaveConfigWriteError;

	public static bool isCanSaveConfig;

	public static GameConfig gameConfig;

	private const string CONFIG_FILE_NAME = "gameConfig.json";

	private const string CONFIG_FILE_NAME_DY = "gameConfigDyV2.json";

	public static ConfigManager Instance => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void BackupSaves()
	{
	}

	public void SaveConfig()
	{
	}

	public void LoadConfig()
	{
	}

	public HashSet<string> GetEnabledCultureIDs()
	{
		return null;
	}

	public HashSet<string> GetEnabledReligionIDs()
	{
		return null;
	}
}
