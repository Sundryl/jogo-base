using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using DataStructures.ViliWonka.KDTree;
using FantasyWorld.CharacterSystem;
using Newtonsoft.Json;
using Puerts;
using TMPro;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;
using csDelaunay;

public class World : MonoBehaviour
{
	private enum DisplayModes
	{
		Plate = 0,
		Elevation = 1,
		Precipitation = 2,
		Biom = 3,
		Culture = 4,
		State = 5,
		StateCoreProvince = 6,
		Province = 7,
		DrawProvince = 8
	}

	[Serializable]
	public class SerializableVector2f
	{
		public float X { get; set; }

		public float Y { get; set; }

		public SerializableVector2f()
		{
		}

		public SerializableVector2f(Vector2f vector)
		{
		}

		public Vector2f ToVector2f()
		{
			return default;
		}
	}

	[Serializable]
	public class WorldSerializationData
	{
		public CellData CellData { get; set; }

		public List<List<SerializableVector2f>> Riverline { get; set; }

		public List<List<int>> OceanRoutes { get; set; }

		public List<BurgData> Burgs { get; set; }

		public List<BurgData> Seaburgs { get; set; }

		public List<Culture> Cultures { get; set; }

		public HashSet<int> MannualRiver { get; set; }

		public MilitaryProfile MapDefaultMilitaryProfile { get; set; }

		public OfficialTitleProfile MapDefaultOfficialTitles { get; set; }
	}

	private struct CellTraversalNode
	{
		public int CellIndex;

		public int Depth;
	}

	[CompilerGenerated]
	private sealed class _003CGenerateMapOnStart_003Ed__177 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public World _003C_003E4__this;

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
		public _003CGenerateMapOnStart_003Ed__177(int _003C_003E1__state)
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

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CGenerateMapOnStartPostChooseLanguage_003Ed__179 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public World _003C_003E4__this;

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
		public _003CGenerateMapOnStartPostChooseLanguage_003Ed__179(int _003C_003E1__state)
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

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSetWallPaperAsync_003Ed__218 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public World _003C_003E4__this;

		public int index;

		private int _003Cattempt_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003CDrawReliefRoutine_003Ed__324 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public World _003C_003E4__this;

		public bool allowYield;

		private HashSet<int> _003CburgCells_003E5__2;

		private int _003ChotDesertIndex_003E5__3;

		private int _003CcoldDesertIndex_003E5__4;

		private int _003CprocessedCells_003E5__5;

		private int _003Ci_003E5__6;

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
		public _003CDrawReliefRoutine_003Ed__324(int _003C_003E1__state)
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

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CGenerateObjectsCoroutine_003Ed__366 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public World _003C_003E4__this;

		private int _003CsitesPerFrame_003E5__2;

		private int _003CprocessedSites_003E5__3;

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
		public _003CGenerateObjectsCoroutine_003Ed__366(int _003C_003E1__state)
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

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CScrollToBottom_003Ed__547 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public World _003C_003E4__this;

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
		public _003CScrollToBottom_003Ed__547(int _003C_003E1__state)
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

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private static readonly ProfilerMarker s_ManagerUpdateProfilerMarker;

	private static readonly ProfilerMarker s_DiplomacyManagerUpdateProfilerMarker;

	private static readonly ProfilerMarker s_StateManagerUpdateProfilerMarker;

	private static readonly ProfilerMarker s_ProvinceManagerUpdateProfilerMarker;

	private static readonly ProfilerMarker s_DistrictManagerUpdateProfilerMarker;

	private static readonly ProfilerMarker s_TimeManagerUpdateProfilerMarker;

	private static readonly ProfilerMarker s_AutoSaveManagerUpdateProfilerMarker;

	private static readonly ProfilerMarker s_ArmyManagerUpdateProfilerMarker;

	private static readonly ProfilerMarker s_NavyManagerUpdateProfilerMarker;

	private static readonly ProfilerMarker s_UnitPresenceIndexFlushProfilerMarker;

	private static readonly ProfilerMarker s_BattleFxSystemUpdateProfilerMarker;

	private static readonly ProfilerMarker s_WarManagerUpdateProfilerMarker;

	private static readonly ProfilerMarker s_CampaignManagerUpdateProfilerMarker;

	private static readonly ProfilerMarker s_VassalManagerUpdateProfilerMarker;

