using System.Collections.Generic;

namespace FantasyWorld.CharacterSystem
{
	public static class OfficialTitleResolver
	{
		public static string Resolve(CultureData _cultureData, PoliticalSystem _politicalSystem, string _officeId, Gender? _gender = null, string _language = null)
		{
			return null;
		}

		public static string Resolve(State _state, string _officeId, Gender? _gender = null, string _language = null)
		{
			return null;
		}

		public static string Resolve(OfficialTitleProfile _profile, PoliticalSystem _politicalSystem, string _officeId, Gender? _gender = null, string _language = null)
		{
			return null;
		}

		public static string ResolveForScope(CultureData _cultureData, PoliticalSystem? _politicalSystem, string _officeId, Gender? _gender = null, string _language = null)
		{
			return null;
		}

		public static OfficialTitleResolution ResolveScopeDetailed(CultureData _cultureData, PoliticalSystem? _politicalSystem, string _officeId, Gender? _gender = null, string _language = null, bool _ignoreCurrentScopeOverride = false)
		{
			return null;
		}

		public static OfficialTitleResolution ResolveScopeDetailed(OfficialTitleProfile _profile, PoliticalSystem? _politicalSystem, string _officeId, Gender? _gender = null, string _language = null, bool _ignoreCurrentScopeOverride = false)
		{
			return null;
		}

		public static OfficialTitleResolution ResolveDetailed(CultureData _cultureData, PoliticalSystem _politicalSystem, string _officeId, Gender? _gender = null, string _language = null, bool _ignorePoliticalSystemOverride = false)
		{
			return null;
		}

		public static OfficialTitleResolution ResolveDetailed(OfficialTitleProfile _profile, PoliticalSystem _politicalSystem, string _officeId, Gender? _gender = null, string _language = null, bool _ignorePoliticalSystemOverride = false)
		{
			return null;
		}

		public static OfficialTitleResolution ResolveDetailed(State _state, string _officeId, Gender? _gender = null, string _language = null)
		{
			return null;
		}

		private static bool TryResolveMapDefault(PoliticalSystem? _politicalSystem, string _officeId, Gender? _gender, string _language, out OfficialTitleResolution _resolution)
		{
			_resolution = null;
			return false;
		}

		private static bool TryResolveEntry(OfficialTitleEntry _entry, Gender? _gender, string _language, out string _title)
		{
			_title = null;
			return false;
		}

		private static bool TryResolveTranslations(Dictionary<string, string> _translations, string _language, out string _title)
		{
			_title = null;
			return false;
		}

		private static string GetBuiltInFallback(string _officeId, string _language)
		{
			return null;
		}
	}
}
