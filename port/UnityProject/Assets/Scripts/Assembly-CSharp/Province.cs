using System.Collections.Generic;
using FantasyWorld.CharacterSystem;
using Newtonsoft.Json;
using UnityEngine;
using csDelaunay;

public class Province
{
	public int id;

	public string name;

	public int controllingFamilyId;

	public Dictionary<string, string> translatedNames;

	[JsonIgnore]
	public Color color;

	public string colorString;

	public int center;

	public bool isMannulSetFortress;

	public bool isMannulFortreess;

	public string MapCultureNameID;

	[JsonIgnore]
	public ElevationBasedTerrainAnalyzer.TerrainClassification terrainClassification;

	public float expansionism;

	public int capitalBurgID;

	public string type;

	public int cultureID;

	public int nameCellIndex;

	public int stateID;

	public int districtID;

	[JsonIgnore]
	public District district;

	public bool isLocked;

	public bool isLand;

	public bool isSeaNeighbor;

	public bool isAllCellsConnected;

	public float battleScore;

	public float maxBattleScore;

	public bool isDebug;

	public bool isValid;

	public int currentCampaign;

	public bool isConnectedToCapital;

	[JsonIgnore]
	public bool isProtruding;

	[JsonIgnore]
	public HashSet<int> neighbors;

	[JsonIgnore]
	public List<int> cells;

	[JsonIgnore]
	public List<int> borderNeighborCells;

	[JsonIgnore]
	public State state;

	public float provincePower;

	public float provinceDiplomacyPower;

	public float provinceLoyalty;

	public Dictionary<string, float> religionDistribution;

	public int foodProductionEfficiency;

	public float foodReserve;

	public int population;

	public int maxPopulation;

	public bool isMaxPopulationLocked;

	public bool isMaxBattleScoreLocked;

	public bool isCombatEfficiencyModifierLocked;

	public int distanceFieldToCapital;

	public double timeStampLastConquered;

	[JsonIgnore]
	public List<GameObject> battleSwords;

	private bool isAtWar;

	private bool isAtRebelWar;

	private int frameCount;

	public const float c_MinCombatEfficiencyModifier = 1f;

	public const float c_PlateauCombatEfficiencyModifier = 1.5f;

	public const float c_MaxAutomaticCombatEfficiencyModifier = 3f;

	public const float c_MaxCombatEfficiencyModifier = 10f;

	public float combatEfficiencyModifier;

	public Dictionary<int, float> MonthsCoreProvinceForState;

	[JsonIgnore]
	public int armyLimit;

	[JsonIgnore]
	public List<Army> armies;

	[JsonIgnore]
	public List<Army> armiesInProvince;

	[JsonIgnore]
	public List<Army> armiesTargetingProvince;

	[JsonIgnore]
	public List<Navy> naviesInProvince;

	public Dictionary<long, ProvinceHistroy> provinceHistorys;

	public Dictionary<long, int> provinceHistoryStateID;

	public List<int> provinceHistoryStateIDList;

	public List<int> provinceHistoryRunTimePoints;

	public List<int> provinceHistoryRunStateIDs;

	public int provinceHistoryPointCount;

	internal int updateDay;

	public Dictionary<int, int> biomeCounts;

	public List<BiomeResource> provinceResources;

	private HashSet<int> ArrowStartProvince;

	private List<Transform> battleArrows;

	[JsonIgnore]
	public Dictionary<int, Vector2f> provinceToPathMidPoint;

	private HashSet<int> neighborStates;

	[JsonIgnore]
	public bool isNeedProvinceLineUpdate;

	[JsonIgnore]
	public string UIName => null;

	[JsonIgnore]
	public Family ControllingFamily => null;

	[JsonIgnore]
	public bool IsStateCore => false;

	public void SetNewName(string newName)
	{
	}

	public ProvinceCityType GetProvinceCityType()
	{
		return ProvinceCityType.Capital;
	}

	public bool IsValid()
	{
		return false;
	}

	public void CheckAllCellConnected()
	{
	}

	public void CheckIsValid()
	{
	}

	public void ResetNameBasedOnTranslatedName(string Language)
	{
	}

	public bool IsProtruding()
	{
		return false;
	}

	public string GetMainReligionId()
	{
		return null;
	}

	public bool ShouldSerializeprovinceHistorys()
	{
		return false;
	}

	public bool ShouldSerializeprovinceHistoryStateID()
	{
		return false;
	}

	public bool ShouldSerializeprovinceHistoryStateIDList()
	{
		return false;
	}

	public bool IsBlankConquerableProvince()
	{
		return false;
	}

	public bool IsConquerable()
	{
		return false;
	}

	public Province(int id, Color color, string name, float expansionism, int capital, string type, int center, int culture)
	{
	}

	public Province()
	{
	}

	public string Serialize()
	{
		return null;
	}

	public static Province Deserialize(string json)
	{
		return null;
	}

	private void MigrateLegacyOwnerHistory()
	{
	}

	public void RefreshNameBasedOnTranslatedName()
	{
	}

	private static bool IsValidDisplayName(string _name)
	{
		return false;
	}

	private static bool TryGetValidTranslationForLanguage(Dictionary<string, string> _translations, string _language, out string _value)
	{
		_value = null;
		return false;
	}