	public Color riverColor;

	public Material DefaultMat;

	public Material LineMat;

	public Material OceanMat;

	public Material SimpleUnlit;

	public Transform CellPrefab;

	public Transform CityPrefab;

	public Transform ProvinceCenterPrefab;

	public Transform CapitalPrefab;

	public Transform PortPrefab;

	public Transform FortressPrefab;

	public Transform AttackArrowPrefab;

	public Transform AttackArrowPrefabWidth;

	public Transform AttackArrowShapePrefab;

	[Header("海路相关")]
	public Transform SeaRoutesPrefab;

	[SerializeField]
	private float seaRouteLineWidth;

	[SerializeField]
	private float seaRouteDashLength;

	[SerializeField]
	private float seaRouteGapLength;

	[SerializeField]
	private float seaRouteDashOffset;

	private readonly SeaRouteMeshBuilder m_SeaRouteMeshBuilder;

	private Mesh m_SeaRouteMesh;

	private MeshFilter m_SeaRouteMeshFilter;

	private MeshRenderer m_SeaRouteRenderer;

	private Transform m_SeaRouteMeshHolder;

	[Header("军队图标")]
	[SerializeField]
	private bool m_UseArmyIconSVG;

	[Header("其他")]
	public Transform PeacePrefab;

	public Transform AlliancePrefab;

	public TMP_FontAsset ChineseFont;

	public TMP_FontAsset KoreanFont;

	public TMP_FontAsset EnglishFont;

	public TMP_FontAsset EnglishMapFont;

	public TMP_FontAsset ChineseMapFont;

	public TMP_FontAsset EnglishCityNameFont;

	private Rectf bounds;

	public float BoundWidth;

	public float BoundHeight;

	public float BoundOffsetX;

	public float BoundOffsetY;

	public int Width;

	public int Height;

	public int PolyCount;

	public int cellsDesired;

	public CellData CellData;

	private MilitaryProfile m_MapDefaultMilitaryProfile;

	private OfficialTitleProfile m_MapDefaultOfficialTitles;

	public double mapSizeOutput;

	public double LatitudeOutput;

	public MapCoordinates mapCoordinates;

	public int stateCount;

	public bool IsHeightMapGenOnly;

	public bool IsUseCurrentBiom;

	public int provinceCount;

	public bool isGenerateOnStartFinished;

	public bool isReViewHistory;

	private DisplayModes displayMode;

	private HashSet<CellObject> activeCells;

	private float seafloor;

	public float sealevel;

	private bool m_IsFeatureDataDirty;

	public int randomSeed;

	public int randomInt;

	private bool displayAll;

	public Dictionary<Site, Section> sectionMetadata;

	private List<GameObject> coastObjects;

	private List<GameObject> riverObjects;

	private List<GameObject> boundaryObjects;

	private Dictionary<int, GameObject> cityObjests;

	private Dictionary<int, GameObject> burgLabels;

	private readonly HashSet<int> loggedMissingBurgIds;

	private List<GameObject> Armies;

	public List<GameObject> provinceObjects;

	public List<GameObject> provinceBiomHeightObjects;

	public List<Transform> mapCoordinateObjects;

	public List<GameObject> shallowSeaDarkLines;

	public List<GameObject> mapCoordinateLabels;

	public List<Vector2f> cellVerts;

	public List<List<Vector2f>> riverline;

	public HashSet<int> mannualRiver;

	public bool isDisplayBurgLabel;

	public bool IsShowSuggestionMessage;

	public double cellsX;

	public double cellsY;

	public double spacing;

	public int siteCount;

	private List<Vector2f> points;

	public float PrecInput;

	public float TemperatureModify;

	private List<int> SiteIndex;

	public List<BurgData> burgs;

	public List<BurgData> seaburgs;

	public List<Culture> cultures;

	public List<Province> provinces;

	public List<State> states;

	public List<List<int>> capitalRoutes;

	public List<List<int>> townRoutes;

	public List<List<int>> oceanRoutes;

	public List<List<int>> DebugLableRoutes;

	public List<GameObject> tradeObjects;

	public bool isRenderShallowSea;

	private static World instance;

	public bool isGamePaused;

	public bool isGameStarted;

	public bool isAllowAutoDiplomacy;

