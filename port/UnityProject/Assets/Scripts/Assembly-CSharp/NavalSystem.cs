using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

public sealed class NavalSystem
{
	private const float c_DefaultArmyLabelScale = 0.35f;

	private static NavalSystem s_Instance;

	private readonly Dictionary<int, NavalPortData> m_PortsByProvinceId;

	private readonly Dictionary<int, MerchantShipRuntime> m_MerchantShipsByHomePort;

	private readonly Queue<MerchantShipRuntime> m_MerchantShipPool;

	private readonly Dictionary<int, float> m_MerchantShipRebuildReadyGameTimeByHomePort;

	private readonly Dictionary<int, HashSet<int>> m_NavyStatesByCell;

	private readonly Dictionary<int, int> m_PortProvinceIdBySeaCell;

	private readonly Dictionary<int, GameObject> m_BlockPortMarkersByProvinceId;

	private readonly Queue<GameObject> m_BlockPortMarkerPool;

	private readonly Dictionary<int, Vector3> m_PortBattleFxPositionByProvinceId;

	private readonly Dictionary<int, float> m_PortBattleFxNextShuffleTimeByProvinceId;

	private readonly Dictionary<int, GameObject> m_PortFeatureLabelsByProvinceId;

	private GameObject m_PortFeatureDebugCanvasObject;

	private Transform m_PortFeatureDebugLabelRoot;

	private bool m_LastPortFeatureDebugLabelEnabled;

	private float m_NextPortFeatureLabelSyncTime;

	private int m_LastProvinceCount;

	private int m_LastCellCount;

	private int m_LastFeatureClusterCount;

	private bool m_LastArmyDisplayVisible;

	private bool m_HasArmyDisplayVisibleCache;

	private float m_NextHeavyUpdateTime;

	private float m_NextPortStaleCheckTime;

	private float m_NextBlockPortMarkerSyncTime;

	private GameObject m_BlockPortMarkerPrefab;

	private Transform m_BlockPortMarkerRoot;

	private bool m_IsBlockPortMarkerPoolWarmed;

	private TextAsset m_MerchantShipSvgAsset;

	private const float c_HeavyUpdateInterval = 0.5f;

	private const float c_MerchantRouteFailBaseCooldown = 1f;

	private const float c_MerchantRouteFailMaxCooldown = 8f;

	private const float c_MerchantShipMaxHealth = 8f;

	private const float c_MerchantShipRebuildCooldownMonths = 3f;

	private const float c_DaysPerMonthForMerchantRebuild = 30f;

	private const int c_MerchantRouteReplanBudgetPerFrame = 12;

	private const float c_PortStaleCheckInterval = 2f;

	private const float c_PortFeatureLabelSyncInterval = 1f;

	private const float c_PortFeatureLabelSyncIntervalDebug = 0.2f;

	private const float c_BlockPortMarkerSyncInterval = 0.25f;

	private const float c_BlockPortMarkerZ = -0.385f;

	private const float c_BlockPortMarkerYOffsetFactor = -0.32f;

	private const float c_BlockPortMarkerVisibleMaxCameraSize = 23.55011f;

	private const float c_PortBattleFxShuffleMinInterval = 0.45f;

	private const float c_PortBattleFxShuffleMaxInterval = 1.1f;

	private const int c_BlockPortMarkerPoolWarmupCount = 24;

	private const int c_MerchantShipLayer = 11;

	private const string c_MerchantShipSvgAssetPath = "UI/NavyIcon_SVG";

	private const float c_MerchantShipIconBaseZ = -0.351f;

	private const float c_NavyIconBaseZ = -0.349f;

	private const float c_ShipIconStableOffsetRange = 0.0012f;

	private static readonly ProfilerMarker s_UpdateProfilerMarker;

	private static readonly ProfilerMarker s_EnsureInitializedProfilerMarker;

	private static readonly ProfilerMarker s_UpdateEnsureInitializedProfilerMarker;

	private static readonly ProfilerMarker s_HeavyUpdateProfilerMarker;