	private static bool TrySelectPreferredName(Dictionary<string, string> _translations, string _baseName, string _language, out string _winnerName)
	{
		_winnerName = null;
		return false;
	}

	private static Dictionary<string, string> CloneTranslations(Dictionary<string, string> _translations)
	{
		return null;
	}

	private static void EnsureLanguageEntry(Dictionary<string, string> _translations, string _language, string _fallbackValue)
	{
	}

	private void ApplyWinnerToBurgAndProvince(BurgData _burg, string _winnerName, Dictionary<string, string> _winnerTranslations, string _language, ref string _provinceDisplayName)
	{
	}

	private void NormalizeLoadedNamesWithBurgPriority(string _language, ref string _provinceDisplayName)
	{
	}

	public void PostLoadSaveData()
	{
	}

	public void ValidateReligionDistribution()
	{
	}

	public void Start()
	{
	}

	public void ConvertColor()
	{
	}

	public void RecalCulateBiomAndTerrainInfo()
	{
	}

	public float GetCombatEfficiencyModifier()
	{
		return 0f;
	}

	public static float ClampCombatEfficiencyModifier(float modifier)
	{
		return 0f;
	}

	public void ResetCombatEfficiency()
	{
	}

	public void InitSimulationData()
	{
	}

	public void RecalculateProvinceBattleScore(float averageBattleScorePerCell)
	{
	}

	private void InitReligion()
	{
	}

	public void InitEcnomicData()
	{
	}

	public void InitBiomeResource(Dictionary<int, int> biomeCounts)
	{
	}

	public void Update()
	{
	}

	private void CheckTooMuchArmy()
	{
	}

	public int GetEcnomicPerMonth()
	{
		return 0;
	}

	private void UpdateAttackArrow()
	{
	}

	private void EnableBattleArrow()
	{
	}

	private Vector2f GetPathMidPointToProvince(int provinceID)
	{
		return default;
	}

	private void DestroyBattleArrow()
	{
	}

	public void DestroyBattleSword()
	{
	}

	public void UpdateBattleSword()
	{
	}

	private Vector3 GetBattleFxPosition()
	{
		return default;
	}

	public List<Army> GetEnemyArmies()
	{
		return null;
	}

	public float GetMaxPopulationInProvince()
	{
		return 0f;
	}

	public float PopulationPercentage()
	{
		return 0f;
	}

	public void UpdateProvinceData()
	{
	}

	public void RecalculatePopulation()
	{
	}

	public int GetFoodProductionEfficiency()
	{
		return 0;
	}

	public float GetArmyProduceEfficiency()
	{
		return 0f;
	}

	public float GetMaxArmyCountPerLegion()
	{
		return 0f;
	}

	private static int RoundArmyDisplayCountToStep(float displayCount)
	{
		return 0;
	}

	public void RecalculateNeighborProvince()
	{
	}

	public float GetArmyReorganizationDuration()
	{
		return 0f;
	}

	public void CheckAndCreateArmy()
	{
	}

	public bool IsCapital()
	{
		return false;
	}

	public HashSet<int> GetNeighborStates()
	{
		return null;
	}

	private void UpdateNeighBorStates()
	{
	}

	public bool IsValidLandProvince()
	{
		return false;
	}

	public void TryRebel(bool isForceRebel = false)
	{
	}

	public void Clear()
	{
	}

	public void ReInit()
	{
	}

	public void AdvanceOneMonth()
	{
	}

	public bool IsAtRebelWar()
	{
		return false;
	}

	public bool IsAtSeaWar()
	{
		return false;
	}

	private void CheckWarStatus()
	{
	}

	public bool IsAtWar()
	{
		return false;
	}

	public bool IsSupplyArmy()
	{
		return false;
	}

	public float GetProvincePopulationGrowthRate()
	{
		return 0f;
	}

	public float GetFoodComsuption()
	{
		return 0f;
	}

	public bool IsFacingFoodShortage()
	{
		return false;
	}

	public int GetArmyCount()
	{
		return 0;
	}

	public void UpdateMaterial()
	{
	}

	public void ConqueredBy(State state, bool isRecordHistory = true, bool shouldStripFamilyControl = true)
	{
	}

	public List<Army> GetEnemyArmyInProvince(State s)
	{
		return null;
	}

	public bool IsLandBorderProvince()
	{
		return false;
	}

	internal void UpdateProvinceColor(Color color)
	{
	}

	public string GetLocalizedName()
	{
		return null;
	}

	public void CaptureHistory(long t)
	{
	}

	public void ClearHistoryData()
	{
	}

	internal int GetHistoryStateID(long t)
	{
		return 0;
	}

	public void EnableBattleArrow(bool isEnabled)
	{
	}

	public void SetBattleArrowTransparency(float alpha)
	{
	}

	public void EnableBattleSword(bool isEnabled)
	{
	}

	public int GetDisplayedStateID()
	{
		return 0;
	}

	public void MatchNameKeyBasedOnCulture()
	{
	}

	public void SetTranslatedNames(Dictionary<string, string> translatedNames)
	{
	}

	private void HandleRestorationRebellion(State rebelState)
	{
	}
}