	public bool isAllowVassalAutoRebel;

	public bool isAllowRebel;

	public bool isAllowAlliance;

	public bool isEnableVassal;

	public bool isAllowCivilWar;

	public bool isAllowFamilyRebellion;

	public Voronoi SectionDiagram;

	public GameObject battleSwordPrefab;

	public GameObject eventSystem;

	public bool isNeedInitJsEnv;

	public GameObject provincePrefab;

	private Material materialBiomHeightDefault;

	private Material defaultLandMaterial;

	private Material m_RuntimeBiomProvinceMaterial;

	private Material m_RuntimeDrawProvinceMaterial;

	private Material m_RuntimeShallowSeaMaterial;

	public List<int> provinceBurgCells;

	[ThreadStatic]
	private static KDQuery s_ThreadCellIndexQuery;

	[ThreadStatic]
	private static List<int> s_ThreadCellIndexResults;

	public List<GameObject> mapframes;

	private const string innerResourceDir = "Assets/Resources/StreamingAssets/";

	private List<Province> drawProvinces;

	private List<ProvinceObject> drawProvinceComponents;

	private List<GameObject> drawProvinceGameObjects;

	private bool m_AreDrawProvinceVisualsInitialized;

	private Material latinEnglishCityLabelFontMaterial;

	private static readonly JsonSerializerSettings s_WorldSerializeSettings;

	private static readonly JsonSerializerSettings s_WorldDeserializeSettings;

	private static readonly JsonSerializerOptions s_WorldFastDeserializeOptions;

	public Camera sdf;

	private JsEnv _jsEnv;

	private bool m_HasDisposed;

	public long statemanagerupdateTime;

	public long provincemanagerupdateTime;

	public long timemanagerupdateTime;

	public long armymanagerupdateTime;

	public long warmanagerupdateTime;

	public float zoomSpeed;

	public bool isWallPaperMode;

	public int DisplayIndex;

	public bool useJsMapGen;

	public bool useJsStateProvinceCultureBurgGen;

	public string template;

	public bool isNoiseHeightGenerator;

	public bool isClickToGen;

	public bool isMultiContinent;

	public int stateIDClickToGen;

	public bool isGenBlankConquerable;

	public bool isGenBlankUnConquerable;

	public ArrayBuffer elevationBuffer;

	public float NoiseFrequecy;

	public int Ocataves;

	public float lacunarity;

	public float gain;

	public float LandPercentage;

	public float EdgePower;

	public RenderTexture biomTexture;

	public float exponent;

	public float expandFactor;

	public Vector2f centerPoint;

	public float sizeFactor;

	public int ClickToGenCenterCell;

	private KDTree tree;

	public List<GameObject> MountainPrefabs;

	private const int ReliefBatchSize = 1200;

	private const int ReliefRandomCacheSize = 2048;

	private const int MountainReliefTraversalDepth = 2;

	private const int PlantReliefBaseTraversalDepth = 5;

	private const int PlantReliefExtraNeighborDepth = 2;

	private static readonly string[] s_MountainPrefabPaths;

	private static GameObject[] s_CachedMountainPrefabs;

	private static GameObject s_CachedDesertPrefab;

	private static bool s_IsReliefPrefabCacheReady;

	private readonly List<GameObject> m_MountainPool;

	private Coroutine drawReliefCoroutine;

	private readonly float[] m_RandomCache;

	private int m_RandomCacheIndex;

	private bool m_IsRandomCacheInitialized;

	private List<GameObject>[] m_MountainInstancesByCell;

	private List<GameObject>[] m_PlantInstancesByCell;

	private readonly Dictionary<GameObject, int> m_MountainInstanceCellMap;

	private readonly Dictionary<GameObject, int> m_PlantInstanceCellMap;

	private readonly Queue<CellTraversalNode> m_CellTraversalQueue;

	private readonly HashSet<int> m_CellTraversalVisited;

	private float moutainSpaceing;

	private float mountainScaling;

	public List<GameObject> plantsPrefabs;

	private readonly List<GameObject> m_PlantPool;

	private float plantSpaceing;

	private float pineSpacing;

	private float treeSpacing;

	private float plantScaling;

	private Coroutine generateObjectsCoroutine;

	private List<ProvinceObject> provinceObjectsComponents;

