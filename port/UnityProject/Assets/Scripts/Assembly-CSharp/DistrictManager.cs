using System;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

public class DistrictManager
{
	private static readonly ProfilerMarker s_UpdateProfilerMarker;

	private static readonly ProfilerMarker s_UpdateLabelsProfilerMarker;

	private static readonly ProfilerMarker s_GenerateAllDistrictsProfilerMarker;

	private static readonly ProfilerMarker s_GenerateDistrictsForStateProfilerMarker;

	private const int c_MinDistrictProvinceCount = 4;

	private const int c_MaxDistrictProvinceCount = 8;

	private static DistrictManager _instance;

	public List<District> districts;

	private readonly Dictionary<int, District> m_DistrictById;

	private readonly HashSet<int> m_BatchedMaterialRefreshProvinceIds;

	private readonly HashSet<int> m_BatchedMaterialRefreshDistrictIds;

	private readonly HashSet<int> m_BatchedMaterialRefreshedProvinceIds;

	private int m_NextDistrictId;

	private int m_MaterialRefreshBatchDepth;

	public static DistrictManager Instance => null;

	private DistrictManager()
	{
	}

	public string Serialize()
	{
		return null;
	}

	public void Deserialize(string json)
	{
	}

	public void PostLoadSaveData()
	{
	}

	public DistrictRuntimeSnapshot CaptureRuntimeSnapshot()
	{
		return null;
	}

	public bool TryRestoreFromSnapshot(DistrictRuntimeSnapshot snapshot)
	{
		return false;
	}

	private bool RestoreCurrentDistrictList(bool allowAutoGenerateFallback)
	{
		return false;
	}

	public void Clear()
	{
	}

	public void Update()
	{
	}

	public void CreateAllDistrictLabels()
	{
	}

	public void ForceUpdateDistrictName()
	{
	}

	public void ForceUpdateDistrictBorder()
	{
	}

	public void UpdateDistrictLabelsIfNeeded()
	{
	}

	private void CreateDistrictLabel(District district)
	{
	}

	private void UpdateDistrictName(District district)
	{
	}

	private void RemoveDistrictLabel(District district, bool removeBorderLine = true)
	{
	}

	public void GenerateAllDistrictsFromStates()
	{
	}

	public void GenerateDistrictsForState(int stateId)
	{
	}

	public void GenerateDistrictsForProvinces(IEnumerable<Province> provinces)
	{
	}

	public bool HasAvailableDistrictGenerationProvince()
	{
		return false;
	}

	private void GenerateDistrictsForProvincePool(List<Province> provinces)
	{
	}

	private void CreateDistrictsForComponent(List<Province> component, Dictionary<int, HashSet<int>> adjacency, List<District> generatedDistricts, List<string> supportedLanguages)
	{
	}

	private static List<Province> GetDistrictGenerationProvinces(int stateId = -1)
	{
		return null;
	}

	private static Dictionary<int, HashSet<int>> BuildProvinceAdjacency(List<Province> provinces)
	{
		return null;
	}

	private static List<List<Province>> BuildProvinceComponents(List<Province> provinces, Dictionary<int, HashSet<int>> adjacency)
	{
		return null;
	}

	private static List<int> BuildRandomDistrictSizePlan(int provinceCount)
	{
		return null;
	}

	private static List<Province> SelectDistrictSeeds(List<Province> provinces, int seedCount)
	{
		return null;
	}

	private static List<List<int>> AssignProvincesToDistricts(List<Province> component, Dictionary<int, HashSet<int>> adjacency, List<Province> seeds, List<int> targetSizes)
	{
		return null;
	}

	private static bool TryExpandClusters(List<HashSet<int>> clusterMembers, List<int> clusterSizes, List<int> targetSizes, HashSet<int> unassignedProvinceIds, Dictionary<int, HashSet<int>> adjacency, Dictionary<int, Province> provinceById, List<Province> seeds, bool onlyClustersBelowTargetSize)
	{
		return false;
	}

	private static int FindBestAdjacentProvinceForCluster(HashSet<int> clusterMembers, HashSet<int> unassignedProvinceIds, Dictionary<int, HashSet<int>> adjacency, Dictionary<int, Province> provinceById, Province seed)
	{
		return 0;
	}

	private static Province ResolveClusterCenterProvince(List<int> provinceIds, Province seed, Dictionary<int, Province> provinceById)
	{
		return null;
	}

	public void OnProvinceStateChanged(Province province, State oldState, State newState)
	{
	}

	public District GetDistrict(int districtId)
	{
		return null;
	}

	public List<District> GetDistrictsByState(int stateId)
	{
		return null;
	}

	public int GetDistrictCountForState(int stateId)
	{
		return 0;
	}

	public District CreateDistrict(string preferredName = null, int centerProvinceId = 0)
	{
		return null;
	}

	private void AssignInitialColorToNewDistrict(District district)
	{
	}

	public bool RenameDistrict(int districtId, string newName)
	{
		return false;
	}

	public bool UpdateDistrictTranslatedNames(int districtId, Dictionary<string, string> translatedNames)
	{
		return false;
	}

	public bool RemoveDistrict(int districtId)
	{
		return false;
	}

	public bool TryAssignProvinceToDistrict(int provinceId, int districtId)
	{
		return false;
	}

	public bool TryClearProvinceDistrict(int provinceId)
	{
		return false;
	}

	public Color GetDistrictColorForProvince(Province province)
	{
		return default;
	}

	public Color GetDistrictDisplayColor(District district)
	{
		return default;
	}

