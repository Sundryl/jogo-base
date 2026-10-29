using System.Collections.Generic;
using NodaTime;
using UnityEngine;

namespace FantasyWorld.CharacterSystem
{
	public class FamilyManager
	{
		private class FamilyRedistributionInfo
		{
			public Family family;

			public float score;

			public int targetCount;

			public int remaining;

			public int maxAllowed;

			public Vector2 desiredCenter;

			public Province seedProvince;

			public bool hadLandBefore;
		}

		private class CivilWarFaction
		{
			public string name;

			public List<int> memberFamilyIds;

			public int candidateLeaderId;

			public float totalStrength;

			public CivilWarGoal goal;
		}

		private enum CivilWarGoal
		{
			ReplaceRuler = 0,
			SuccessionClaim = 1,
			PoliticalReform = 2
		}

		private static FamilyManager m_Instance;

		private Dictionary<int, Family> m_Families;

		private Dictionary<int, Family> m_HistoricalFamilies;

		private int m_NextFamilyId;

		private int m_NextColorIndex;

		private readonly List<int> m_PendingRemovePlaceholderStateFamilyIds;

		public bool isRecordFamilyCreateEvent;

		public static readonly int TERRITORY_REDISTRIBUTION_INTERVAL;

		private static readonly List<string> s_FamilyColorPalette;

		private List<Family> validFamiliesForNextMonth;

		public static FamilyManager Instance => null;

		private FamilyManager()
		{
		}

		public void Start()
		{
		}

		public Family CreateFamily(string name, string cultureName, int stateId, int homeProvinceId = 0)
		{
			return null;
		}

		public Family CreateFamily(string name, string cultureName, string religionId, int stateId, int homeProvinceId = 0)
		{
			return null;
		}

		public Family CreateFamilyWithInitialMembers(string name, string cultureName, string religionId, int stateId, int homeProvinceId = 0)
		{
			return null;
		}

		public void EnsureInitialFamilyMembers(Family family)
		{
		}

		private static void SetupInitialFamilyCharacter(Character character, Family family, float _age, string _overrideSurname)
		{
		}

		public Family GetFamily(int id)
		{
			return null;
		}

		public Family GetHistoricalFamily(int id)
		{
			return null;
		}

		public Family GetFamilyIncludingHistorical(int id)
		{
			return null;
		}

		public Dictionary<int, Family> GetAllHistoricalFamilies()
		{
			return null;
		}

		public List<Family> GetAllFamilies()
		{
			return null;
		}

		public List<Family> GetFamiliesByState(int stateId)
		{
			return null;
		}

		public bool HasAnyFamilyInState(int stateId)
		{
			return false;
		}

		public Family GetRulingFamily(int stateId)
		{
			return null;
		}

		public void SetRulingFamily(int stateId, int familyId)
		{
		}

		public void RemoveFamily(int id)
		{
		}

		public void Clear()
		{
		}

		public void ClearHistoricalData()
		{
		}

		public Color GetNextFamilyColor()
		{
			return default;
		}

		public void AssignRandomUpdateDays(LocalDate currentDate)
		{
		}

		public void UpdateFamilies(LocalDate currentDate)
		{
		}

		private void UpdateFamilyDuration(Family family)
		{
		}

		private void ProcessSingleFamilyPopulation(Family family)
		{
		}

		private void ProcessSingleFamilyMarriage(Family family)
		{
		}

		private void UpdateSingleFamilyInfluence(Family family)
		{
		}

		public void MonthlyUpdate()
		{
		}

		private void CheckProvinceControlConflicts()
		{
		}

		private void UpdateFamilyDurations()
		{
		}

		private void ProcessFamilyPopulation()
		{
		}

		private int ProcessBirths(Family family)
		{
			return 0;
		}

		private bool CanGiveBirth(Character character, Family family)
		{
			return false;
		}

		private float CalculateBirthChance(Character mother, Family family)
		{
			return 0f;
		}

		private bool HasYoungChild(Character parent, float ageThreshold)
		{
			return false;
		}

		private void CreateChild(Character mother, Family family)
		{
		}

		private bool IsImportantBirth(Character child, Character father, Character mother, Family childFamily)
		{
			return false;
		}

		private void InheritAttributes(Character child, Character father, Character mother)
		{
		}

		private float InheritAttribute(float fatherValue, float motherValue)
		{
			return 0f;
		}

		private void InheritTraits(Character child, Character father, Character mother)
		{
		}

		private void ProcessMarriages()
		{
		}

		private List<MarriageCandidate> FindMarriageCandidates(Character character, int maxCandidates)
		{
			return null;
		}

		public bool IsMarriageableInitiatorForUI(Character _character, bool _ignoreUpperAgeLimit = false, bool _ignoreLowerAgeLimit = false)
		{
			return false;
		}