	private Dictionary<Vertex, List<Edge>> vertexEdges;

	public Transform MapCoordinateLinePrefab;

	private bool isDisplayArmy;

	public GameObject textPrefab;

	public Transform contentTransform;

	public ScrollRect scrollRect;

	private GameObject deepSeaGo;

	private GameObject shallowSeaGo;

	public Color deepParchmentColor;

	public Color shallowLineColor;

	public Color coastLineColor;

	public Color provinceBorderColor;

	public Color stateLineColor;

	public Color shallowColor;

	public Color seaRouteColor;

	public Color coastLineOffsetColor;

	public Color deepColor;

	private float _borderShadowWidth;

	public float deepSea;

	private float _stateMapTransparency;

	private bool _isEnableBaseMapDistortion;

	private readonly float burgLabelOffset;

	private readonly float cityCircleScale;

	private readonly float burgLabelScale;

	private float armyLabelScale;

	private float _burgCityLabelScale;

	private float _isEnableDarkBorder;

	private bool _isEnableMapCoordinate;

	public bool IsShowTime;

	public bool IsShowMajorMessage;

	public bool _isDisplayPopulation;

	public bool IsEnableRandomStyle;

	public bool _isEnableBiomeIcon;

	public bool isAutoHideBottomPanel;

	private bool _isEnableProvinceBorder;

	private bool _isDisplaySeaRoute;

	private bool _isEnableAttackArrow;

	public bool IsAutoAbandonIsolatedProvinces;

	public bool IsAssistAlliesOccupyLand;

	private float _attackArrowShowDistance;

	private float _UseGrayScale;

	private float _useHeightMapBackground;

	private bool isDisplayBurgName;

	private bool isDisplayBurgObject;

	private float iconDisplayDistance;

	private bool isDisplayStateFullName;

	public Material provinceBiomHeightMaterial;

	private List<GameObject> mapFrameGameObjects;

	public static World Instance => null;

	public Dictionary<Vertex, List<Edge>> VertexEdges => null;

	public bool IsDisplayArmy
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsDisplayArmyBySetting => false;

	public bool UseArmyIconSVG
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float BorderShadowWidth
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float StateMapTransparency
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool IsEnableBaseMapDistortion
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float ArmyLabelScale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float BurgLabelOffset => 0f;

	public float CityCircleScale => 0f;

	public float BurgLabelScale => 0f;

	public float BurgCityLabelScale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float IsEnableDarkBorder
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool IsEnableMapCoordinate
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsEnableBiomeIcon
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsDisplayPopulation
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsEnableProvinceBorder
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsDisplaySeaRoute
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsEnableAttackArrow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float AttackArrowShowDistance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float UseGrayScale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float UseHeightMapBackground
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool IsDisplayBurgName
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsDisplayBurgObject
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float IconDisplayDistance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool IsDisplayStateFullName
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void PostLoadSaveData()
	{
	}

	public MilitaryProfile GetMapDefaultMilitaryProfile()
	{
		return null;
	}

	public void SetMapDefaultMilitaryProfile(MilitaryProfile profile)
	{
	}

	public void ResetMapDefaultMilitaryProfile()
	{
	}

	public OfficialTitleProfile GetMapDefaultOfficialTitleProfile()
	{
		return null;
	}

	public OfficialTitleProfile GetOrCreateMapDefaultOfficialTitleProfile()
	{
		return null;
	}

	public void SetMapDefaultOfficialTitleProfile(OfficialTitleProfile profile)
	{
	}

	public void SetReviewHistoryMode(bool isReViewHistory)
	{
	}

	public void ShowHistoryWorld(int t)
	{
	}

	public void ShowCurrentWorld()
	{
	}

	private void Awake()
	{
	}

	public void SetMapCoordinate()
	{
	}

	private void UpdateQuadUV()
	{
	}

	public void InitMapFrame()
	{
	}

	private void InitMapFrame3()
	{
	}

	public void UpdateBurgName(int burgID, string Name)
	{
	}

	public bool IsDouyinMode()
	{
		return false;
	}

	public bool IsReligionEnable()
	{
		return false;
	}

	public string GetStreamingPath(string FilePath)
	{
		return null;
	}

	public void EnableDrawProvinces(bool isEnabled)
	{
	}

	private void ClearDrawProvince()
	{
	}

