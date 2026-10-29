using System.Collections.Generic;

namespace FantasyWorld.CharacterSystem
{
	public static class OfficialTitlePresets
	{
		private static readonly Dictionary<string, Dictionary<string, OfficialTitleEntry>> s_Presets;

		private static readonly string[] s_PresetIds;

		public static IReadOnlyList<string> GetPresetIds()
		{
			return null;
		}

		public static OfficialTitleProfile CreateRecommendedProfileForCulture(string _cultureNameId)
		{
			return null;
		}

		public static string NormalizePresetId(string _presetId)
		{
			return null;
		}

		public static OfficialTitleProfile CreateProfile(string _presetId)
		{
			return null;
		}

		public static OfficialTitleProfile ClonePreset(string _presetId)
		{
			return null;
		}

		public static OfficialTitleEntry GetEntry(string _presetId, PoliticalSystem _politicalSystem, string _officeId)
		{
			return null;
		}

		internal static bool TryGetEntry(string _presetId, PoliticalSystem _politicalSystem, string _officeId, out OfficialTitleEntry _entry)
		{
			_entry = null;
			return false;
		}

		internal static bool TryGetAnyEntry(string _presetId, string _officeId, out OfficialTitleEntry _entry)
		{
			_entry = null;
			return false;
		}

		private static Dictionary<string, Dictionary<string, OfficialTitleEntry>> CreatePresets()
		{
			return null;
		}

		private static Dictionary<string, OfficialTitleEntry> CreateNeutralPreset()
		{
			return null;
		}

		private static Dictionary<string, OfficialTitleEntry> CreateEntryDictionary()
		{
			return null;
		}

		private static OfficialTitleEntry Entry(string _chinese, string _traditionalChinese, string _english)
		{
			return null;
		}
	}
}
