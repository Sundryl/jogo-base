using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class MilitaryUnitDefinition
{
	private static readonly string[] s_PreferredDisplayNameFallbackLanguages;

	private static readonly Dictionary<string, Dictionary<string, string>> s_DefaultDisplayNameTranslations;

	public string UnitKey { get; set; }

	public Dictionary<string, string> DisplayNameTranslations { get; set; }

	[JsonIgnore]
	public string DisplayName => null;

	public float BaseCombatPower { get; set; }

	public float RecruitmentWeight { get; set; }

	public float MovementSpeedMultiplier { get; set; }

	public float LandSpriteScaleMultiplier { get; set; }

	public bool UseStateColorTint { get; set; }

	public TerrainModifierTable RecruitmentModifiers { get; set; }

	public TerrainModifierTable AttackModifiers { get; set; }

	public TerrainModifierTable DefenseModifiers { get; set; }

	public MilitaryUnitDefinition Clone()
	{
		return null;
	}

	public void EnsureInitialized()
	{
	}

	public string GetDisplayName(string language = null, bool allowFallback = true)
	{
		return null;
	}

	public bool TryGetDisplayNameTranslation(string language, out string translatedName)
	{
		translatedName = null;
		return false;
	}

	public string GetDirectDisplayNameTranslation(string language)
	{
		return null;
	}

	public void SetDisplayNameTranslation(string language, string translatedName)
	{
	}

	public void ClearDisplayNameTranslation(string language)
	{
	}

	private static string GetBuiltInDefaultDisplayName(string unitKey, string language)
	{
		return null;
	}
}