	public void InitDrawMesh(bool isHeightMap = true, bool buildVisualObjects = true)
	{
	}

	public void UpdateAllDrawProvince()
	{
	}

	public void EnsureDrawProvinceVisualsReady()
	{
	}

	public bool IsOnland(int cell)
	{
		return false;
	}

	public void SetResolution(int resolutionX, int resolutionY, float scale = 1f)
	{
	}

	private void Start()
	{
	}

	public void SetFullscreen()
	{
	}

	private bool IsHigherResolution(Resolution candidate, Resolution baseline)
	{
		return false;
	}

	public void UpdateBounds()
	{
	}

	public void StartMapGen()
	{
	}

	[IteratorStateMachine(typeof(_003CGenerateMapOnStart_003Ed__177))]
	private IEnumerator GenerateMapOnStart()
	{
		return null;
	}

	public void StartMapGenPostChooseLanguage()
	{
	}

	[IteratorStateMachine(typeof(_003CGenerateMapOnStartPostChooseLanguage_003Ed__179))]
	private IEnumerator GenerateMapOnStartPostChooseLanguage()
	{
		return null;
	}

	private static bool TryDeserializeWorldDataFast(string _json, out WorldSerializationData _data)
	{
		_data = null;
		return false;
	}

	public string Serialize()
	{
		return null;
	}

	public static WorldSerializationData ParseSerializationData(string json)
	{
		return null;
	}

	public void Deserialize(string json)
	{
	}

	public void DeserializeParsedData(WorldSerializationData data)
	{
	}

	public void InitBaseWorld(int polyCount, bool isUseCellDataPoints = false)
	{
	}

	private void EnsureHeightMapExternalInitialized()
	{
	}

	private void GenerateHeightMapFromJs()
	{
	}

	private void OnDestroy()
	{
	}

	public void Dispose()
	{
	}

	private void InitializePuerTS()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public bool IsGameNeedUpdate()
	{
		return false;
	}

	public void SetStateLineColor(Color color)
	{
	}

	public void SetCoastLineColor(Color color)
	{
	}

	public void SetProvinceBorderLineColor(Color color)
	{
	}

	private void UpdateManager()
	{
	}

	public void SetZoomSpeed(float speed)
	{
	}

	private void CameraUpdate()
	{
	}

	public void SetWallPaper(int index = 0)
	{
	}

	public void DisableWallpaper()
	{
	}

	[AsyncStateMachine(typeof(_003CSetWallPaperAsync_003Ed__218))]
	public Task SetWallPaperAsync(int index = 0)
	{
		return null;
	}

	public static List<int> ArrayBufferToListOfUInt8(ArrayBuffer arrayBuffer)
	{
		return null;
	}

	public void EnableAllProvinces(bool isEnable)
	{
	}

	public static ArrayBuffer ListToArrayBuffer(List<int> list)
	{
		return null;
	}

	public static List<float> ArrayBufferToListFloatOfUInt8(ArrayBuffer arrayBuffer)
	{
		return null;
	}

	public static List<int> ArrayBufferToListOfInt8(ArrayBuffer arrayBuffer)
	{
		return null;
	}

	public static List<float> ArrayBufferToListFloatOfInt8(ArrayBuffer arrayBuffer)
	{
		return null;
	}

	public static List<int> ArrayBufferToListOfInt16(ArrayBuffer arrayBuffer)
	{
		return null;
	}

	public static List<int> ArrayBufferToListOfUInt16(ArrayBuffer arrayBuffer)
	{
		return null;
	}

	public static List<float> ArrayBufferToListFloatOfUInt16(ArrayBuffer arrayBuffer)
	{
		return null;
	}

	public static List<int> ArrayBufferToListOfInt32(ArrayBuffer arrayBuffer)
	{
		return null;
	}

	public static List<float> ArrayBufferToListOfFloat32(ArrayBuffer arrayBuffer)
	{
		return null;
	}

	public static List<double> ArrayBufferToListOfFloat64(ArrayBuffer arrayBuffer)
	{
		return null;
	}

	private void SetSeaElvationToZero()
	{
	}

	private bool IsNeedRegenerateProvince()
	{
		return false;
	}