	public bool UpdateDistrictColor(int districtId, Color color)
	{
		return false;
	}

	public void BeginDistrictMembershipMaterialRefreshBatch()
	{
	}

	public void EndDistrictMembershipMaterialRefreshBatch()
	{
	}

	private void ClearDistrictMembershipMaterialRefreshBatch()
	{
	}

	private void UpdateDistrictLabelColor(District district)
	{
	}

	public void OnStateColorChanged(State state)
	{
	}

	private void ResetRuntimeData()
	{
	}

	private void RebuildRuntimeIndicesFromCurrentDistrictList()
	{
	}

	private bool TryRegisterLoadedDistrict(District district, HashSet<int> assignedProvinceIds, List<string> supportedLanguages)
	{
		return false;
	}

	private void EnsureNeutralDistrict()
	{
	}

	private int GetGeneratedDistrictCount()
	{
		return 0;
	}

	private void RegisterDistrict(District district)
	{
	}

	private void ClearDistrictAssignments(List<Province> provinces)
	{
	}

	private static bool IsEditableProvince(Province province)
	{
		return false;
	}

	private static bool IsProvinceEligibleForDistrictGeneration(Province province)
	{
		return false;
	}

	private static void RemoveProvinceFromDistrict(District district, Province province)
	{
	}

	private void RemoveDistrictIfEmpty(District district)
	{
	}

	private void RefreshDistrictRuntimeState(District district)
	{
	}

	private static float GetProvinceDistance(Province a, Province b)
	{
		return 0f;
	}

	private static Province PickRandomProvinceFromPool(List<Province> provincePool, Province fallbackProvince = null)
	{
		return null;
	}

	private static Province ResolveDistrictNameSourceProvince(District district)
	{
		return null;
	}

	private static List<string> GetSupportedLanguages()
	{
		return null;
	}

	private static Dictionary<string, string> BuildGeneratedDistrictNameTemplate(Province sourceProvince, List<string> languages)
	{
		return null;
	}

	private static Dictionary<string, string> BuildTranslatedNames(Dictionary<string, string> preferredNames, List<string> languages)
	{
		return null;
	}

	private static Dictionary<string, string> SanitizeTranslatedNames(Dictionary<string, string> translatedNames)
	{
		return null;
	}

	private static string GetFirstValidName(Dictionary<string, string> translatedNames)
	{
		return null;
	}

	private static string BuildDistrictNameWithWord(string baseName, string language)
	{
		return null;
	}

	private static bool IsCjkStyleLanguage(string language)
	{
		return false;
	}

	private static string GetDistrictWordForLanguage(string language)
	{
		return null;
	}

	private static string ResolveLanguageOrDefault()
	{
		return null;
	}

	private void AssignGeneratedDistrictAutoColors(List<District> generatedDistricts)
	{
	}

	private static Color GetDistrictPreferredRankingColor(District district, List<Color> palette)
	{
		return default;
	}

	private static Dictionary<int, HashSet<int>> BuildDistrictAdjacencySnapshot(List<District> currentDistricts)
	{
		return null;
	}

	private static int ChooseBestPaletteColorIndex(District district, Dictionary<int, HashSet<int>> adjacency, List<Color> palette, Dictionary<int, Color> resolvedColors, Dictionary<int, int> paletteUsageCounts)
	{
		return 0;
	}

	private static HashSet<int> RepairDistrictColorConflicts(List<District> allDistricts, HashSet<int> targetDistrictIds, Dictionary<int, HashSet<int>> adjacency, List<Color> palette, Dictionary<int, Color> resolvedColors, Dictionary<int, int> paletteUsageCounts)
	{
		return null;
	}

	private static District SelectDistrictForColorRepair(District firstDistrict, District secondDistrict, HashSet<int> targetDistrictIds)
	{
		return null;
	}

	private static bool TryChooseDistrictReplacementColor(District district, Dictionary<int, HashSet<int>> adjacency, List<Color> palette, Dictionary<int, Color> resolvedColors, Dictionary<int, int> paletteUsageCounts, out Color replacementColor)
	{
		replacementColor = default;
		return false;
	}

	private static List<Color> GetResolvedNeighborColors(int districtId, Dictionary<int, HashSet<int>> adjacency, Dictionary<int, Color> resolvedColors)
	{
		return null;
	}

	private static int CountColorConflictsWithNeighbors(Color color, List<Color> neighborColors)
	{
		return 0;
	}

	private static int GetDistrictProvinceCellCount(District district)
	{
		return 0;
	}

	private static bool TryGetPaletteIndex(List<Color> palette, Color color, out int paletteIndex)
	{
		paletteIndex = default;
		return false;
	}

	private static float GetColorDistance(Color colorA, Color colorB)
	{
		return 0f;
	}

	private void RefreshDistrictProvinceMaterials(Func<District, bool> districtFilter = null)
	{
	}

	private void RefreshDistrictProvinceMaterials(District district)
	{
	}

	private void RefreshDistrictMembershipMaterials(Province changedProvince, params District[] affectedDistricts)
	{
	}

	private static bool DistrictTouchesState(District district, int stateId)
	{
		return false;
	}

	private static bool TryResolveDistrictPoleCell(District district, out int poleCellIndex)
	{
		poleCellIndex = default;
		return false;
	}

	private static List<Province> GetDistrictProvincesSnapshot(District district)
	{
		return null;
	}

	private Color ResolveDistrictLabelColor(District district)
	{
		return default;
	}
}
