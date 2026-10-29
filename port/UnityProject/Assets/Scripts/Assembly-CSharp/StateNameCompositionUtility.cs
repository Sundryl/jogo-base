using System.Collections.Generic;

public static class StateNameCompositionUtility
{
	private static readonly HashSet<string> s_SuffixFormLanguages;

	private static readonly Dictionary<int, string> s_EnglishOrdinalWords;

	public static bool UsesSuffixFormOrder(string language)
	{
		return false;
	}

	public static string GetLocalizedRestorationOrdinal(int restorationCount, string language, bool appendSpacingForConcatenation = false)
	{
		return null;
	}

	public static string ComposeStructuredStateName(string language, string prefix, string baseName, string restorationOrdinal, string formName, string suffix)
	{
		return null;
	}

	private static void AppendWesternToken(List<string> tokens, string token)
	{
	}

	private static string BuildLocalizedOrdinal(int ordinalNumber, string language)
	{
		return null;
	}

	private static string GetEnglishOrdinal(int number)
	{
		return null;
	}

	private static string GetEnglishOrdinalSuffix(int number)
	{
		return null;
	}

	private static string ToChineseNumber(int number)
	{
		return null;
	}
}
