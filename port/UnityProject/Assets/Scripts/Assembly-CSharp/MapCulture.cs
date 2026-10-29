using System.Collections.Generic;
using FantasyWorld.CharacterSystem;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;
using csDelaunay;

public class MapCulture
{
	public class MapCultureSerializationData
	{
		public CultureData CultureData { get; set; }
	}

	private class WeightedItem<T>
	{
		public T item;

		public float weight;

		public WeightedItem(T item, float weight)
		{
		}
	}

	private static readonly JsonSerializerSettings s_ParseCultureSettings;

	[JsonProperty]
	private CultureData m_CultureData;

	public string CultureReferenceName;

	[JsonIgnore]
	public GameObject cultureLabelObject;

	[JsonIgnore]
	public Vector2f polePos;

	[JsonIgnore]
	public int poleCellIndex;

	[JsonIgnore]
	public bool isNeedLabelUpdate;

	[JsonIgnore]
	public bool isNeedBorderLineUpdate;

	public CultureData CultureData => null;

	public MapCulture()
	{
	}

	public MapCulture(string _cultureName, string _cultureReferenceName, bool _inheritCultureStateNames = false, bool _inheritCultureCityNames = false)
	{
	}

	private string FindBestMatchingCulture(string cultureReference)
	{
		return null;
	}

	private CultureData CloneCultureData(CultureData source, string newName)
	{
		return null;
	}

	private void InitializeLanguageMap()
	{
	}

	public string Serialize()
	{
		return null;
	}

	public static MapCulture Deserialize(string json)
	{
		return null;
	}

	public void DeserializeFromJson(string json, bool _needPostDeserialize = true)
	{
	}

	public static CultureData ParseCultureDataOnly(string _json)
	{
		return null;
	}

	public void ApplyParsedCultureData(CultureData _cultureData)
	{
	}

	private static void TryRestoreCultureMilitaryProfile(CultureData cultureData, JObject cultureDataObject)
	{
	}

	private static void TryRestoreOfficialTitles(CultureData cultureData, JObject cultureDataObject)
	{
	}

	private static string NormalizeSerializedJson(string _json)
	{
		return null;
	}

	private void TryLoadPoliticalSystemWeights(JObject cultureDataObj)
	{
	}

	private void TryLoadEthnicAttributeWeights(JObject cultureDataObj)
	{
	}

	private void TryLoadTraitWeights(JObject cultureDataObj)
	{
	}

	private void TryLoadCultureTranslations(JObject cultureDataObj)
	{
	}

	public void PostDeserialize()
	{
	}

	public void Clear()
	{
	}

	public void ClearAllCountryNames()
	{
	}

	public void ClearAllCityNames()
	{
	}

	public void CopyNamesFromCultureManager(string _cultureName, bool _inheritStateNames, bool _inheritCityNames)
	{
	}

	public void CopyFirstAndLastNamesFromCultureManager(string _cultureName, bool _copyMaleFirstNames, bool _copyFemaleFirstNames, bool _copyLastNames)
	{
	}

	public string GetTranslatedName(string _language = null)
	{
		return null;
	}

	public string GetMapCultureName(string _language)
	{
		return null;
	}

	public void SetMapCultureName(string _cultureName, string _language, bool _isUpdateAllLanguage = false)
	{
	}

	public void SetMapCultureTranslation(string _language, string _translatedName)
	{
	}

	public string GetCountryName(string _countryKey, string _language)
	{
		return null;
	}

	public string GetCityName(string _cityKey, string _language)
	{
		return null;
	}

	public string GetCultureDescription()
	{
		return null;
	}

	public string GetCultureDescription(string _language)
	{
		return null;
	}

	public void SetCultureDescription(string _description, string _language, bool _autoTranslate = false)
	{
	}

	public void SetCultureDescriptionTranslation(string _language, string _translatedDescription)
	{
	}

	public string CreateCountryName(string _countryName, bool _autoTranslate = true)
	{
		return null;
	}

	public void SetCountryName(string _countryKey, string _countryName, bool _autoTranslate = true)
	{
	}

	public string CreateCityName(string _cityName, bool _autoTranslate = true)
	{
		return null;
	}

	public void SetCityName(string _cityKey, string _cityName, bool _autoTranslate = true)
	{
	}