	public void GenerateMap(int stateCount = 20, bool isHeightMapAlready = false, bool isRegenerateProvince = true, bool isGenerateProvinceOnly = false, bool isReplaceCapitalOfProvince = false, bool isPostChooseLanguage = false)
	{
	}

	public void FinishGame()
	{
	}

	public void CloseUIPanel()
	{
	}

	public void GenerateHeightMap()
	{
	}

	public ArrayBuffer GenerateNoiseHeightmap(bool isPostChooseLanguage = false)
	{
		return null;
	}

	private void InitMapGenerationSettings(Vector2f centerPoint, bool useCurrentHeightMap)
	{
	}

	private void PrepareMapData(bool clearRiver, bool clearMap)
	{
	}

	private void GenerateBaseMap(bool saveOldBiomeData = false, List<int> oldBiomeData = null)
	{
	}

	public void ClickToGenerateMap(int centerCell)
	{
	}

	public void GenerateForBiomOnly(bool isRefreshRiverAndSeaRoute = true)
	{
	}

	public void ClickToExpandState(int centerCell, State stateToExpand, bool isUseCurrentHeightMap = false, bool preserveOldData = true)
	{
	}

	public void RegenerateSeaRoute(bool isGenerateRoute = true, bool isGenerateRiver = true)
	{
	}

	public void OnClickMapToGenerateMap(int centerCell)
	{
	}

	private void StartManager(bool isGenerateProvinceOnly = false)
	{
	}

	private void ClickToStartManager(bool _isRegenerateDistricts = true)
	{
	}

	private void ClearManager()
	{
	}

	private void CheckCellNeighbor()
	{
	}

	public void GenerateLandMesh()
	{
	}

	private void DrawTownRoutes()
	{
	}

	private void DrawSeaRoutes()
	{
	}

	private void EnsureSeaRouteRenderer()
	{
	}

	public void CreateStateLabel(State state)
	{
	}

	private void DrawBurgs()
	{
	}

	public void UpdateRiverLine(int riverID, List<Vector3> newPoints)
	{
	}

	public void AddRiver(List<Vector3> newPoints)
	{
	}

	private void LogMissingBurgWarning(int burgId)
	{
	}

	private bool TryGetBurgData(int burgId, out BurgData burg)
	{
		burg = null;
		return false;
	}

	private GameObject CreateCity(int index)
	{
		return null;
	}

	private Transform GetCityIconPrefab(ProvinceCityType _provinceCityType, Province _province)
	{
		return null;
	}

	private bool IsDistrictCenterProvince(Province _province)
	{
		return false;
	}

	private Transform GetProvinceCenterPrefab()
	{
		return null;
	}

	private GameObject CreateCityLabel(int index)
	{
		return null;
	}

	public void SetBurgLabelFontAndMaterial(TextMeshPro textMeshPro)
	{
	}

	public float GetCityScale(int index)
	{
		return 0f;
	}

	public void UpdateCityIcon(int index)
	{
	}

	public void UpdateCityIconVisibility(int index)
	{
	}

	public void EnableBurgIcon(int index, bool isEnabled)
	{
	}

	public void DrawRelief(bool useCoroutine = false)
	{
	}

	[IteratorStateMachine(typeof(_003CDrawReliefRoutine_003Ed__324))]
	private IEnumerator DrawReliefRoutine(bool allowYield)
	{
		return null;
	}

	private void EnsureReliefPrefabsCached()
	{
	}

	private void ReleaseActiveInstances(List<GameObject> activeList, List<GameObject> pool, List<GameObject>[] perCellLists, Dictionary<GameObject, int> instanceCellMap)
	{
	}

	private GameObject GetOrCreateInstance(List<GameObject> pool, GameObject prefab)
	{
		return null;
	}

	private void EnsureInstanceLookupArrays()
	{
	}

	private void AddInstanceToCell(GameObject instance, int cellIndex, List<GameObject>[] perCellLists, Dictionary<GameObject, int> instanceCellMap)
	{
	}

	private void RemoveInstanceFromCell(GameObject instance, List<GameObject>[] perCellLists, Dictionary<GameObject, int> instanceCellMap)
	{
	}

	private bool HasNearbyInstances(int originCell, Vector2 originPos, float spacing, List<GameObject>[] perCellLists)
	{
		return false;
	}

	private float GetCachedRandom()
	{
		return 0f;
	}

	private void RefillRandomCache()
	{
	}

