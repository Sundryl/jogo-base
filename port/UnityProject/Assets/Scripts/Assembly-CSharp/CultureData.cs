using System.Collections.Generic;
using FantasyWorld.CharacterSystem;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Scripting;

[Preserve]
public class CultureData
{
	[JsonProperty]
	public string folderPath;

	public bool isCurrentEnabled;

	public HashSet<PoliticalSystem> politicalSystems;

	[JsonIgnore]
	public string cultureType;

	[JsonProperty]
	private string m_CultureColorHex;

	[JsonProperty]
	private Dictionary<string, float> m_TraitWeights;

	[JsonProperty]
	private Dictionary<PoliticalSystem, float> m_PoliticalSystemWeights;

	[JsonProperty]
	private Dictionary<EthnicAttribute, float> m_EthnicAttributeWeights;

	[JsonProperty]
	internal List<string> m_CultureDescriptionTranslations;

	[JsonProperty]
	internal List<string> m_MapCultureTranslations;

	[JsonProperty]
	private NameOrder m_NameOrder;

	[JsonProperty]
	public OfficialTitleProfile OfficialTitles { get; set; }

	public string CultureNameID { get; set; }

	public Dictionary<string, LocalizedName> StateNames { get; set; }

	public Dictionary<string, LocalizedName> CityNames { get; set; }

	public Dictionary<string, LocalizedName> MaleFirstNames { get; set; }

	public Dictionary<string, LocalizedName> FemaleFirstNames { get; set; }

	public Dictionary<string, LocalizedName> LastNames { get; set; }

	public Dictionary<string, int> LanguageToIndexMap { get; set; }

	public Dictionary<string, float> TraitWeights => null;

	public Dictionary<PoliticalSystem, float> PoliticalSystemWeights => null;

	public Dictionary<EthnicAttribute, float> EthnicAttributeWeights => null;

	[JsonProperty]
	public MilitaryProfile CultureMilitaryProfile { get; set; }

	public void EnsureOfficialTitlesInitialized()
	{
	}

	public void ApplyOfficialTitlePreset(string _presetId, bool _clearOverrides = false)
	{
	}

	public OfficialTitleEntry GetOfficialTitleOverride(PoliticalSystem? _politicalSystem, string _officeId)
	{
		return null;
	}

	public void SetOfficialTitleOverride(PoliticalSystem? _politicalSystem, string _officeId, OfficialTitleEntry _entry)
	{
	}

	public bool ClearOfficialTitleOverride(PoliticalSystem? _politicalSystem, string _officeId)
	{
		return false;
	}

	[JsonConstructor]
	public CultureData()
	{
	}

	public CultureData(string cultureNameID)
	{
	}

	private void InitializeCultureData(string cultureNameID, bool initializeMilitaryProfile)
	{
	}

	public Dictionary<string, string> GetStateNameTranslations(string _stateNameKey)
	{
		return null;
	}

	public Dictionary<string, string> GetCityNameTranslations(string _cityNameKey)
	{
		return null;
	}

	private void InitializeProbabilities()
	{
	}

	public void EnsureTraitWeightsInitialized()
	{
	}

	public void EnsurePoliticalSystemWeightsInitialized()
	{
	}

	public void EnsureEthnicAttributeWeightsInitialized()
	{
	}

	public string GetStateName(string _stateNameKey, string _language = null)
	{
		return null;
	}

	public void EnsureListCapacity<T>(List<T> list)
	{
	}

	public float GetTraitWeight(string _traitName)
	{
		return 0f;
	}

	public void SetTraitWeight(string _traitName, float _weight)
	{
	}

	public float GetPoliticalSystemWeight(PoliticalSystem _politicalSystem)
	{
		return 0f;
	}

	public void SetPoliticalSystemWeight(PoliticalSystem _politicalSystem, float _weight)
	{
	}

	public float GetEthnicAttributeWeight(EthnicAttribute _ethnicAttribute)
	{
		return 0f;
	}

	public void SetEthnicAttributeWeight(EthnicAttribute _ethnicAttribute, float _weight)
	{
	}

	public Dictionary<string, float> GetAllTraitWeights()
	{
		return null;
	}

	public Dictionary<PoliticalSystem, float> GetAllPoliticalSystemWeights()
	{
		return null;
	}

	public Dictionary<EthnicAttribute, float> GetAllEthnicAttributeWeights()
	{
		return null;
	}

	public string GetCultureDescription(string currentLanguage)
	{
		return null;
	}

	public void SetCultureDescription(string description, string language)
	{
	}

	public string GetMapCultureName(string currentLanguage)
	{
		return null;
	}

	public void SetMapCultureName(string cultureName, string language, bool isUpdateAllLanguage = false)
	{
	}

	public Color GetCultureColor()
	{
		return default;
	}

	public void SetCultureColor(Color color)
	{
	}

	public string GetCultureColorHex()
	{
		return null;
	}

	public void SetCultureColorHex(string colorHex)
	{
	}

	public NameOrder GetNameOrder()
	{
		return NameOrder.FirstNameFirst;
	}

	public void SetNameOrder(NameOrder nameOrder)
	{
	}

	internal string FindStateKeyBasedOnName(string name)
	{
		return null;
	}

	internal string FindCityKeyBasedOnName(string name)
	{
		return null;
	}

	public (string, string) GenerateCharacterName(Gender gender, string language = null, bool usePatronymic = false, string fatherFirstName = null)
	{
		return default;
	}

	private string GeneratePatronymicSurname(string fatherFirstName, Gender gender, string language)
	{
		return null;
	}

	public string GetRandomFirstName(Gender gender, string language = null)
	{
		return null;
	}

	public string GetRandomLastName(string language = null)
	{
		return null;
	}

	public void EnsureMilitaryProfileInitialized()
	{
	}

	public MilitaryProfile GetEffectiveMilitaryProfile()
	{
		return null;
	}

	public MilitaryProfile GetMilitaryProfileForPersistence()
	{
		return null;
	}
}