	public void ClearCityName(string _cityKey)
	{
	}

	public void SetCityTranslation(string _cityKey, string _language, string _translatedName)
	{
	}

	public void ClearCustomCityNames()
	{
	}

	public Dictionary<string, LocalizedName> GetAllCustomCityNames()
	{
		return null;
	}

	private string TranslateText(string _text, string _targetLanguage)
	{
		return null;
	}

	public void ClearCountryName(string _countryKey)
	{
	}

	public void SetCountryTranslation(string _countryKey, string _language, string _translatedName)
	{
	}

	public List<string> GetAllCountryKeys()
	{
		return null;
	}

	public List<string> GetAllCityKeys()
	{
		return null;
	}

	public List<string> GetAllMaleFirstNameKeys()
	{
		return null;
	}

	public List<string> GetAllFemaleFirstNameKeys()
	{
		return null;
	}

	public List<string> GetAllLastNameKeys()
	{
		return null;
	}

	public string GetMaleFirstName(string _nameKey, string _language)
	{
		return null;
	}

	public string GetFemaleFirstName(string _nameKey, string _language)
	{
		return null;
	}

	public string GetLastName(string _nameKey, string _language)
	{
		return null;
	}

	public string CreateMaleFirstName(string _name, bool _autoTranslate = false)
	{
		return null;
	}

	private void SetMaleFirstName(string _nameKey, string _name)
	{
	}

	public string CreateFemaleFirstName(string _name, bool _autoTranslate = false)
	{
		return null;
	}

	private void SetFemaleFirstName(string _nameKey, string _name)
	{
	}

	public string CreateLastName(string _name, bool _autoTranslate = false)
	{
		return null;
	}

	private void SetLastName(string _nameKey, string _name)
	{
	}

	public void ClearMaleFirstName(string _nameKey)
	{
	}

	public void ClearFemaleFirstName(string _nameKey)
	{
	}

	public void ClearLastName(string _nameKey)
	{
	}

	public void ClearAllMaleFirstNames()
	{
	}

	public void ClearAllFemaleFirstNames()
	{
	}

	public void ClearAllLastNames()
	{
	}

	public void SetMaleFirstNameTranslation(string _nameKey, string _language, string _translatedName)
	{
	}

	public void SetFemaleFirstNameTranslation(string _nameKey, string _language, string _translatedName)
	{
	}

	public void SetLastNameTranslation(string _nameKey, string _language, string _translatedName)
	{
	}

	public Color GetCultureColor()
	{
		return default;
	}

	public void SetCultureColor(Color _color)
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

	public void GenerateStateProperties(State _state, bool _isAtheismReligion, HashSet<PoliticalSystem> _culturePoliticalSystems = null)
	{
	}

	private PoliticalSystem GeneratePoliticalSystem(bool _isAtheismReligion, HashSet<PoliticalSystem> _culturePoliticalSystems = null)
	{
		return PoliticalSystem.Kingdom;
	}

	private EthnicAttribute GenerateEthnicAttribute()
	{
		return EthnicAttribute.FishAndHunting;
	}

	public void GenerateTraitsForState(State _state)
	{
	}

	private T SelectWeightedRandom<T>(List<WeightedItem<T>> weightedItems, T defaultValue = default(T))
	{
		return default;
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

	public void ReplaceCultureData(CultureData _sourceCultureData, bool _keepOriginalId = false)
	{
	}

	public bool IsCulturePresentInWorld()
	{
		return false;
	}

	public void SetCultureLabelTriggerCheck(bool isActive)
	{
	}

	public string GetRandomCountryKeyExcept(HashSet<string> _excludeNames, string _language = null)
	{
		return null;
	}

	public (string, string) GenerateCharacterName(Gender gender, string language = null, bool usePatronymic = false, string fatherFirstName = null)
	{
		return default;
	}

	public string GetRandomFirstName(Gender gender, string language = null)
	{
		return null;
	}

	public string GetRandomLastName(string language = null)
	{
		return null;
	}

	public string GetRandomCountryKeyExceptKeys(HashSet<string> _excludeKeys1, HashSet<string> _excludeKeys2)
	{
		return null;
	}

	public string GetRandomCountryKeyExceptNames(HashSet<string> _usedStateNames, HashSet<string> _currentValidStateNames)
	{
		return null;
	}
}
