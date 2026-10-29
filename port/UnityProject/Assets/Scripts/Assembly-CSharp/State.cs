using System;
using System.Collections.Generic;
using System.ComponentModel;
using FantasyWorld.CharacterSystem;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;
using csDelaunay;

public class State
{
	public class StateHistory
	{
		public string name;

		public Color color;

		public bool isDead;

		public List<(Vector3 position, Quaternion rotation, float scale, bool isBold)> stateLabelTransform;

		public Vector3 position;

		public float t;

		public Vector2 sizeDelta;

		public JObject Serialize()
		{
			return null;
		}

		public bool ContentEquals(StateHistory other)
		{
			return false;
		}

		public static StateHistory CreateDeathSnapshot(StateHistory source)
		{
			return null;
		}

		public static StateHistory Deserialize(JObject jObject)
		{
			return null;
		}

		private static JObject SerializeVector3(Vector3 vector)
		{
			return null;
		}

		private static Vector3 DeserializeVector3(JToken token)
		{
			return default;
		}

		private static JObject SerializeQuaternion(Quaternion quaternion)
		{
			return null;
		}

		private static Quaternion DeserializeQuaternion(JToken token)
		{
			return default;
		}

		private static JObject SerializeVector2(Vector2 vector)
		{
			return null;
		}

		private static Vector2 DeserializeVector2(JToken token)
		{
			return default;
		}

		private static Color ParseColor(string htmlString)
		{
			return default;
		}
	}

	[JsonIgnore]
	public bool isCameraFollow;

	[JsonIgnore]
	public bool isRTSMode;

	public int i;

	public int leaderId;

	public float lastElectionTime;

	public int currentLeaderTerms;

	public Dictionary<string, string> translatedNames;

	public string nameKey;

	private string _name;

	public bool isAllowRebel;

	public bool isAutoDiplomacy;

	public bool isFamilyDistributionView;

	[JsonIgnore]
	public Color color;

	[JsonIgnore]
	public Color initColor;

	[JsonIgnore]
	public Color DeepColor;

	[JsonIgnore]
	public Color ShallowColor;

	public string colorString;

	public bool isLocked;

	public int center;

	public bool isBlankState;

	public bool isConquerable;

	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
	[DefaultValue(-1)]
	public int blankUnConquerableVisualOwnerStateID;

