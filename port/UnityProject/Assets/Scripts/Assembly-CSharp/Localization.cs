using System.Collections.Generic;
using TMPro;

public static class Localization
{
	public static string fontCN;

	public static string fontEN;

	public static string fontENUINew;

	public static string fontKorean;

	public static string fontENTextMessage;

	private static HashSet<string> cnSet;

	private static readonly Dictionary<PoliticalSystem, string> _translationKeys;

	private static readonly Dictionary<EthnicAttribute, string> _ethnicAttributeTranslationKeys;

	private static bool isInit;

	public static void ReadCSVFrom_StreamingFolder()
	{
	}

	private static string MergeCSVs(List<string> csvContents)
	{
		return null;
	}

	private static void UseLocalizationCSV(string CSVfile)
	{
	}

	public static bool IsChineseText(string text)
	{
		return false;
	}

	public static void SetLanguage(string language)
	{
	}

	public static string GetCurrentLanguage()
	{
		return null;
	}

	public static List<string> GetAllSupportLanguage()
	{
		return null;
	}

	public static void SetLanguage(int index)
	{
	}

	public static void GetCurrentLanguageIndex()
	{
	}

	public static void ChangeToNextLanguage()
	{
	}

	public static string GetTranslation(string key, string overrideLanguage, bool isTextMessage = true, bool isNeedDefaultFont = true)
	{
		return null;
	}

	public static string GetTranslation(string key, bool isTextMessage = true, bool isNeedDefaultFont = true)
	{
		return null;
	}

	public static string GetPoliticalSystemTranslation(PoliticalSystem politicalSystem, bool isNeedDefaultFont = true)
	{
		return null;
	}

	public static bool IsCNType()
	{
		return false;
	}

	public static bool IsCNType(string language)
	{
		return false;
	}

	public static TMP_FontAsset GetCurrentMapFontAsset()
	{
		return null;
	}

	public static TMP_FontAsset GetCurrentUIFontAsset()
	{
		return null;
	}

	public static TMP_FontAsset GetCurrentNewUIFontAsset()
	{
		return null;
	}

	public static TMP_FontAsset GetCurrentUIFontAsset(string language)
	{
		return null;
	}

	internal static string GetCurrentFont()
	{
		return null;
	}

	internal static string GetEthnicAttributeTranslation(EthnicAttribute ethnicAttribute, bool isNeedDefaultFont = true)
	{
		return null;
	}

	internal static string GetEthnicAttributeTranslationKey(EthnicAttribute ethnicAttribute)
	{
		return null;
	}

	public static string GetOrdinalNumber(int number, string suffix, bool isNeedDefaultFont = true)
	{
		return null;
	}

	private static string GetEnglishOrdinalSuffix(int number)
	{
		return null;
	}
}