	private static readonly ProfilerMarker s_UpdatePortOccupationRecoveryProfilerMarker;

	private static readonly ProfilerMarker s_EnsureMerchantShipsProfilerMarker;

	private static readonly ProfilerMarker s_UpdateMerchantShipsProfilerMarker;

	private static readonly ProfilerMarker s_UpdateMerchantVisibilityProfilerMarker;

	private static readonly ProfilerMarker s_TryGetIdleDeploymentTargetProfilerMarker;

	private static readonly ProfilerMarker s_FindBestEnemyPortTargetProfilerMarker;

	private static readonly ProfilerMarker s_BuildFriendlyNavyCountInPortProfilerMarker;

	private static readonly ProfilerMarker s_RebuildPortsProfilerMarker;

	public static NavalSystem Instance => null;

	private NavalSystem()
	{
	}

	public void Reset()
	{
	}

	public void Update(float _deltaTime)
	{
	}

	public float GetPortBuildTimeMultiplier(State _state)
	{
		return 0f;
	}

	public List<Province> GetControlledPorts(State _state)
	{
		return null;
	}

	public bool TryGetRandomPortCell(int _portProvinceId, out int _cell)
	{
		_cell = default;
		return false;
	}

	public bool TryGetRandomPortCell(int _portProvinceId, int _preferredSeaFeatureId, out int _cell)
	{
		_cell = default;
		return false;
	}

	public int GetPortSeaAnchorCell(int _portProvinceId)
	{
		return 0;
	}

	public int GetPortSeaAnchorCell(int _portProvinceId, int _preferredSeaFeatureId)
	{
		return 0;
	}

	public bool TryGetPortProvinceIdBySeaCell(int _cell, out int _portProvinceId)
	{
		_portProvinceId = default;
		return false;
	}

	public bool IsPortControlledByState(int _portProvinceId, int _stateId)
	{
		return false;
	}

	public bool IsPortLandOwnedByState(int _portProvinceId, int _stateId)
	{
		return false;
	}

	public void HandleWarEnded(IEnumerable<State> _warParticipants)
	{
	}

	public bool TryGetPortControllerStateId(int _portProvinceId, out int _stateId)
	{
		_stateId = default;
		return false;
	}

	public bool TryGetMerchantShipSnapshot(int _homePortProvinceId, out MerchantShipSnapshot _snapshot)
	{
		_snapshot = default;
		return false;
	}

	public bool TryGetMerchantShipTransform(int _homePortProvinceId, out Transform _shipTransform)
	{
		_shipTransform = null;
		return false;
	}

	public bool TryGetIdleDeploymentTarget(Navy _navy, int _preferPortProvinceId, out int _portProvinceId, out int _targetCell)
	{
		_portProvinceId = default;
		_targetCell = default;
		return false;
	}

	private static NavalPortData WeightedRandomPortSelection(List<NavalPortData> _ports, List<float> _weights)
	{
		return null;
	}

	public bool IsCellInPort(int _portProvinceId, int _cell)
	{
		return false;
	}

	public bool IsPortOccupiedByEnemyForState(int _portProvinceId, int _stateId)
	{
		return false;
	}

	public bool IsPortBlockaded(int _portProvinceId)
	{
		return false;
	}

	public bool IsPortValidAttackOrReclaimTarget(Navy _navyArmy, int _portProvinceId)
	{
		return false;
	}

	public NavalPortTarget FindBestEnemyPortTarget(Navy _navyArmy)
	{
		return default;
	}

	public NavalPortTarget FindBestEnemyPortTarget(Navy _navyArmy, out string _debugInfo)
	{
		_debugInfo = null;
		return default;
	}

	private static string FormatPortDebugEntry(NavalPortData _port, Province _landProvince)
	{
		return null;
	}

	private static string BuildPortDebugList(string _label, List<string> _ports)
	{
		return null;
	}

