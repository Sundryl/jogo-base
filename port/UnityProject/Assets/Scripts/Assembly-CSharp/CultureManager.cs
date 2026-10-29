using System.Collections.Generic;

public class CultureManager
{
	private string basePath;

	private string modPath;

	private Dictionary<string, CultureData> cultures;

	private Dictionary<string, CultureData> modCultures;

	private string currentLanguage;

	private static CultureManager instance;

	public static CultureManager Instance => null;

	public static string DetermineDefaultMapCultureId()
	{
		return null;
	}

	private string GetWorkshopDirectory()
	{
		return null;
	}

	public void Init()
	{
	}

	public void InitCultureEnabledStates()
	{
	}

	private void RefreshLocalization()
	{
	}

	public void SetCultureEnabled(string cultureName, bool enabled)
	{
	}

	public bool IsCultureEnabled(string cultureName)
	{
		return false;
	}

	private void LoadCultures(string basePath, bool isMod = false, bool isWorkShop = false)
	{
	}

	public HashSet<PoliticalSystem> GetPoliticalSystems(string cultureName)
	{
		return null;
	}

	public HashSet<PoliticalSystem> GetAllPoliticalSystems()
	{
		return null;
	}

	private void LoadCultureData(string cultureName, string dirPath)
	{
	}

	private void LoadPoliticalSystems(string cultureName, string dirPath)
	{
	}

	private (Dictionary<string, LocalizedName>, Dictionary<string, int>) LoadNamesFromCsv(string filePath)
	{
		return default;
	}

	public void SetLanguage(string language)
	{
	}

	public List<string> GetStateKeys(string cultureName)
	{
		return null;
	}

	public List<string> GetCityKeys(string cultureName)
	{
		return null;
	}

	public string GetStateName(string cultureName, string key)
	{
		return null;
	}

	public Dictionary<string, string> GetStateNameTranslations(string _cultureName, string _stateNameKey)
	{
		return null;
	}

	public Dictionary<string, string> GetCityNameTranslations(string _cultureName, string _cityNameKey)
	{
		return null;
	}

	public string GetCityName(string cultureName, string key)
	{
		return null;
	}

	public List<string> GetCultureNameID()
	{
		return null;
	}

	public string GetCultureName(string cultureNameID)
	{
		return null;
	}

	public List<string> GetModCultureNames()
	{
		return null;
	}

	public List<string> GetCurrentEnabledCultureNames()
	{
		return null;
	}

	internal string GetRandomCulture()
	{
		return null;
	}

	public Dictionary<string, LocalizedName> GetStateNamesDictionary(string cultureName)
	{
		return null;
	}

	public Dictionary<string, LocalizedName> GetCityNamesDictionary(string cultureName)
	{
		return null;
	}

	public CultureData GetCultureData(string cultureName)
	{
		return null;
	}

	public CultureData GetCultureDataIncludingMods(string cultureName)
	{
		return null;
	}

	public string SaveCultureData(CultureData cultureData, string savePath = null)
	{
		return null;
	}

	private void LoadCultureMilitaryProfile(CultureData cultureData, string cultureName, string dirPath)
	{
	}

	private void SaveCultureMilitaryProfile(CultureData cultureData, string dirPath)
	{
	}

	public bool SaveNamesToCSV(CultureData cultureData, string dirPath = null)
	{
		return false;
	}

	private bool SaveNamesToCSVFile(Dictionary<string, LocalizedName> namesDict, Dictionary<string, int> languageMap, string filePath)
	{
		return false;
	}

	public bool AddLocalizedName(string cultureName, string key, Dictionary<string, string> translations, bool isCity)
	{
		return false;
	}

	public bool RemoveLocalizedName(string cultureName, string key, bool isCity)
	{
		return false;
	}

	public bool ExportCultureTemplate(string targetPath, string templateCultureName = "Leffathou")
	{
		return false;
	}

	public bool ReloadCultureNames(string cultureName)
	{
		return false;
	}

	public void ReloadAllCultureNames()
	{
	}

	public bool ReloadCulture(string cultureName)
	{
		return false;
	}

	public bool ImportNamesFromCSV(string cultureName, string csvFilePath, bool isCity)
	{
		return false;
	}

	internal string FindStateKeyBasedOnName(string name)
	{
		return null;
	}

	internal string FindCityKeyBasedOnName(string name)
	{
		return null;
	}
}
