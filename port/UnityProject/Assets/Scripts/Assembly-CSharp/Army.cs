using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Shapes;
using UnityEngine;

public class Army : MonoBehaviour
{
	public readonly struct BasicInfoRow
	{
		public string Key { get; }

		public string Value { get; }

		public BasicInfoRow(string key, string value)
		{
			Key = null;
			Value = null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CMoveToProvince_003Ed__117 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Army _003C_003E4__this;

		private List<int> _003Cpath_003E5__2;

		private float _003CcurrentSpeed_003E5__3;

		private Vector3 _003CoffsetPos_003E5__4;

		private List<int>.Enumerator _003C_003E7__wrap4;

		private int _003Ccell_003E5__6;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CMoveToProvince_003Ed__117(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CMoveToIdleProvince_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Army _003C_003E4__this;

		private List<int> _003Cpath_003E5__2;

		private Vector3 _003CoffsetPos_003E5__3;

		private float _003CcurrentSpeed_003E5__4;

		private List<int>.Enumerator _003C_003E7__wrap4;

		private int _003Ccell_003E5__6;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CMoveToIdleProvince_003Ed__118(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CRandomMoveInProvince_003Ed__120 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Army _003C_003E4__this;

		public float interval;

		private float _003CcurrentSpeed_003E5__2;

		private float _003CwaitTime_003E5__3;

		private List<int>.Enumerator _003C_003E7__wrap3;

		private int _003Ccell_003E5__5;

		private Vector3 _003CtargetPos_003E5__6;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CRandomMoveInProvince_003Ed__120(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public ArmyType armyType;

	public ArmyOrder armyOrder;

	public ArmyState currentState;

	public int currentCell;

	public int preCell;

	public bool isMannulCreated;

	[HideInInspector]
	public bool isSelected;

	[HideInInspector]
	public bool isUnderRTSControl;

	[HideInInspector]
	public bool isRTSAttackMode;

	[JsonIgnore]
	public int rtsTargetCell;

	private static World world;

	private int targetEnemyStateID;

	private Coroutine moveFollowPathCoroutine;

	public int armyID;

	public bool isMoving;

	public bool isEmergencyCall;

	public Province homeProvince;

	public int homeProvinceID;

	public int targetProvinceID;

	public Province targetProvinceObject;

	public int stateID;

	public State state;

	public int familyId;

	public bool isCentralArmy;

	public bool isElite;

	public string unitKey;

	public float armyCount;

	public static int maxArmyCount;

	private float speed;

	private float battleTimer;

	private const float damageInterval = 2f;

	private float damageIntervalRnd;

	private const float baseDamageToArmy = 40f;

	private const float baseDamageToProvince = 10f;

	private float damageToProvince;

	private float damageToArmy;

	private const float c_BlockadedPortLandAttackDamageMultiplier = 2f;

	private const float c_PortPreferenceMinProvinceDistance = 25f;

	private float lastUpdateTime;

	private float deltaTime;

	public bool isDebug;

	public bool isMovingToTargetProvince;

	public float baseCombatEfficiency;

	public const float c_CommandSkillBaseline = 50f;

	public const float c_CommandSkillDivisor = 150f;

	public double foundingTime;

	public List<int> participatedCampaigns;

	public float enemyArmyDestroyedCount;

	public List<Tuple<int, double>> conqueredProvincesInfo;

	public GameObject armyInner;

	public GameObject armyLine;

	public GameObject armyInSea;

	public GameObject armyElite;

	public SpriteRenderer avatarSquare;

	public Transform armySelectCircle;

	private GameObject selectCircle;

	private SvgIconRenderer m_ArmyIconRenderer;

	private MeshRenderer m_SvgMeshRenderer;

	private Rectangle m_ArmyRectangle;

	private SpriteRenderer m_ArmySpriteRenderer;

	private const string c_DefaultArmySpriteIconResourcePath = "Sprites/army-chess-knight-icon";

	private const string c_ArmyChessPawnSpriteIconResourcePath = "Sprites/army-chess-pawn-icon";

	private const string c_RecurveBowArrowSpriteIconResourcePath = "Sprites/recurve-bow-arrow-icon";

	private const string c_ShieldCrossSpriteIconResourcePath = "Sprites/shield-cross-icon";

	private const string c_ArmyTransportShipSpriteIconResourcePath = "Sprites/army-transport-ship-icon";

	private const float c_ArmySpriteIconScale = 1.2f;

	private const float c_ArmySpriteIconScaleMultiplier = 0.7f;

	private static readonly string[] s_ArmySpriteIconResourcePaths;

	private static readonly Dictionary<string, Sprite> s_ArmySpriteIconCache;

	private string m_ArmySpriteIconResourcePath;

	private readonly List<BasicInfoRow> m_BasicInfoRowsCache;

	private Province targetIdleProvinceObject;

	private bool IsSvgIconEnabled => false;

	private bool IsSpriteIconEnabled => false;

	public static float GetMedianMaxArmyCount()
	{
		return 0f;
	}

	public float GetMaxArmyCount()
	{
		return 0f;
	}

	private bool IsCurrentCellValid()
	{
		return false;
	}

	private bool TryGetCurrentProvince(out Province _province)
	{
		_province = null;
		return false;
	}

	private static int ResolveProvinceIdFromCell(int _cell)
	{
		return 0;
	}

	public void SetCurrentCell(int _cell)
	{
	}

	public void SetTargetProvince(Province _targetProvince)
	{
	}

	public float GetSpeed()
	{
		return 0f;
	}

	public string Serialize()
	{
		return null;
	}

	public static Army Deserialize(string jsonString, World world)
	{
		return null;
	}

	public void PostLoadSaveData()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	public void Clear()
	{
	}

	public void CleanupForRemoval()
	{
	}

	public void Init()
	{
	}

	public float GetArmyLabelScale()
	{
		return 0f;
	}

	public void AssignUnitKey(string _unitKey)
	{
	}

	public string GetUnitDisplayName()
	{
		return null;
	}

	private MilitaryProfile GetResolvedMilitaryProfile()
	{
		return null;
	}

	private float GetLandUnitMovementSpeedMultiplier()
	{
		return 0f;
	}

	private float GetLandUnitSpriteScaleMultiplier()
	{
		return 0f;
	}

	private float GetTerrainCombatModifier(Province _province, bool _isAttacking)
	{
		return 0f;
	}

	public void SetVisibility(bool isVisible)
	{
	}

	public bool IsOnLand()
	{
		return false;
	}

	public void SetOnLand(bool isOnLand)
	{
	}

	public void RefreshIconMode()
	{
	}

	public string GetName(bool isNeedDefaultFont = true)
	{
		return null;
	}

	public void CalBaseCombatEfficiency()
	{
	}

	public void UpdateState()
	{
	}

	public void SafetyCheck()
	{
	}

	public void ReorganizationUpdate()
	{
	}

	public void ChangeState(ArmyState newState)
	{
	}

	private void ExitCurrentState()
	{
	}

	private void EnterNewState(ArmyState newState)
	{
	}

	public void ResetIdleProvince()
	{
	}

	private void Idle()
	{
	}

	private Province FindTargetIdleProvince()
	{
		return null;
	}

	private HashSet<Province> GetCapitalAreaProvinces(List<Province> _allProvinces)
	{
		return null;
	}

	private bool HasNonBlankForeignLandNeighbor(Province _province, List<Province> _allProvinces)
	{
		return false;
	}

	private Province WeightedRandomSelection(List<Province> provinces, List<float> weights)
	{
		return null;
	}

	private void Attacking()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveToProvince_003Ed__117))]
	private IEnumerator MoveToProvince()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMoveToIdleProvince_003Ed__118))]
	private IEnumerator MoveToIdleProvince()
	{
		return null;
	}

	private bool ShouldBlockSeaCrossing(List<int> path)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CRandomMoveInProvince_003Ed__120))]
	private IEnumerator RandomMoveInProvince(float interval)
	{
		return null;
	}

	public bool ShouldDestroy()
	{
		return false;
	}

	public bool ShouldReorganization()
	{
		return false;
	}

	public ArmyOrganization GetArmyOrganization()
	{
		return ArmyOrganization.Regular;
	}

	private bool IsPortCityProvince(Province _province)
	{
		return false;
	}

	private bool IsCrossSeaTargetProvince(Province _province, int _currentCellFeature)
	{
		return false;
	}

	private bool ShouldPreferPortTransitionForPath(int _startProvinceId, int _endProvinceId)
	{
		return false;
	}

	private bool ShouldEnableSeaRoutePreferenceForPath(int _startProvinceId, int _endProvinceId)
	{
		return false;
	}

	private Province FindTargetProvince()
	{
		return null;
	}

	private Province FindRebelProvinceWithHighPriority()
	{
		return null;
	}

	private Province FindRegularTargetProvince()
	{
		return null;
	}

	private Province FindTargetRebelProvince()
	{
		return null;
	}

	internal bool FightingInEnemyTerritory()
	{
		return false;
	}

	private void BattleInProvince()
	{
	}

	private void BattleInSeaProvince()
	{
	}

	private float CalculateLeadershipModifier()
	{
		return 0f;
	}

	private float CalculateLeadershipModifierInternal()
	{
		return 0f;
	}

	private float RecalCombatEfficiency()
	{
		return 0f;
	}

	private void AddDamageToEnemyArmyInProvince(float combatEfficiency, float damageMultiplier = 1f)
	{
	}

	private bool IsTargetPortBlockadedForLandBattle()
	{
		return false;
	}

	private int GetRandomCellInProvince(Province province)
	{
		return 0;
	}

	internal void EngageInBattle()
	{
	}

	internal void DisEngageFromBattle()
	{
	}

	internal bool IsInBattle()
	{
		return false;
	}

	internal void Reorganization()
	{
	}

	public string GetArmyHistory(bool isNeedDefaultFont = true)
	{
		return null;
	}

	public void EnableSelectCircle(bool isEnabled, Color color)
	{
	}

	public void FillBasicInfoRows(List<BasicInfoRow> target)
	{
	}

	public IReadOnlyList<BasicInfoRow> GetBasicInfoRows()
	{
		return null;
	}

	public string GetHomeProvinceStatus()
	{
		return null;
	}

	public string GetCurrentStatus()
	{
		return null;
	}

	public string GetCurrentPosition()
	{
		return null;
	}

	private void PopulateBasicInfoRows(List<BasicInfoRow> rows)
	{
	}

	private BasicInfoRow BuildArmySizeRow()
	{
		return default;
	}

	private BasicInfoRow BuildEnemyDestroyedRow()
	{
		return default;
	}

	private BasicInfoRow BuildUnitTypeRow()
	{
		return default;
	}

	private BasicInfoRow BuildCurrentStatusRow(Province currentProvince)
	{
		return default;
	}

	private bool TryBuildMarchSpeedRow(Province currentProvince, out BasicInfoRow row)
	{
		row = default;
		return false;
	}

	private BasicInfoRow BuildHomeProvinceRow()
	{
		return default;
	}

	private BasicInfoRow BuildCurrentPositionRow(Province currentProvince)
	{
		return default;
	}

	private string ComposeHomeProvinceValue()
	{
		return null;
	}

	private string ComposeCurrentPositionValue(Province currentProvince)
	{
		return null;
	}

	private string BuildCurrentStatusValue(Province currentProvince)
	{
		return null;
	}

	private string BuildAttackingStatusValue(Province currentProvince)
	{
		return null;
	}

	private string BuildMarchSpeedValue(Province currentProvince)
	{
		return null;
	}

	private Province GetCurrentProvince()
	{
		return null;
	}

	internal void UpdateColor(Color color)
	{
	}

	private void EnsureSpriteRenderer()
	{
	}

	private void UpdateSpriteModeVisuals(bool isVisible, bool isOnLand)
	{
	}

	private void ApplySpriteRendererTransform()
	{
	}

	private void AssignRandomSpriteIcon()
	{
	}

	private string GetResolvedArmySpriteIconResourcePath()
	{
		return null;
	}

	private string GetDisplayedArmySpriteIconResourcePath(bool isOnLand)
	{
		return null;
	}

	private Color GetDisplayedSpriteTintColor(Color baseColor, bool isOnLand)
	{
		return default;
	}

	private void ApplyDisplayedSpriteIcon(bool isOnLand)
	{
	}

	private static Sprite LoadArmySpriteIcon(string resourcePath)
	{
		return null;
	}

	private void EnsureSvgRenderer()
	{
	}

	private void SetLegacyIconActive(bool isActive)
	{
	}

	private void SetRectangleEnabled(bool isEnabled)
	{
	}

	private void SetActiveIfNotNull(GameObject target, bool isActive)
	{
	}

	private void RecordBattleMerit(float enemyDestroyed)
	{
	}

	private void RecordConquestMerit(int provincesConquered)
	{
	}

	public void RTSMoveToProvince(Province targetProvince, int targetCell, bool isAttackMode = true)
	{
	}
}