	private bool TryGetPortBattleFxPosition(NavalPortData _port, Navy _navyArmy, out Vector3 _position)
	{
		_position = default;
		return false;
	}

	public bool ApplyNavyOccupation(Navy _navyArmy, int _portProvinceId, float _deltaTime)
	{
		return false;
	}

	private void EnsureInitialized()
	{
	}

	private void RebuildPorts()
	{
	}

	private void UpdatePortBlockadeMarkers(bool force = false)
	{
	}

	private void EnsurePortFeatureDebugCanvas()
	{
	}

	private static bool TryGetStateName(int _stateId, out string _name)
	{
		_name = null;
		return false;
	}

	private static bool TryGetStateById(int _stateId, out State _state)
	{
		_state = null;
		return false;
	}

	private void DestroyPortFeatureDebugLabels()
	{
	}

	private void EnsureBlockPortMarkerPrefabLoaded()
	{
	}

	private void EnsureBlockPortMarkerRoot()
	{
	}

	private void WarmupBlockPortMarkerPool()
	{
	}

	private GameObject GetOrCreateBlockPortMarker(int _portProvinceId)
	{
		return null;
	}

	private GameObject GetBlockPortMarkerFromPool()
	{
		return null;
	}

	private void ReturnBlockPortMarkerToPool(GameObject _marker)
	{
	}

	private void ReturnAllActiveBlockPortMarkersToPool()
	{
	}

	private void DestroyBlockPortMarkers()
	{
	}

	private static bool IsPortBlockaded(NavalPortData _port)
	{
		return false;
	}

	private static bool TryGetPortCapitalCell(int _portProvinceId, out int _cell)
	{
		_cell = default;
		return false;
	}

	private static bool IsPortProvince(Province _province)
	{
		return false;
	}

	private NavalPortData BuildPortData(Province _province)
	{
		return null;
	}

	private static HashSet<int> CollectCoastalSeaCells(Province _province, int _capitalCell)
	{
		return null;
	}

	private static HashSet<int> ExpandSeaCells(HashSet<int> _startCells, int _maxDepth)
	{
		return null;
	}

	private static int SelectAnchorCell(int _capitalCell, HashSet<int> _frontierCells, HashSet<int> _portCells)
	{
		return 0;
	}

	private static bool TryGetProvinceCapitalBurg(Province _province, out BurgData _burg, out int _capitalCell)
	{
		_burg = null;
		_capitalCell = default;
		return false;
	}

	private void UpdatePortOccupationRecovery(float _deltaTime)
	{
	}

	private static bool HasNavyInPort(NavalPortData _port, int _stateId)
	{
		return false;
	}

	private static bool HasEnemyNavyInPort(NavalPortData _port, int _stateId)
	{
		return false;
	}

	private Dictionary<int, int> BuildFriendlyNavyCountInPort(int _stateId)
	{
		return null;
	}

	private Dictionary<int, int> BuildFriendlyNavyAssignedCountInPort(int _stateId)
	{
		return null;
	}

	private void EnsureMerchantShips()
	{
	}

	private bool CanSpawnMerchantShip(NavalPortData _port)
	{
		return false;
	}

	private MerchantShipRuntime CreateMerchantShip(NavalPortData _port)
	{
		return null;
	}

	private MerchantShipRuntime GetMerchantShipFromPool()
	{
		return null;
	}

	private MerchantShipRuntime CreatePooledMerchantShip()
	{
		return null;
	}

	private void ReturnMerchantShipToPool(MerchantShipRuntime _ship)
	{
	}

	private static void ResetMerchantShipRuntime(MerchantShipRuntime _ship)
	{
	}

	private TextAsset GetMerchantShipSvgAsset()
	{
		return null;
	}

	private static void ConfigureMerchantShipCollider(BoxCollider _collider)
	{
	}

	private static float GetMerchantShipIconScale(float _armyLabelScale)
	{
		return 0f;
	}

	public static Vector3 GetMerchantShipWorldPos(int _cell, int _stableId)
	{
		return default;
	}

