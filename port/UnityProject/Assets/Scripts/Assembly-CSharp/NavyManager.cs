using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

public class NavyManager
{
	private static NavyManager s_Instance;

	private readonly List<Navy> m_Navies;

	private readonly Queue<Navy> m_NavyPool;

	private readonly Dictionary<int, HashSet<int>> m_AttackDeployedNavyIdsByStateId;

	private float m_NextDeploymentRefreshTime;

	private int m_UpdateIndex;

	private int m_UpdateBatchSize;

	private bool m_HasDisplayArmySettingCache;

	private bool m_LastDisplayArmySetting;

	private TextAsset m_NavySvgAsset;

	private const float c_DeploymentRefreshInterval = 1f;

	private const float c_DefaultArmyLabelScale = 0.35f;

	private const int c_DefaultUpdateBatchSize = 5;

	private const int c_NavyLayer = 11;

	private const string c_NavySvgAssetPath = "UI/NavyWarshipIcon_SVG";

	private static readonly ProfilerMarker s_UpdateProfilerMarker;

	private static readonly ProfilerMarker s_RefreshAttackDeploymentProfilerMarker;

	private static readonly ProfilerMarker s_RefreshVisibilityProfilerMarker;

	private static readonly ProfilerMarker s_NavalSystemUpdateProfilerMarker;

	private static readonly ProfilerMarker s_BatchUpdateProfilerMarker;

	private static readonly ProfilerMarker s_BatchUpdateSingleNavyProfilerMarker;

	private static readonly ProfilerMarker s_DestroyQueuedProfilerMarker;

	private int m_NextNavyID;

	public static NavyManager Instance => null;

	public IReadOnlyList<Navy> navies => null;

	private NavyManager()
	{
	}

	private static Color GetStateNavyColor(State _state)
	{
		return default;
	}

	private static float GetNavyIconScale(float _armyLabelScale)
	{
		return 0f;
	}

	public void Start(bool _isInitPathOnly = false)
	{
	}

	public void Clear()
	{
	}

	public Navy CreateNavy(Province _homePortProvince, int _stateID, bool isFromDeserialize = false)
	{
		return null;
	}

	private Navy GetNavyFromPool()
	{
		return null;
	}

	private Navy CreatePooledNavy()
	{
		return null;
	}

	private void ReturnNavyToPool(Navy _navy)
	{
	}

	private TextAsset GetNavySvgAsset()
	{
		return null;
	}

	private static void ConfigureNavyCollider(BoxCollider _collider)
	{
	}

	public void UpdateNavyScale(float _armyLabelScale)
	{
	}

	public void DestroyNavy(Navy _navy)
	{
	}

	public void Update()
	{
	}

	private void BatchUpdate(float _deltaTime, List<Navy> _toRemove)
	{
	}

	private void RefreshVisibilityIfNeeded()
	{
	}

	public void UpdateNavyVisibility(bool _isVisible)
	{
	}

	public string Serialize()
	{
		return null;
	}

	public void DeserializeNavies(string _json)
	{
	}

	public float GetStateNavyStrength(State _state)
	{
		return 0f;
	}

	public bool HasNavyOnPort(int _stateID, int _portProvinceID)
	{
		return false;
	}

	public bool HasAnyNavyOnPort(int _portProvinceID)
	{
		return false;
	}

	public int GetActiveNavyCountForState(int _stateId)
	{
		return 0;
	}

	public List<Navy> GetActiveNaviesForState(int _stateId)
	{
		return null;
	}

	public void TrimStateNaviesToLimit(State _state, int _limit)
	{
	}

	private void NormalizeOneNavyPerPort()
	{
	}

	private static void RecalculateStateNavyCount()
	{
	}

	public bool IsDeployedForAttack(Navy _navy)
	{
		return false;
	}

	private void RefreshAttackDeploymentIfNeeded()
	{
	}

	private static bool IsFrontlineHomePort(Navy _navy)
	{
		return false;
	}
}