		public bool IsMarriageCandidateForUI(Character _self, Character _candidate, bool _ignoreUpperAgeLimit = false, bool _ignoreLowerAgeLimit = false)
		{
			return false;
		}

		private bool IsCloseRelative(Character char1, Character char2)
		{
			return false;
		}

		private float CalculateMarriageScore(Character character, Character candidate)
		{
			return 0f;
		}

		private float CalculateGeographicProximity(Family family1, Family family2)
		{
			return 0f;
		}

		private float CalculatePersonalCompatibility(Character char1, Character char2)
		{
			return 0f;
		}

		private void ExecuteMarriage(Character character1, Character character2)
		{
		}

		public bool TryExecuteMarriageForUI(Character _character1, Character _character2)
		{
			return false;
		}

		private bool IsPoliticalMarriage(Character character1, Character character2, Family family1, Family family2)
		{
			return false;
		}

		private MarriageType DetermineMarriageType(Character character1, Character character2)
		{
			return MarriageType.Patrilineal;
		}

		private bool NeedsMatrilinealMarriage(Character character, Family family)
		{
			return false;
		}

		private bool CanMarryInto(Character character, Family family)
		{
			return false;
		}

		private void UpdateFamilyInfluence()
		{
		}

		public float CheckMarriageConnection(Family family1, Family family2)
		{
			return 0f;
		}

		public float CalculateFamilyRelation(Family family1, Family family2)
		{
			return 0f;
		}

		public string GetRelationBreakdown(Family family1, Family family2)
		{
			return null;
		}

		private float CalculateGeographicalModifier(Family family1, Family family2)
		{
			return 0f;
		}

		private float CalculateAverageFamilyDistance(Family family1, Family family2)
		{
			return 0f;
		}

		private float CalculatePowerGapModifier(Family family1, Family family2)
		{
			return 0f;
		}

		private float GetMaxProvinceRatio(PoliticalSystem politicalSystem)
		{
			return 0f;
		}

		private List<Province> IdentifyUncontrolledProvinces(State state)
		{
			return null;
		}

		private List<Family> GetLandlessFamilies(int stateId)
		{
			return null;
		}

		private List<Family> GetLandowningFamilies(int stateId)
		{
			return null;
		}

		private void AllocateUncontrolledProvinces(List<Province> uncontrolledProvinces, List<Family> allFamilies, List<Family> landlessFamilies, State state)
		{
		}

		public void RedistributeTerritoriesForState(int stateId)
		{
		}

		private List<FamilyRedistributionInfo> BuildRedistributionTargets(State state, List<Family> families)
		{
			return null;
		}

		private float CalculateEffectiveMaxRatio(float baseRatio, int familyCount)
		{
			return 0f;
		}

		private bool HasProvinceInState(Family family, State state)
		{
			return false;
		}

		private Vector2 CalculateFamilyDesiredCenter(Family family, State state)
		{
			return default;
		}

		private Province SelectSeedProvince(Family family, State state, HashSet<int> reservedSeeds, Vector2 desiredCenter)
		{
			return null;
		}

		private Dictionary<int, List<int>> AllocateProvincesForTargets(State state, List<FamilyRedistributionInfo> targets)
		{
			return null;
		}

		private void AssignProvinceToPlan(Province province, Family family, Dictionary<int, List<int>> assignments, Dictionary<int, HashSet<int>> assignmentSets, HashSet<int> unassigned)
		{
		}

		private void FillFamilyUsingClosestProvinces(State state, FamilyRedistributionInfo target, Dictionary<int, List<int>> assignments, Dictionary<int, HashSet<int>> assignmentSets, Dictionary<int, Queue<int>> frontiers, HashSet<int> unassigned)
		{
		}

		private float EvaluateProvinceForFamily(FamilyRedistributionInfo target, Province province, HashSet<int> plannedTerritory)
		{
			return 0f;
		}

		private bool IsAdjacentToPlannedTerritory(Province province, HashSet<int> plannedTerritory)
		{
			return false;
		}

		private Vector2 GetProvincePosition(Province province)
		{
			return default;
		}

		private void ApplyPlannedAssignments(State state, List<FamilyRedistributionInfo> targets, Dictionary<int, List<int>> assignments)
		{
		}

		private void UpdateFamilyHomeProvince(Family family, List<int> plannedProvinces)
		{
		}

		private void RecordRedistributionChanges(State state, List<FamilyRedistributionInfo> targets, Dictionary<int, int> initialProvinceCount)
		{
		}

		private void RecordTerritoryRedistributionEvent(State state, List<Family> families, Dictionary<int, int> actualChanges, int redistributedProvinceCount)
		{
		}

		private float GetFamilyWarContribution(Family family, State state)
		{
			return 0f;
		}

		private float CalculateFamilyBaseStrength(Family family)
		{
			return 0f;
		}

