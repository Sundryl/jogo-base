using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	public sealed class OfficialTitleProfile
	{
		public const string AnyPoliticalSystem = "Any";

		[NonSerialized]
		private bool m_IsInitialized;

		private string m_PresetId;

		private Dictionary<string, OfficialTitleEntry> m_Entries;

		[JsonProperty]
		public string PresetId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty]
		public Dictionary<string, OfficialTitleEntry> Entries
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void EnsureInitialized()
		{
		}

		public OfficialTitleEntry GetEntry(PoliticalSystem? _politicalSystem, string _officeId)
		{
			return null;
		}

		public void SetEntry(PoliticalSystem? _politicalSystem, string _officeId, OfficialTitleEntry _entry)
		{
		}

		public bool ClearEntry(PoliticalSystem? _politicalSystem, string _officeId)
		{
			return false;
		}

		public OfficialTitleProfile Clone()
		{
			return null;
		}

		public static string BuildEntryKey(PoliticalSystem _politicalSystem, string _officeId)
		{
			return null;
		}

		public static string BuildEntryKey(string _politicalSystem, string _officeId)
		{
			return null;
		}
	}
}
