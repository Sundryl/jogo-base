using System.Collections.Generic;
using System.IO;

public class ReligionManager
{
	private static class CSVHandler
	{
		private static readonly string[] s_LanguageColumns;

		private static List<string> ReadCsvRecords(string csvFilePath)
		{
			return null;
		}

		private static bool UpdateQuoteState(bool insideQuotes, string line)
		{
			return false;
		}

		public static Dictionary<string, List<string>> ReadReligionCSV(string csvFilePath)
		{
			return null;
		}

		public static bool WriteReligionCSV(string csvFilePath, List<Religion> religions, string religionSetName)
		{
			return false;
		}

		private static void WriteTranslationRow(StreamWriter writer, string key, List<string> translations)
		{
		}

		private static List<string> ParseCSVLine(string line)
		{
			return null;
		}

		private static string EscapeCSVField(string field)
		{
			return null;
		}

		public static void ApplyCSVTranslationsToReligions(List<Religion> religions, Dictionary<string, List<string>> csvTranslations, string religionSetName)
		{
		}
	}

	private static ReligionManager instance;

	private readonly List<Religion> religions;

	private readonly List<ReligionSet> religionSets;

	private string basePath;

	private string modPath;

	public static ReligionManager Instance => null;

	private ReligionManager()
	{
	}

	public void Init()
	{
	}

	private string GenerateUniqueReligionId(ReligionSetType setType, string setName, string religionName)
	{
		return null;
	}

	private string CleanIdComponent(string component)
	{
		return null;
	}

	private void LoadReligions()
	{
	}

	private void LoadReligionSetsFromDirectory(string directoryPath, ReligionSetType setType)
	{
	}

	private void LoadReligionSetFromJson(string folderPath, string setName, ReligionSetType setType)
	{
	}

	public string GetWorkshopDirectory()
	{
		return null;
	}

	private void LoadWorkshopReligionSets()
	{
	}

	public bool CheckDuplicateReligionInSet(string religionName, ReligionSet targetReligionSet)
	{
		return false;
	}

	public string SaveReligionDataWithConfirm(Religion religion, ReligionSet targetReligionSet, bool confirmOverwrite = false)
	{
		return null;
	}

	public string SaveReligionData(Religion religion, ReligionSet targetReligionSet)
	{
		return null;
	}

	public List<string> GetModNames()
	{
		return null;
	}

	public IReadOnlyList<Religion> GetAllReligions()
	{
		return null;
	}

	public IReadOnlyList<ReligionSet> GetAllReligionSets()
	{
		return null;
	}

	public Religion GetReligionByUniqueId(string _uniqueId)
	{
		return null;
	}

	public List<Religion> GetReligionsByName(string _name)
	{
		return null;
	}

	public List<ReligionSet> GetReligionSetsByType(ReligionSetType _setType)
	{
		return null;
	}

	public ReligionSet GetReligionSetByName(string _name)
	{
		return null;
	}

	public List<string> GetEnabledReligionIds()
	{
		return null;
	}

	private string GetBaseReligionSetName(Religion religion)
	{
		return null;
	}

	public ReligionSet GetReligionSetForReligion(Religion _religion)
	{
		return null;
	}

	public string GetReligionDisplayName(string religionUniqueId)
	{
		return null;
	}

	public bool IsReligionEnabled(string religionUniqueId)
	{
		return false;
	}

	public void SetReligionEnabled(string religionUniqueId, bool isEnabled)
	{
	}

	public void InitReligionEnabled()
	{
	}

	private bool CheckForReligionIdConflict(string uniqueId, ReligionSetType setType, string setName, string religionName, string folderPath)
	{
		return false;
	}

	private void ShowReligionConflictWarning(string uniqueId, string religionName, string setName, ReligionSetType setType, string currentPath, ReligionSet existingSet)
	{
	}

	private void RemoveExistingReligion(Religion existingReligion, ReligionSet existingSet)
	{
	}

	private string MakeEnglishReligionName(Religion religion)
	{
		return null;
	}

	private bool IsValidEnglishName(string name)
	{
		return false;
	}

	private Religion CloneReligionForExport(Religion sourceReligion, string targetSetName)
	{
		return null;
	}
}
