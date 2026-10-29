using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

public class ArmyManager
{
	private static readonly ProfilerMarker s_UpdateProfilerMarker;

	private static readonly ProfilerMarker s_CollectChangesProfilerMarker;

	private static readonly ProfilerMarker s_DestroyQueuedProfilerMarker;

	private static readonly ProfilerMarker s_BatchUpdateProfilerMarker;

	public static ArmyManager _instance;

	private const string c_ArmyPrefabPath = "Prefab/ArmyShape";

	private const string c_ArmySvgPrefabPath = "Prefab/ArmyShape_SVG";

	public GameObject armyPrefab;

	public int objectCount;

	private int updateIndex;

	public int updateBatchSize;

	private bool m_UseArmyIconSVG;

	private bool m_IsPoolInitialized;

	private readonly List<Army> m_ArmiesToRemove;

	public List<Army> armies;

	private Queue<GameObject> pool;

	public static ArmyManager Instance => null;

	private void LoadArmyPrefab(bool useSvg)
	{
	}

	public void UpdateArmyIconMode(bool useSvg)
	{
	}

	public void PostLoadSaveData()
	{
	}

	public Army CreateArmy(Province province, bool isEmergencyCall = false, int stateID = -1, bool isElite = false, int familyId = 0, string explicitUnitKey = null)
	{
		return null;
	}

	public List<Army> CreateArmies(IReadOnlyList<Province> provinces, bool isEmergencyCall = false, int stateID = -1, bool isElite = false, int familyId = 0, string explicitUnitKey = null)
	{
		return null;
	}

	private void DetermineArmyFamilyAndType(Army army, Province province, int specifiedFamilyId, bool isEmergencyCall)
	{
	}

	public void Clear()
	{
	}

	public void Start(bool isInitPathOnly = false)
	{
	}

	private void BuildPool()
	{
	}

	public GameObject GetObject()
	{
		return null;
	}

	public void ReturnObject(GameObject obj)
	{
	}

	public string Serialize()
	{
		return null;
	}

	public void DeserializeArmies(string json, World world)
	{
	}

	public void Update()
	{
	}

	public void DestroyArmy(Army army)
	{
	}

	public void BatchUpdate()
	{
	}

	internal void UpdateArmyVisibility(bool isVisible)
	{
	}

	internal void UpdateArmyScale(float armyLabelScale)
	{
	}

	private void OutputArmyStatistics()
	{
	}
}
