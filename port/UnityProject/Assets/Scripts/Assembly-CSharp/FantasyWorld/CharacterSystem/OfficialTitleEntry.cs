using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	public sealed class OfficialTitleEntry
	{
		[NonSerialized]
		private bool m_IsInitialized;

		private Dictionary<string, string> m_Translations;

		private Dictionary<string, string> m_MaleTranslations;

		private Dictionary<string, string> m_FemaleTranslations;

		[JsonProperty]
		public Dictionary<string, string> Translations
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
		public Dictionary<string, string> MaleTranslations
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
		public Dictionary<string, string> FemaleTranslations
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

		public void SetTranslation(string _language, string _title, Gender? _gender = null)
		{
		}

		public void ClearTranslation(string _language, Gender? _gender = null)
		{
		}

		public OfficialTitleEntry Clone()
		{
			return null;
		}

		internal Dictionary<string, string> GetTranslations(Gender? _gender)
		{
			return null;
		}

		private static Dictionary<string, string> NormalizeTranslations(Dictionary<string, string> _translations)
		{
			return null;
		}
	}
}
