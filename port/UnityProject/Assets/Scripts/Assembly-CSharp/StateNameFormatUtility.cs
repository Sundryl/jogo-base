using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class StateNameFormatUtility
{
	public const string NamePlaceholder = "{Name}";

	public const string RestorationOrdinalPlaceholder = "{RestorationOrdinal}";

	public const string FormNamePlaceholder = "{FormName}";

	private const string c_NameToken = "⟪NFW0⟫";

	private const string c_RestorationOrdinalToken = "⟪NFW1⟫";

	private static readonly Regex s_NamedPlaceholderRegex;

	private static readonly Regex s_RichTextTagRegex;

	public static bool ValidateStateFullNameTemplate(string _template)
	{
		return false;
	}

	public static bool HasRequiredPlaceholders(string _template)
	{
		return false;
	}

	public static string ApplyStateFullNameTemplate(string _template, string _countryName, string _restorationOrdinal, string _formName)
	{
		return null;
	}

	public static string CreateSuggestedCustomTemplate(string _defaultTemplate, string _formName)
	{
		return null;
	}

	public static string StripRichTextTags(string _template)
	{
		return null;
	}

	public static string ProtectTemplatePlaceholdersForTranslation(string _template)
	{
		return null;
	}

	public static string StripTemplatePlaceholdersForLanguageDetection(string _template)
	{
		return null;
	}

	public static string RestoreTemplatePlaceholdersAfterTranslation(string _template)
	{
		return null;
	}

	public static TranslationPanelOptions CreateTemplateTranslationOptions(string _fallbackTemplate)
	{
		return null;
	}

	public static Dictionary<string, string> SanitizeTemplateTranslations(Dictionary<string, string> _translations, string _preferredLanguage, string _fallbackTemplate, out bool _hasInvalidTemplate)
	{
		_hasInvalidTemplate = default;
		return null;
	}

	private static string GetPreferredTemplate(Dictionary<string, string> _translations, string _preferredLanguage, string _fallbackTemplate)
	{
		return null;
	}
}
