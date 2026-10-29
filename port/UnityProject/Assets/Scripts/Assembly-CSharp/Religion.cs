using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class Religion
{
	[JsonProperty("name")]
	public string name;

	[JsonProperty("colorHex")]
	public string colorHex;

	[JsonProperty("description")]
	public string description;

	[JsonProperty("holyBookName")]
	public string holyBookName;

	[JsonProperty("practices")]
	public List<string> practices;

	[JsonIgnore]
	public string uniqueId;

	[JsonIgnore]
	public bool isCurrentEnabled;

	[JsonIgnore]
	public List<string> m_NameTranslations;

	[JsonIgnore]
	public List<string> m_DescriptionTranslations;

	[JsonIgnore]
	public List<string> m_HolyBookTranslations;

	[JsonIgnore]
	public Dictionary<string, List<string>> m_PracticeTranslations;

	[JsonIgnore]
	public Dictionary<string, int> LanguageToIndexMap { get; set; }

	[JsonIgnore]
	public Color Color
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Religion()
	{
	}

	public Religion(string uniqueId)
	{
	}

	public string GetColorHex()
	{
		return null;
	}

	public void SetColorHex(string hex)
	{
	}

	public void EnsureListCapacity<T>(List<T> list)
	{
	}

	public void InitializeLanguageMap()
	{
	}

	public string GetTranslatedName(string language = null)
	{
		return null;
	}

	public void SetTranslatedName(string translatedName, string language)
	{
	}

	public string GetTranslatedDescription(string language = null)
	{
		return null;
	}

	public void SetTranslatedDescription(string translatedDescription, string language)
	{
	}

	public string GetTranslatedHolyBookName(string language = null)
	{
		return null;
	}

	public void SetTranslatedHolyBookName(string translatedHolyBookName, string language)
	{
	}

	public string GetTranslatedPractice(string practiceKey, string language = null)
	{
		return null;
	}

	public void SetTranslatedPractice(string practiceKey, string translatedPractice, string language, bool autoTranslate = true)
	{
	}

	private string TranslateText(string text, string targetLanguage)
	{
		return null;
	}
}