	public static Vector3 GetNavyWorldPos(int _cell, int _stableId)
	{
		return default;
	}

	private static float GetStableShipZOffset(int _stableId)
	{
		return 0f;
	}

	private static Vector3 GetShipWorldPos(int _cell, int _stableId)
	{
		return default;
	}

	public void UpdateMerchantShipScale(float _armyLabelScale)
	{
	}

	private void UpdateMerchantShips(float _deltaTime)
	{
	}

	public bool HasEnemyMerchantShipInSeaProvince(int _seaProvinceId, State _attackerState)
	{
		return false;
	}

	public bool HasEnemyMerchantShipInSeaProvince(int _seaProvinceId, HashSet<State> _enemyStateSet)
	{
		return false;
	}

	public int GetEnemyMerchantShipCountInSeaProvince(int _seaProvinceId, State _attackerState)
	{
		return 0;
	}

	public int GetEnemyMerchantShipCountInSeaProvince(int _seaProvinceId, HashSet<State> _enemyStateSet)
	{
		return 0;
	}

	public int ApplyDamageToEnemyMerchantShipsInSeaProvince(int _seaProvinceId, State _attackerState, float _damagePerShip)
	{
		return 0;
	}

	public int ApplyDamageToEnemyMerchantShipsInSeaProvince(int _seaProvinceId, HashSet<State> _enemyStateSet, int _attackerStateId, float _damagePerShip)
	{
		return 0;
	}

	private bool IsMerchantShipEnemy(MerchantShipRuntime _ship, State _attackerState)
	{
		return false;
	}

	private bool IsMerchantShipEnemy(MerchantShipRuntime _ship, HashSet<State> _enemyStateSet)
	{
		return false;
	}

	private static bool IsMerchantShipInSeaProvince(MerchantShipRuntime _ship, int _seaProvinceId)
	{
		return false;
	}

	private static float GetCurrentGameTime()
	{
		return 0f;
	}

	private static float GetMerchantShipRebuildCooldownSeconds()
	{
		return 0f;
	}

	private bool IsMerchantShipRebuildReady(int _homePortProvinceId)
	{
		return false;
	}

	private void SinkMerchantShip(int _homePortProvinceId, int _seaProvinceId, int _attackerStateId)
	{
	}

	private bool EnsureShipRoute(MerchantShipRuntime _ship)
	{
		return false;
	}

	private static int GetPreferredSeaFeatureForMerchant(MerchantShipRuntime _ship)
	{
		return 0;
	}

	private static int ResolveSeaProvinceIdFromCell(int _cell)
	{
		return 0;
	}

	private static List<int> FindMerchantSeaPath(int _startCell, int _endCell)
	{
		return null;
	}

	private int ChooseTradeTargetPort(MerchantShipRuntime _ship)
	{
		return 0;
	}

	private void MoveMerchantShipAlongPath(MerchantShipRuntime _ship, float _deltaTime)
	{
	}

	private void UpdateMerchantVisibility()
	{
	}

	public void UpdateMerchantVisibility(bool _isVisible)
	{
	}

	private void UpdateMerchantShipColor(MerchantShipRuntime _ship)
	{
	}

	private void CleanupInvalidMerchantShips()
	{
	}

	private void RebuildNavyStatesByCell()
	{
	}

	private bool HasNavyInPortInternal(NavalPortData _port, int _stateId)
	{
		return false;
	}

	private static void LogPortOccupierChanged(int _portProvinceId, int _fromStateId, int _toStateId, string _reason)
	{
	}

	private void RequestPortFeatureDebugLabelRefresh()
	{
	}

	private bool HasEnemyNavyInPortInternal(NavalPortData _port, int _stateId)
	{
		return false;
	}

	private bool IsPortDataStale()
	{
		return false;
	}

	private static bool TryGetCellFeature(int _cell, out int _featureId)
	{
		_featureId = default;
		return false;
	}

	private static void ScheduleRouteRetry(MerchantShipRuntime _ship)
	{
	}
}