	[DefaultValue(false)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
	public bool isEnableBlankUnConquerableVisualOwnerColor;

	[JsonIgnore]
	public bool isNeedNameLabelUpdate;

	[JsonIgnore]
	public bool isNeedStateLineUpdate;

	[JsonIgnore]
	public bool isDuringNameLabelUpdate;

	[JsonIgnore]
	public double timestampNameLabelUpdate;

	public int culture;

	public string cultureName;

	public string type;

	public EthnicAttribute ethnicAttribute;

	public float expansionism;

	public int capitalBurgID;

	[JsonIgnore]
	public int poleCellIndex;

	[JsonIgnore]
	public Vector2f polePos;

	public int coreProvinceDistanceField;

	[JsonIgnore]
	public HashSet<int> neighbors;

	[JsonIgnore]
	public HashSet<int> neighborSeaStates;

	[JsonIgnore]
	public List<Province> provinces;

	[JsonIgnore]
	public List<int> provincesID;

	[JsonIgnore]
	public List<Province> borderProvinces;

	[JsonIgnore]
	public HashSet<Province> borderEnemyProvinces;

	[JsonIgnore]
	public HashSet<Province> borderRegularEnemyProvinces;

	[JsonIgnore]
	public HashSet<Province> borderRebelProvinces;

	[JsonIgnore]
	public List<Trait> traits;

	[JsonIgnore]
	public List<Army> armies;

	[JsonIgnore]
	public List<Navy> navies;

	[JsonIgnore]
	private List<(Vector3 position, Quaternion rotation, float scale, bool isBold)> characterTransforms;

	[JsonIgnore]
	public int armyCount;

	[JsonIgnore]
	public int navyCount;

	public float diplomacyPower;

	public float diplomacyPowerStartWar;

	public float diplomacyPowerEndWar;

	public float diplomacyefficiency;

	public double foundingTime;

	public double deadTime;

	public double timeStampLastWar;

	public double timeStampLastAutoWarStart;

	public double timeStampLastPassiveWarInvolvement;

	public double timeStampAlliance;

	public double timeStampLastRebel;

	public double timeStampBorn;

	public double timeStampLastCivilWar;

	public double timeStampLastFamilyRebellion;

	public float foodReserve;

	public double timeStampLastEmergencyMobilize;

	public int population;

	public int gold;

	[JsonIgnore]
	public float goldBattleEfficiencyBounus;

	public int goldPerMonth;

	public float leaderCombatModifier;

	public float destiny;

	private const float c_CivilWarSuppressionDestinyRollChance = 0.5f;

	private const int c_CivilWarSuppressionDestinyMin = 50;

	private const int c_CivilWarSuppressionDestinyMaxExclusive = 81;

	private const int c_ManifestDestinyCivilWarSuppressionDestinyMin = 70;

	private const int c_ManifestDestinyCivilWarSuppressionDestinyMaxExclusive = 91;

	private float destinyDecrease;

	[JsonIgnore]
	public int frameCount;

	[JsonIgnore]
	private int strengthFrameCount;

	[JsonIgnore]
	public GameObject stateLabel;

	public int restorationCount;

	private bool isDead;

	private Queue<double> timeStampRecent3EmergencyMobilize;

	public int rebelWar;

	public int rebelWarV2;

	private float strength;

	public float initialPopulationPercentage;

	private Queue<double> recentRebellionTimes;

	public List<double> recentRebellionTimesArray;

	private const int BASE_MAX_REBELLIONS = 5;

	private const double REBELLION_COOLDOWN_MONTHS = 26.0;

	[JsonIgnore]
	public HashSet<State> enemyStates;

	[JsonIgnore]
	public List<State> regularEnemyStates;

	[JsonIgnore]
	public List<State> enemyRebelStates;

	[JsonIgnore]
	private List<Vector3> bezierPoints;

	[JsonIgnore]
	internal Color armyColor;

	private bool isUseSingleCharacter;

	public float perimeterAreaRatio;

	public PoliticalSystem politicalSystem;

	[JsonIgnore]
	public PoliticalSystemAttributes politicalSystemAttributes;

	public HashSet<int> features;

	public int maniFestDestinyCount;

	[JsonIgnore]
	public SortedList<long, StateHistory> stateHistorys;

	[JsonProperty]
	public int allianceID;

	[JsonIgnore]
	public Alliance alliance;

	internal int updateDay;

	[JsonIgnore]
	public Color currentColor;

	[JsonIgnore]
	public bool currentIsDead;

	[JsonIgnore]
	public bool isControlledByPlayer;

	public int armyCostGold;

	public Dictionary<int, float> familyWarContributions;

	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
	[DefaultValue(-1)]
	public int monthsUntilTerritoryRedistribution;

	public string stateReligionId;

	[JsonProperty]
	public List<GovernmentOfficeAssignment> GovernmentOfficeAssignments;

	[JsonProperty]
	public bool IsGovernmentOfficeAutoAppointmentEnabled;

	[JsonProperty]
	public int LastGovernmentOfficeReviewYear;

	private bool m_IsGovernmentOfficeDataNormalized;

	public List<LeaderHistoryRecord> leaderHistory;

	public LeaderHistoryRecord currentLeaderRecord;

	private const int c_ProvinceRebellionReinforcementIntervalMonths = 3;

	public Dictionary<int, int> navyBuildQueueMonths;

	public int navyBuildQueueCount;

	public int navyBuildCurrentMonthsRemaining;

	[JsonIgnore]
	public bool isLandArmySeaCrossingRestricted;

	public bool isUseCustomNaming;

	public Dictionary<string, string> customFullNameFormatTranslations;

	private const float c_DestinyDecreaseBaseFactor = 0.3333f;

	private const float c_GoldNegativeImpact = 0.5f;

	private const float c_LowDestinyThreshold = 30f;

	private const float c_MinDestinyDecreaseAtLow = 0.083f;

	private const float c_MaxDestinyDecreaseAtLow = 0.24f;

	private const float c_LowDestinyFactor = 0.5f;

	private const float c_BaseDestinyReset = 10f;

	private const float c_ManifestDestinyBonus = 1.5f;

	private const float c_RebelCheckThreshold = 30f;

	private const float c_EmergencyCallProbability = 0.3f;

	private const int c_EmergencyCallMin = 4;

	private const int c_EmergencyCallMax = 7;

	private const float c_NonCoreRebelThreshold = 13f;

	private const float c_BaseRebelProbability = 0.35f;

	public const int c_CivilWarSuppressionMonths = 24;

	public const int c_FamilyRebellionSuppressionMonths = 18;

	public const float c_FamilyRebellionSuppressionRate = 0.1f;

	public const float c_ManifestDestinyIntervalMultiplier = 4f;

	public const int c_RebelWarMaxMonths = 36;

	[JsonProperty]
	public StateOfficialTitleBinding StateOfficialTitleBinding { get; set; }

	[JsonProperty]
	public StateMilitaryBinding StateMilitaryBinding { get; set; }

	[JsonIgnore]
	public int id
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[JsonIgnore]
	public string UIName => null;

	[JsonIgnore]
	public Character Leader => null;

	public bool IsDead
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[JsonProperty]
	private double[] TimeStampRecent3EmergencyMobilizeArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[JsonIgnore]
	public int GovernmentOfficeAssignmentsVersion { get; private set; }

	[JsonIgnore]
	public Dictionary<int, List<HistoryEvent>> ImportantHistoryEventsByYear => null;

	[JsonIgnore]
	public bool IsPacifist { get; set; }

	[JsonIgnore]
	public bool IsFightToTheEnd { get; set; }

	[JsonIgnore]
	public bool IsDefyTheStrong { get; set; }

	[JsonIgnore]
	public bool IsBullyTheWeak { get; set; }

	[JsonIgnore]
	public int MobilizationLevel { get; set; }

	[JsonIgnore]
	public bool IsManifestDestiny { get; set; }

	[JsonIgnore]
	public bool IsUnwaveringLoyalty { get; set; }

	[JsonIgnore]
	public bool IsAmbitious { get; set; }

	[JsonIgnore]
	public bool IsTotalWar { get; set; }

	[JsonIgnore]
	public bool IsWellTrained { get; set; }

	[JsonIgnore]
	public bool IsHomelandDefense { get; set; }

	[JsonIgnore]
	public bool IsConqueror { get; set; }

	[JsonIgnore]
	public bool IsCavalryTradition { get; set; }

	[JsonIgnore]
	public bool IsUnificationDrive { get; set; }

	[JsonIgnore]
	public float CoreProvinceRate { get; set; }

	[JsonIgnore]
	public float CoreDefenseEfficiencyBoost { get; set; }

	[JsonIgnore]
	public bool IsPeacekeeper { get; set; }

	[JsonIgnore]
	public bool IsRecuperate { get; set; }

	[JsonIgnore]
	public float BaseBattleEfficiencyBounus { get; set; }

	[JsonIgnore]
	public bool IsLocalReinforcement { get; set; }

	[JsonIgnore]
	public float LocalResistanceStrength { get; set; }

	[JsonIgnore]
	public float TotalEngageRate { get; set; }

	[JsonIgnore]
	public float DiplomacyefficiencyBounus { get; set; }

	[JsonIgnore]
	public float BattleEfficiencyDistanceBounus { get; set; }

	[JsonIgnore]
	public float SiegeDamageBoost { get; set; }

	[JsonIgnore]
	public float FieldCombatEfficiency { get; set; }

	public void EnsureOfficialTitleBindingInitialized()
	{
	}

	public OfficialTitleProfile GetEffectiveOfficialTitleProfile()
	{
		return null;
	}

	public OfficialTitleProfile GetInheritedOfficialTitleProfile()
	{
		return null;
	}

	private CultureData GetOfficialTitleCultureData()
	{
		return null;
	}

	public void EnsureMilitaryBindingInitialized()
	{
	}

	public MilitaryProfile GetEffectiveMilitaryProfile()
	{
		return null;
	}

	public void SetNewName(string newName)
	{
	}

	public void SetTranslatedNames(Dictionary<string, string> translatedNames)
	{
	}

	public void ResetNameBasedOnTranslatedName(string Language)
	{
	}

	public string GetUIName(bool isUseBackgroundColor = true, bool isFullName = false)
	{
		return null;
	}

	public string GetNameWithLeader()
	{
		return null;
	}

	public void MarkStateBorderDirty()
	{
	}

	public bool HasActiveManifestDestinyProtection()
	{
		return false;
	}

	public bool IsBlankConquerable()
	{
		return false;
	}

	public bool IsBlankUnConquerable()
	{
		return false;
	}

	public int GetMaxRecentRebellions()
	{
		return 0;
	}

	public bool CanAllowNewRebellion()
	{
		return false;
	}

	public void RecordNewRebellion()
	{
	}

	public void AdjustRecentRebellions()
	{
	}

	public void RefreshNameBasedOnTranslatedName()
	{
	}

	public void SetDestinyDecrease(float value)
	{
	}

	public State(int i, Color color, string name, float expansionism, int capitalBurgID, string type, int center, int culture)
	{
	}

	public State()
	{
	}

	public bool IsNearSea()
	{
		return false;
	}

	public void ConvertColor()
	{
	}

	public int GetAge()
	{
		return 0;
	}

	public float GetStrength()
	{
		return 0f;
	}

	public string GetFullName()
	{
		return null;
	}

	public void UpdateStateName()
	{
	}

	public void UpdateColor(Color color)
	{
	}

	public void Clear()
	{
	}

	private void RandomDestiny(bool isInitRandom = true)
	{
	}

	internal void TryRollDestinyAfterCivilWarSuppression()
	{
	}

	private bool IsTheocracy()
	{
		return false;
	}

	public int GetTotalPopulation()
	{
		return 0;
	}

	public bool IsOnlyCountryOnContinent()
	{
		return false;
	}

	public void DestroyState(State destroyByState, bool isRecordHistoryEvent = true)
	{
	}

	private void RemoveLeaderAfterDestruction(Character leader)
	{
	}

	private void ResolveFamiliesAfterDestruction(State destroyByState, bool isRecordHistoryEvent = true)
	{
	}

	private State GetValidConquerorForCollapse(State destroyByState)
	{
		return null;
	}

	internal void RecalculateCapital()
	{
	}

	public bool IsLandlocked()
	{
		return false;
	}

	internal bool IsAlive()
	{
		return false;
	}

	internal bool IsValid()
	{
		return false;
	}

	internal void CaptureColor()
	{
	}

	internal void ApplyCurrentColor()
	{
	}

	public float PopulationPercentage()
	{
		return 0f;
	}

	public void UpdatePoliticalSystemAttributes()
	{
	}

	private void AdjustAttributesByEthnicType()
	{
	}

	public float PoliticalSystemCombatAttackModifier()
	{
		return 0f;
	}

	public float PoliticalSystemCombatDefendModifier()
	{
		return 0f;
	}

	public float CalculateGoldBattleEfficiencyBounus()
	{
		return 0f;
	}

	public void ForceDelete()
	{
	}

	public int GetCapitalProvinceID()
	{
		return 0;
	}

	public void SetRTSMode(bool enabled)
	{
	}

	public void ForceAlliance(State targetState)
	{
	}

	private void ForceEndAlliance()
	{
	}

	public void ForceLeaveAlliance()
	{
	}

	private bool IsAllianceTo(State targetState)
	{
		return false;
	}

	public void StartWar(War war)
	{
	}

	public bool TryEndWar(bool isForce = false)
	{
		return false;
	}

	public void ForceEndWar(State targetState)
	{
	}

	private WarType DetermineWarType(State aggressor, State target)
	{
		return WarType.Conquest;
	}

	private void EndWar(War warToEnd, bool isPeaceEnd = false, bool isForce = false)
	{
	}

	public bool TryStartAlliance()
	{
		return false;
	}

	public bool TryJoinAlliance()
	{
		return false;
	}

	public bool TryEndAlliance()
	{
		return false;
	}

	public bool IsAtWar()
	{
		return false;
	}

	public bool IsAtWarWith(State state)
	{
		return false;
	}

	public HashSet<State> GetEnemyStates()
	{
		return null;
	}

	public List<State> GetRegularEnemyStates()
	{
		return null;
	}

	public bool HasIntersectLands(State targetState)
	{
		return false;
	}

	public List<State> GetRebelStates()
	{
		return null;
	}

	public void EndWar(List<State> warTarget)
	{
	}

	public List<State> GetAllyStates()
	{
		return null;
	}

	private bool IsSuperSuperPower()
	{
		return false;
	}

	public bool IsAtCivilWar()
	{
		return false;
	}

	private bool IsInAnyCivilWar(State state)
	{
		return false;
	}

	public bool IsCivilWarEmergencyCallAvailable()
	{
		return false;
	}

	public bool IsCivilWarInstigator()
	{
		return false;
	}

	private static bool IsInV2CivilWar(State state)
	{
		return false;
	}

	private static bool IsV2CivilWar(WarV2 war)
	{
		return false;
	}

	private void InitDiplomacyPower()
	{
	}

	public bool IsSuperPower()
	{
		return false;
	}

	public bool IsVassal()
	{
		return false;
	}

	public bool IsOverlord()
	{
		return false;
	}

	public State GetOverlord()
	{
		return null;
	}

	public List<State> GetVassals()
	{
		return null;
	}

	public bool IsVassalOf(State otherState)
	{
		return false;
	}

	public bool TryStartWar(bool isDrawAttackArrowAnim = true)
	{
		return false;
	}

	public void ForceEndAllianceBeforeWar(State targetState)
	{
	}

	public void ForceStartWar(State targetState)
	{
	}

	public void EnsureGovernmentOfficeData()
	{
	}

	public void MarkGovernmentOfficeDataDirty()
	{
	}

	public GovernmentOfficeAssignment GetGovernmentOfficeAssignment(string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind = GovernmentOfficeWarSystemKind.None)
	{
		return null;
	}

	public IReadOnlyList<GovernmentOfficeAssignment> GetGovernmentOfficeAssignments(string _officeId = null)
	{
		return null;
	}

	public Character GetGovernmentOfficeHolder(string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind = GovernmentOfficeWarSystemKind.None)
	{
		return null;
	}

	public void RecordHistoryEvent(HistoryEvent newEvent, bool isCameraFollow = false)
	{
	}

	public void ClearHistoryData()
	{
	}

	private void HandleLeaderEvents(HistoryEvent historyEvent)
	{
	}

	private void UpdateLeaderEventStats(HistoryEvent historyEvent)
	{
	}

	private bool IsImportantHistoryEvent(HistoryEvent historyEvent)
	{
		return false;
	}

	public List<HistoryEvent> GetAllHistoryEvents()
	{
		return null;
	}

	public List<HistoryEvent> GetHistoryEventsByYearRange(int startYear, int endYear)
	{
		return null;
	}

	public List<HistoryEvent> GetHistoryEventsInYear(int year)
	{
		return null;
	}

	public Dictionary<int, List<HistoryEvent>> GetImportantHistoryEventsByYear()
	{
		return null;
	}

	public string GetHistoryInYear(double t, bool isNeedDefaultFont = true)
	{
		return null;
	}

	public string GetRecentHistory(int maxCount, double upToTime, bool isNeedDefaultFont = true)
	{
		return null;
	}

	public string GetRecentHistory(int maxCount, double upToTime, bool isNeedDefaultFont, HashSet<HistoryEventType> allowedEventTypes)
	{
		return null;
	}

	public List<string> GetRecentHistoryWithYearSeparators(int maxEventCount, double upToTime, bool isNeedDefaultFont = true)
	{
		return null;
	}

	public List<string> GetRecentHistoryWithYearSeparators(int maxEventCount, double upToTime, bool isNeedDefaultFont, HashSet<HistoryEventType> allowedEventTypes)
	{
		return null;
	}

	public void LaunchAttackEvent(int provinceID)
	{
	}

	public void CaptureHistory(long t)
	{
	}

	private void AppendDeathHistoryIfNeeded(long t)
	{
	}

	private int FindHistoryRunIndex(long t)
	{
		return 0;
	}

	public void CompactLegacyStateHistorys()
	{
	}

	internal void ShowHistory(long t)
	{
	}

	[Obsolete("Use StateManager.AppointLeader instead of calling this directly")]
	public void RecordLeaderChange(int newLeaderId, string successionType = "hereditary")
	{
	}

	public void EndCurrentLeaderReign(string endType)
	{
	}

	public void UpdateCurrentLeaderStats(HistoryEventType eventType, bool isSuccess = true)
	{
	}

	public void RecordWarParticipation(WarParticipationType participationType, WarType warType)
	{
	}

	public void RecordWarOutcome(WarOutcome outcome)
	{
	}

	public string GetLeaderAchievementsText(LeaderHistoryRecord record, bool isNeedDefaultFont = true)
	{
		return null;
	}

	private string GetLanguageSpacing()
	{
		return null;
	}

	public string GetLeaderOrderSuffix(bool isNeedDefaultFont = true)
	{
		return null;
	}

	public void InitializeCurrentLeaderRecord()
	{
	}

	public void Start(bool shouldInitFamily = true)
	{
	}

	public void InitStateSimulationData(bool shouldInitFamily = true)
	{
	}

	public void InitializeCharactersAndFamilies()
	{
	}

	private void GenerateNobleFamiliesWithTerritories(string mapCultureNameID)
	{
	}

	private List<Province> SelectOptimalFamilyOrigins(List<Province> provinces, int count)
	{
		return null;
	}

	private void AssignRemainingProvincesToNearestFamilies(List<Province> remainingProvinces, List<Family> families)
	{
	}

	private float CalculateProvinceDistance(int province1Id, int province2Id)
	{
		return 0f;
	}

	private Family CreateNobleFamilyWithTerritory(string mapCultureNameID, Province province)
	{
		return null;
	}

	private void GenerateSpouseForLeader(Character leader, string mapCultureNameID, Family rulingFamily)
	{
	}

	private MarriageType DetermineInitialMarriageType(Character head, Character spouse, Family family)
	{
		return MarriageType.Patrilineal;
	}

	private void GenerateChildrenForLeader(Character leader, Family family, string mapCultureNameID, bool isInitialGeneration = false)
	{
	}

	private void GenerateNobleFamilyMembers(Character head, Family family, string mapCultureNameID, bool isInitialGeneration = false)
	{
	}

	private void GenerateCollateralMembers(Character head, Family family, string mapCultureNameID)
	{
	}

	private void GenerateSpouseAndChildrenForCollateralMember(Character member, Family family, string mapCultureNameID, bool isCousin = false)
	{
	}

	public string Serialize()
	{
		return null;
	}

	public static State Deserialize(string json)
	{
		return null;
	}

	public void PostLoadSaveData()
	{
	}

	private bool TryRestoreLegacyReligion()
	{
		return false;
	}

	public void DetermineStateReligion()
	{
	}

	public void RandomInit()
	{
	}

	internal void StartInitialPopulationPercentage()
	{
	}

	private void AllocateRulingFamilyTerritories(Family rulingFamily)
	{
	}

	private float GetRulingFamilyInitialRatio(PoliticalSystem politicalSystem)
	{
		return 0f;
	}

	private List<Province> SelectRulingFamilyProvinces(int capitalProvinceId, int targetCount)
	{
		return null;
	}

	private float CalculateProvincesDistance(int provinceId1, int provinceId2)
	{
		return 0f;
	}

	private int GetMaxNobleFamilies(int availableProvinces, PoliticalSystem politicalSystem)
	{
		return 0;
	}

	private int CalculateOptimalFamilyCount(int availableProvinces, int maxFamilies)
	{
		return 0;
	}

	private void ValidateAndAdjustInitialDistribution()
	{
	}

	private void RedistributeProvincesToUnderCapacityFamilies(List<Province> provincesToRedistribute, List<Family> families, int maxAllowedPerFamily)
	{
	}

	public void RecreateStateLabelList()
	{
	}

	public void RemoveHistoryNameLabels()
	{
	}

	internal void ShowCurrentNameLabels(bool v)
	{
	}

	public void SetStateLabelTriggerCheck(bool isActive)
	{
	}

	public void EmergencyCallArmy(int armyCount)
	{
	}

	private void EngageArmies(List<Army> armiesNotInBattle, int requiredArmies, ArmyType newType)
	{
	}

	public bool isMobilizeForEmergencyAvalible()
	{
		return false;
	}

	public void UpdateArmy()
	{
	}

	private void SpawnRebelEmergencyArmies()
	{
	}

	public void SpawnProvinceRebellionInitialArmies()
	{
	}

	private void TrySpawnProvinceRebellionReinforcement(int _warMonth)
	{
	}

	private void UpdateRegularArmyRecruitment()
	{
	}

	private void UpdateNavy()
	{
	}

	private void MigrateLegacyNavyBuildQueue()
	{
	}

	private Province SelectNavyBuildPort(List<Province> controlledPorts)
	{
		return null;
	}

	private int GetNavyBuildMonths()
	{
		return 0;
	}

	private bool CalculateLandArmySeaCrossingRestriction()
	{
		return false;
	}

	public bool IsLandArmySeaCrossingRestricted()
	{
		return false;
	}

	private void RecalculateBattleRate(out float fieldArmyEngageRate, out float garrisionEngageRate, out float regularEngageRate)
	{
		fieldArmyEngageRate = default;
		garrisionEngageRate = default;
		regularEngageRate = default;
	}

	public int GetArmyCount()
	{
		return 0;
	}

	public void RedeployIdleArmy()
	{
	}

	internal int GetNewArmyID()
	{
		return 0;
	}

	public void EnsureCustomNamingCollections()
	{
	}

	public bool HasCustomNamingData()
	{
		return false;
	}

	public void ClearCustomNaming()
	{
	}

	public void CopyCustomNamingFrom(State sourceState)
	{
	}

	public string GetBestTranslation(Dictionary<string, string> translations, string fallback = "")
	{
		return null;
	}

	public string GetResolvedStateBaseName()
	{
		return null;
	}

	public string GetStateBaseNameForLanguage(string language)
	{
		return null;
	}

	public string GetResolvedFormName()
	{
		return null;
	}

	public string GetResolvedCustomFullNameFormat()
	{
		return null;
	}

	public string GetResolvedFullNameFormat()
	{
		return null;
	}

	public void MarkStateNameDirty(bool refreshNow = false)
	{
	}

	public void SetCustomFullNameFormatForCurrentLanguage(string value)
	{
	}

	public string GetCustomFullNameFormatForLanguage(string language)
	{
		return null;
	}

	internal string GetBestTranslationForLanguage(Dictionary<string, string> translations, string preferredLanguage, string fallback = "")
	{
		return null;
	}

	private bool TryGetValidTranslationForLanguage(Dictionary<string, string> translations, string language, out string translatedText)
	{
		translatedText = null;
		return false;
	}

	public void RedeployIdleNavy()
	{
	}

	public bool IsFamilyDistributionViewActive()
	{
		return false;
	}

	public void OnProvinceRemoved(Province province, bool isRecordHistory = true)
	{
	}

	public void OnProvincesRemoved(List<Province> provinces)
	{
	}

	public void OnProvinceAdded(Province province, bool isRecordHistory = true)
	{
	}

	public void OnProvincesAdd(List<Province> provincesAdd)
	{
	}

	public bool CanProvinceRebel(Province province)
	{
		return false;
	}

	public void CheckProvinceToAbandon()
	{
	}

	public List<Province> GetAllyBorderEnemyProvince()
	{
		return null;
	}

	public void FilterBorderProvince()
	{
	}

	public void FilterBorderEnemyProvince()
	{
	}

	public List<Province> GetProvincesInBattle()
	{
		return null;
	}

	public bool HasTrait(string trait)
	{
		return false;
	}

	internal void AddTrait(string traitName)
	{
	}

	internal void RemoveTrait(string traitName)
	{
	}

	public void ApplyTraitEffect()
	{
	}

	private void AdjustAttributesByTraits()
	{
	}

	public void SetPropertyValue(string propertyName, object value)
	{
	}

	public void InitTrait()
	{
	}

	public void AdvanceOneMonth()
	{
	}

	internal void AdvanceOneYear()
	{
	}

	private void UpdateStateData()
	{
	}

	private void ValidateLeaderStatus()
	{
	}

	private void UpdateEcnomic()
	{
	}

	private void UpdateStateLandFeature()
	{
	}

	public void UpdateCoreProvince()
	{
	}

	internal void UpdateDiplomacy()
	{
	}

	public void UpdateReligionDistribution()
	{
	}

	private void UpdateSuperRebel()
	{
	}

	private void UpdateDestinyValue()
	{
	}

	private void CheckEmergencyMobilization()
	{
	}

	private bool ShouldCheckForRebellion()
	{
		return false;
	}

	private void ProcessRebellion()
	{
	}

	private void TriggerProvincialRebellion(List<Province> provincesMayRebel)
	{
	}

	private static Province SelectProvinceForRebellion(List<Province> _provinces)
	{
		return null;
	}

	public void UpdateAlliance()
	{
	}

	public void UpdateNeighborState()
	{
	}

	public void Update()
	{
	}

	private void CleanupReligionDistribution(Province province)
	{
	}

	public void DetermineStateReligionForOldSave()
	{
	}

	public void CheckTooMuchArmy()
	{
	}

	private void UpdateLeaderCombatModifier()
	{
	}
}