	private void StopDrawReliefCoroutine()
	{
	}

	private void DestroyReliefPools()
	{
	}

	public void SetClickToGenMode(int stateID)
	{
	}

	private void RemarkFeatures()
	{
	}

	private void MarkupGridOcean()
	{
	}

	private bool IsFeatureDataValid()
	{
		return false;
	}

	public void EnsureFeatureDataReady()
	{
	}

	public void MarkFeatureDataDirty()
	{
	}

	private void Markup(int start, int increment, int limit)
	{
	}

	private string DefineOceanGroup(int number)
	{
		return null;
	}

	private string DefineIslandGroup(int cellIndex, int number)
	{
		return null;
	}

	private double rn(double v, int d = 0)
	{
		return 0.0;
	}

	private double minmax(double value, double min, double max)
	{
		return 0.0;
	}

	private float minmax(float value, float min, float max)
	{
		return 0f;
	}

	private double normalize(double value, double min, double max)
	{
		return 0.0;
	}

	private void RankCell()
	{
	}

	private void RankCellLegacy()
	{
	}

	private void RankCellParallel()
	{
	}

	public List<Vector2f> GeneratePoints()
	{
		return null;
	}

	public List<int> GenerateProvincePoints()
	{
		return null;
	}

	public void EnsureProvinceBurgCellsReady()
	{
	}

	public List<int> GenerateDrawMeshPoints()
	{
		return null;
	}

	private List<Vector2f> GenerateBoundaryPoints(int pWidth, int pHeight, float pSpacing)
	{
		return null;
	}

	public List<Vector2f> GetJitteredGrid(float width, float height, float spacing)
	{
		return null;
	}

	public List<Vector2f> GetJitteredGrid2(float width, float height, float spacing)
	{
		return null;
	}

	public List<Vector2f> GetGrid(float width, float height, float spacing)
	{
		return null;
	}

	private float Jitter(float doubleJittering)
	{
		return 0f;
	}

	private float JitterMultiThread(float doubleJittering, System.Random random)
	{
		return 0f;
	}

	private void GenerateSections(bool isUseCellDataPoints = false)
	{
	}

	private bool TryBuildCellMeshDataParallel(int siteTotal, Rectf bounds, float xScale, float yScale, float uvScale, float rectCenterX, float rectCenterY, float cellZ)
	{
		return false;
	}

	private void BuildCellMeshDataSequential(int siteTotal, Rectf bounds, float xScale, float yScale, float uvScale, float rectCenterX, float rectCenterY, float cellZ)
	{
	}

	[IteratorStateMachine(typeof(_003CGenerateObjectsCoroutine_003Ed__366))]
	private IEnumerator GenerateObjectsCoroutine()
	{
		return null;
	}

	private void GenerateProvinceObject(bool updateDrawProvinceVisuals = true)
	{
	}

	private void DrawRiver()
	{
	}

	public void Render(bool displayAll = false)
	{
	}

	public void RenderElevation(bool displayAll = false)
	{
	}

	public void RenderBiom(bool displayAll = false)
	{
	}

	private void DisableRenderProvince()
	{
	}

	public void DisableCellRender()
	{
	}

	public void RenderStateByProvince(bool displayAll = false)
	{
	}

	public void GenerateProvinceMesh(int provinceID, ProvinceObject provinceObject)
	{
	}

	public void GenerateDrawProvinceMesh(int drawProvinceID, ProvinceObject drawProvinceobject, bool isHeightMap = true)
	{
	}

	public void RenderBiomByProvince(bool displayAll = false)
	{
	}

	public void RenderDrawProvince()
	{
	}

	public void RenderSea()
	{
	}

	public void DrawMapCoordinate()
	{
	}

	private GameObject CreateMapCoordinateLabel(string text, Vector2f position, float depth, float offset, bool isStart, bool isLatitude)
	{
		return null;
	}

	private void RenderStateCoreProvince(bool displayAll = false)
	{
	}

	public void RedrawProvince(Province province)
	{
	}

	public void UpdateDrawProvince(int id, bool isHeightmap = true)
	{
	}

	public void UpdateLandProvince(int id)
	{
	}

	private void RenderProvince(bool displayAll = false)
	{
	}

	private void RenderCulture(bool displayAll = false)
	{
	}