		private void AssignProvinceToWinner(Province province, Dictionary<int, float> claimScores)
		{
		}

		private float CalculateProvinceDistance(int province1Id, int province2Id)
		{
			return 0f;
		}

		private bool IsProvinceAdjacentToFamily(int provinceId, Family family)
		{
			return false;
		}

		private float CalculateFamilyStrengthWithWarMerit(Family family, State state)
		{
			return 0f;
		}

		private float CalculateFamilyWarMerit(Family family, State state)
		{
			return 0f;
		}

		private void CheckFamilyRebellions()
		{
		}

		private bool ShouldFamilyRebel(Family family)
		{
			return false;
		}

		private string DetermineFamilyRebellionCause(Family family, State state)
		{
			return null;
		}

		private State TryFamilyRestoration(Family family)
		{
			return null;
		}

		private float CalculateRestorationWeight(Family family, State targetState)
		{
			return 0f;
		}

		public void InitializeRulingHistory()
		{
		}

		private float CalculateRallyResponseProbability(Family initiator, Family target, bool isRestoration, int restorationStateId = 0)
		{
			return 0f;
		}

		private List<Family> RallyFamiliesForRebellion(Family initiator, bool isRestoration, int restorationStateId = 0)
		{
			return null;
		}

		public void StartFamilyRebellion(Family family)
		{
		}

		private void CheckFamilyExtinction(Family family)
		{
		}

		public void DebugPrintFamilyStrengths(int stateId)
		{
		}

		public void DebugTestProvinceDistance(int province1Id, int province2Id)
		{
		}

		public void YearlyUpdate()
		{
		}

		private void UpdateFamilyHistoricalClaims(Family family)
		{
		}

		public string Serialize()
		{
			return null;
		}

		public void Deserialize(string json)
		{
		}

		public static FamilyManagerSaveData ParseJsonOnly(string json)
		{
			return null;
		}

		public void ApplyParsedData(FamilyManagerSaveData saveData)
		{
		}

		public void PostLoadSaveData()
		{
		}

		public Character FindSuccessor(Family family, Character deceased)
		{
			return null;
		}

		private int CalculateSuccessionPriority(Character character, Family family, bool isCollateral, bool isFemaleInheritance)
		{
			return 0;
		}

		private Character CreateVirtualFamilyMember(Family family, Gender preferredGender)
		{
			return null;
		}

		public void HandlePatriarchSuccession(Family family)
		{
		}

		public void UpdateFamilyHeir(Family family)
		{
		}

		public void MaintainCollateralBranches(Family family)
		{
		}

		public Character CreateCollateralMember(Family family)
		{
			return null;
		}

		private void RemoveFarthestCollateral(Family family)
		{
		}

		public void HandleDynastyChange(State state)
		{
		}

		private void OutputYearlyFamilyReport()
		{
		}

		private void CheckGenderBalanceInFamilies()
		{
		}

		private void OutputPopulationStatistics()
		{
		}

		public void CreateAllFamilyLabels()
		{
		}

		private void CreateFamilyLabel(Family family)
		{
		}

		public void ForceUpdateFamilyName()
		{
		}

		public void ForceUpdateFamilyBorder()
		{
		}

		public void UpdateFamilyName(Family family)
		{
		}

		private int GetLargestLandProvinceCenter(Family _family)
		{
			return 0;
		}

		private bool IsFamilyCellPassable(int cellIndex, int familyId)
		{
			return false;
		}

		private void CheckCivilWarConditions()
		{
		}

		private void CheckStateForCivilWar(State state)
		{
		}

		private static WarGoalTypeV2 MapCivilWarGoalType(WarType civilWarType)
		{
			return WarGoalTypeV2.CedeProvince;
		}

		private static int MapCivilWarCb(WarType civilWarType)
		{
			return 0;
		}

		private WarType DetermineCivilWarType(State state, List<Family> rebelFamilies)
		{
			return WarType.Conquest;
		}

		private bool IsSameSurname(string name1, string name2)
		{
			return false;
		}

		private float GetDistanceFromCapital(State state, Province province)
		{
			return 0f;
		}

		private string DetermineCivilWarCause(WarType warType, State state, List<Family> rebelFamilies)
		{
			return null;
		}

		private State StartCivilWar(State state, List<Family> rebelFamilies)
		{
			return null;
		}

		public State TriggerCapitalFallCivilWar(State state)
		{
			return null;
		}

		private void TransferFamilyArmiesToRebelState(Family family, State originalState, State rebelState)
		{
		}

		private Character CreateRebelLeaderForFamily(Family family, State state)
		{
			return null;
		}

		public void DebugTriggerFamilyRebellion(int stateId)
		{
		}

		public void DebugTriggerCivilWar(int stateId)
		{
		}

		public void DebugShowRebellionInfo(int stateId)
		{
		}
	}
}