	public void ClearScreen()
	{
	}

	private void ClearLines(List<GameObject> lineObjects)
	{
	}

	private void ClearCity()
	{
	}

	public void ClearMap(bool isReinitCellData = true)
	{
	}

	private void ClickToGenClearMap()
	{
	}

	public void SetCellAsSea(int cellindex)
	{
	}

	public Vector3 VoronoiTransformPoint(Vector2f point, float defaultZ = 0f)
	{
		return default;
	}

	public Vector2f InverseVoronoiTransformPoint(Vector3 point)
	{
		return default;
	}

	private List<Vector3> GetMeshVertices(CellObject cellObject, List<Vector2f> vertices)
	{
		return null;
	}

	private List<Vector3> GetMeshVerticesPure(List<Vector2f> vertices)
	{
		return null;
	}

	private (List<Vector3>, List<Vector2>, List<Color>) GetProvinceCellMeshVertices(int provinceID, int cell)
	{
		return default;
	}

	private (List<Vector3>, List<Vector2>, List<Color>) GetDrawProvinceMeshVertices(int provinceID, int cell, bool isHeightMap = true)
	{
		return default;
	}

	private List<int> Triangulate(List<Vector3> meshVertices)
	{
		return null;
	}

	private List<int> Triangulate(int numVertices)
	{
		return null;
	}

	private void UpdateMeshes(CellObject cellObject, List<Vector3> meshVertices, List<int> meshTriangles)
	{
	}

	public bool GetIconVisibility()
	{
		return false;
	}

	private bool DidIconVisibilityChange(float previousSize, float currentSize)
	{
		return false;
	}

	private bool DidAttackArrowZoomVisibilityChange(float previousSize, float currentSize)
	{
		return false;
	}

	private void RefreshBattleArrowVisibility()
	{
	}

	private void UpdateMainCamera(float previousSize)
	{
	}

	private bool IsPointerOverScrollRect()
	{
		return false;
	}

	public MapCoordinates CalculateMapCoordinates()
	{
		return null;
	}

	public int GetCellIndex(float x, float y)
	{
		return 0;
	}

	public List<int> GetCellIndexInRadius(float x, float y, float r)
	{
		return null;
	}

	public Vector2f GetSharedEdgeMid(int cellIndex, int neighborIndex)
	{
		return default;
	}

	public List<int> GetNeighborCells(int cellIndex)
	{
		return null;
	}

	public Site GetSite(int cellIndex)
	{
		return null;
	}

	public void Generate(bool isPostChooseLanguage = false)
	{
	}

	public void SetSeaRouteColor(Color color)
	{
	}

	public void UpdateBaseMapDistortion()
	{
	}

	public void UpdateCityLabelScale()
	{
	}

	public void UpdateBurgLabelDisplay(bool isDisplayBurgLabel)
	{
	}

	public void EnableBiomeIcon(bool isEnabled)
	{
	}

	private void UpdateSeaRouteRendererVisibility()
	{
	}

	private void UpdateMapFrameColor()
	{
	}

	public void CheckIconVisibility()
	{
	}

	private void UpdateStateMapTransparency()
	{
	}

	[IteratorStateMachine(typeof(_003CScrollToBottom_003Ed__547))]
	private IEnumerator ScrollToBottom()
	{
		return null;
	}

	internal void SetShallowWaterColor(Color color)
	{
	}

	internal void SetDeepWaterColor(Color color)
	{
	}

	internal void SetShallowSeaWidth(float value)
	{
	}

	public void OpenHeightmapDialog()
	{
	}

	private void HandleHeightmapSelected(bool selected, string filePath, string[] files)
	{
	}

	public void LoadHeightmapFromPNG(byte[] imageData)
	{
	}

	public void GenHeightMapFromImage(byte[] imageData)
	{
	}

	internal int GetNextRiverID()
	{
		return 0;
	}

	private Material GetOrCreateBiomProvinceMaterial()
	{
		return null;
	}

	private Material GetOrCreateDrawProvinceMaterial()
	{
		return null;
	}

	private Material GetOrCreateShallowSeaMaterial()
	{
		return null;
	}

	private void CleanupRuntimeGeneratedMaterials(bool includeDrawProvinceMaterial = false)
	{
	}

	public void SetDrawProvinceMode(int mode)
	{
	}
}
