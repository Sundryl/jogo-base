using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FantasyWorld.CharacterSystem;
using Shapes;
using UnityEngine;

[ExecuteAlways]
public class StateLineRenderer : ImmediateModeShapeDrawer
{
	[CompilerGenerated]
	private sealed class _003CUpdateSDFTexture_003Ed__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool isforceUpdate;

		public StateLineRenderer _003C_003E4__this;

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
		public _003CUpdateSDFTexture_003Ed__106(int _003C_003E1__state)
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
	private sealed class _003CCreateRiverArrowsCoroutine_003Ed__160 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StateLineRenderer _003C_003E4__this;

		private int _003Ccount_003E5__2;

		private Dictionary<int, PolylinePath>.Enumerator _003C_003E7__wrap2;

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
		public _003CCreateRiverArrowsCoroutine_003Ed__160(int _003C_003E1__state)
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

	private static StateLineRenderer instance;

	private Dictionary<int, List<PolylinePath>> stateLines;

	private List<PolylinePath> coastLinesOffset;

	private List<PolylinePath> tradeLine;

	private Dictionary<int, PolylinePath> riverLine;

	private List<GameObject> tradeLineObjects;

	private Dictionary<int, List<GameObject>> statelineObjects;

	private Dictionary<int, List<GameObject>> statelineSDFObjects;

	private List<GameObject> coastlineObjects;

	private List<GameObject> shallowLineObjects;

	private List<GameObject> coastlineOffsetObjects;

	private Dictionary<string, List<GameObject>> religionBorderObjects;

	public float religionBorderThickness;

	private Dictionary<string, List<GameObject>> cultureBorderObjects;

	private Dictionary<int, List<GameObject>> districtBorderObjects;

	private Dictionary<int, List<GameObject>> familyBorderObjects;

	private Dictionary<int, List<GameObject>> allianceBorderObjects;

	private List<GameObject> sdfCoastlineObjects;

	private Dictionary<int, Color> selectedStateLines;

	private Dictionary<int, Color> selectedAllianceLines;

	private HashSet<string> selectedReligionBorders;

	public Camera SDFCamera;

	private Dictionary<int, GameObject> riverLineObjects;

	private List<GameObject> riverArrowObjects;

	public Dictionary<int, PolylinePath> stateLinedebug;

	public Dictionary<long, Dictionary<int, List<List<Vector3>>>> histroyStateLines;

	public Dictionary<int, List<List<Vector3>>> currentStatelines;

	private Dictionary<int, List<List<Vector3>>> m_StateLineSamples;

	private const float c_DuplicatePointThreshold = 0.0001f;

	private const int c_StateLineCurveSegments = 4;

	private const int c_MaxCoastlinePointsPerSegment = 2000;

	private const int c_CoastlinePointsPerFrame = 10000;

	private readonly List<List<Vector3>> pendingCoastLines;

	private readonly List<bool> pendingCoastLineDirections;

	private int pendingCoastLineIndex;

	private int pendingCoastLineVersion;

	private int processingCoastLineVersion;

	private int coastLineLastCompletedVersion;

	private int pendingCoastLineTotalSegments;

	private int pendingCoastLineTotalPoints;

	private int pendingCoastLineOriginalCount;

	private int pendingCoastLineOriginalPoints;

	public Dictionary<int, List<GameObject>> provinceBorderObjects;

	public float provinceBorderThickness;

	public List<Vector3> pathfindDebugPoint;

	private static readonly Vector3 c_RiverControlPointOffset;

	private const float c_SelectedControlPointRadiusMultiplier = 1.6f;

	private const float c_MinSelectionRectSize = 5f;

	private const float c_SelectedControlPointThicknessFactor = 0.25f;

	private readonly HashSet<DragPoint> m_SelectedControlPoints;

	private readonly Dictionary<DragPoint, GameObject> m_ControlPointSelectionIndicators;

	private bool m_IsSelectingControlPoints;

	private bool m_SelectionAppendMode;

	private Vector2 m_SelectionStartScreenPosition;

	private Vector2 m_SelectionCurrentScreenPosition;

	private Rect m_CurrentSelectionRect;

	private int m_ControlPointMouseDownFrame;

	private static Texture2D s_SelectionTexture;

	private DragPoint m_PendingSingleSelectPoint;

	public float curveAmount;

	public int interpolationPoints;

	private List<PolylinePath> shallowLines;

	public float stateLineThickness;

	private float sdfLineThickness;

	public float coastLineThickness;

	private float coastLineSDFThickness;

	public float shallowLineThickness;

	public GameObject stateLinePrefab;

	public GameObject coastLinePrefab;

	private LayerMask layerMaskStateLine;

	private LayerMask layerMaskCoastLine;

	private Coroutine createRiverArrowsCoroutine;

	private Dictionary<string, Queue<GameObject>> m_LineObjectPools;

	private Queue<GameObject> m_StateBorderPool;

	private Queue<GameObject> m_FamilyBorderPool;

	private Dictionary<int, Color?> selectedFamilyLines;

	private Dictionary<int, Color?> selectedDistrictLines;

	private Queue<GameObject> m_AllianceBorderPool;

	public bool isUpdateLineMeshFinished;

	private float lastStatusLogTime;

	private int framesSinceLastUpdate;

	private List<Polyline> polylinesNeedUpdate;

	private readonly object polylinesLock;

	public bool isUpdateLineDataFinished;

	private bool isUpdateLineDataTaskCompleted;

	private float updateTaskStartTime;

	private const float UPDATE_TASK_TIMEOUT = 10f;

	private int updateCallCount;

	private double provinceBorderUpdateTimeStamp;

	private Dictionary<int, List<GameObject>> riverControlPoints;

	private HashSet<int> editingRivers;

	public static StateLineRenderer Instance => null;

	private void Awake()
	{
	}

	private static List<List<Vector3>> CloneVector3Lines(List<List<Vector3>> lines)
	{
		return null;
	}

	private static Dictionary<int, List<List<Vector3>>> CloneVector3Data(Dictionary<int, List<List<Vector3>>> source)
	{
		return null;
	}

	private static List<Vector3> BuildMinimalArrowPoints(IReadOnlyList<Vector3> sourcePoints)
	{
		return null;
	}

	private static Dictionary<int, List<List<Vector3>>> BuildRenderableStateLines(Dictionary<int, List<List<Vector3>>> samples)
	{
		return null;
	}

	private static List<Vector3> BuildRenderableLine(IReadOnlyList<Vector3> samplePoints)
	{
		return null;
	}

	private static List<Vector3> RemoveDuplicatePoints(IReadOnlyList<Vector3> points, float threshold)
	{
		return null;
	}

	private static List<List<Vector3>> SplitCoastlineIntoSegments(IReadOnlyList<Vector3> sourcePoints, int maxPointsPerSegment)
	{
		return null;
	}

	private Dictionary<int, List<List<Vector3>>> BuildCapturedSampleData()
	{
		return null;
	}

	private GameObject GetStateBorderFromPool(GameObject prefab)
	{
		return null;
	}

	private void ReturnStateBorderToPool(GameObject lineObj)
	{
	}

	private GameObject GetFamilyBorderFromPool(GameObject prefab)
	{
		return null;
	}

	private void ReturnFamilyBorderToPool(GameObject lineObj)
	{
	}

	private GameObject GetAllianceBorderFromPool(GameObject prefab)
	{
		return null;
	}

	private void ReturnAllianceBorderToPool(GameObject lineObj)
	{
	}

	private GameObject GetLineObjectFromPool(string poolType, GameObject prefab)
	{
		return null;
	}

	private void ReturnLineObjectToPool(GameObject lineObj, string poolType)
	{
	}

	public void ClearLineObjectPool()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void UpdateLineMesh()
	{
	}

	private void ProcessPendingCoastLines()
	{
	}

	public void UpdateSDF(bool isforceUpdate = false)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateSDFTexture_003Ed__106))]
	private IEnumerator UpdateSDFTexture(bool isforceUpdate = false)
	{
		return null;
	}

	public void SetStateLines(Dictionary<int, List<List<Vector3>>> lines, bool clear = false, Dictionary<int, List<List<Vector3>>> samplePoints = null)
	{
	}

	public void UpdateStateLineMesh(bool clear = false)
	{
	}

	private void SetBorderHighlight(List<GameObject> borderObjects, bool isSelected, float baseThickness, Color highlightColor, float defaultZPos = -0.2f, float selectedZPos = -0.3f)
	{
	}

	public void SetStateLineSelected(int stateID, bool selected, Color? color = null)
	{
	}

	public void ClearStateLineSelected()
	{
	}

	public void SetAllianceLineSelected(int allianceId, bool selected, Color? color = null)
	{
	}

	private Color GetAllianceDefaultColor(int allianceId)
	{
		return default;
	}

	public void SetReligionBorderSelected(string religionId, bool selected, Color? color = null)
	{
	}

	public void ClearReligionBorderSelected()
	{
	}

	public void ClearAllBorderSelections()
	{
	}

	private void UpdateLineDataThreadSafe(List<Polyline> polylines)
	{
	}

	private void UpdateLineData(object state)
	{
	}

	public void RemoveStateLine(int stateID)
	{
	}

	public void RemoveFamilyBorder(int familyId)
	{
	}

	public void RemoveAllianceBorder(int allianceId)
	{
	}

	public void SetFamilyLineSelected(int familyId, bool isSelected, Color? highlightColor = null)
	{
	}

	public void ClearFamilyLineSelected()
	{
	}

	private void ForceUpdateStateLineMesh()
	{
	}

	public void SetStateLineColor(Color color)
	{
	}

	public void SetStateLineThickness(float thickness)
	{
	}

	public void SetSDFLineThickness(float thickness)
	{
	}

	public void SetCoastLineThickness(float thickness)
	{
	}

	public void SetCoastLineColor(Color color)
	{
	}

	public void SetShallowLineColor(Color color)
	{
	}

	public void SetCoastLineSDFColor(Color color)
	{
	}

	public void SetCoastLineSDFThickness(float thickness)
	{
	}

	public void SetRiverLineColor(Color color)
	{
	}

	public void SetProvinceBorderLines(Dictionary<int, List<List<Vector3>>> provinceBorders, bool isForceUpdate = false, double updateTimeStamp = 0.0)
	{
	}

	private void UpdateBorderLine(GameObject lineObj, List<Vector3> points, int provinceId)
	{
	}

	private bool ShouldActivateBorder(int provinceId)
	{
		return false;
	}

	public void SetCoastLines(List<List<Vector3>> lines, List<bool> linesDirection)
	{
	}

	public void SetCoastLineOffset(List<List<Vector3>> lines)
	{
	}

	public void SetShallowLines(List<List<Vector3>> lines)
	{
	}

	public void EnableProvinceBorderLine(int id, bool isEnabled)
	{
	}

	public void EnableAllProvinceBorderLine(bool isEnabled)
	{
	}

	public void CheckIfProvinceBorderLineShouldBeEnabled()
	{
	}

	public void stateLinedebugAdd(int id, List<Vector3> line)
	{
	}

	public void EnableTradeLine(bool enable)
	{
	}

	public void SetTradeLines(List<List<Vector3>> lines)
	{
	}

	public void SetRiverLines(List<List<Vector3>> lines)
	{
	}

	private PolylinePath BuildRiverPath(IReadOnlyList<Vector3> points)
	{
		return null;
	}

	private PolylinePath DrawSingleRiver(List<Vector3> points, int riverIndex)
	{
		return null;
	}

	private int CalculateInterpolationPoints(float segmentLength)
	{
		return 0;
	}

	private GameObject CreateRiverArrow(PolylinePath riverPath, int riverID, bool isEnableAnimation = false)
	{
		return null;
	}

	public void EnableRiverDrawMode(bool isEnabled)
	{
	}

	[IteratorStateMachine(typeof(_003CCreateRiverArrowsCoroutine_003Ed__160))]
	private IEnumerator CreateRiverArrowsCoroutine()
	{
		return null;
	}

	private void OnGUI()
	{
	}

	public void ClearAllLines()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public void CaptureHistoryState(long t)
	{
	}

	public void ClearHistoryStateData()
	{
	}

	public void CaputureCurrentStateLines()
	{
	}

	internal void SetHistoryStateLines(long t)
	{
	}

	internal void SetCurrentStateLines()
	{
	}

	internal void EnableProvinceBorder(bool isEnabled)
	{
	}

	internal void SetProvinceBorderColor(Color color)
	{
	}

	public void SetProvinceBorderColorSelected(int provinceID, Color color)
	{
	}

	public void EditRiverLine(int riverID)
	{
	}

	private void EnterRiverEditMode(int riverID)
	{
	}

	private void ExitRiverEditMode(int riverID)
	{
	}

	private void UpdateRiverPoint(int riverID, int pointIndex, Vector3 newPosition)
	{
	}

	private void ApplyDeltaToSelectedPoints(int riverID, int sourcePointIndex, Vector3 delta, List<Vector3> riverPoints)
	{
	}

	private void PruneSelectedControlPoints()
	{
	}

	internal void HandleControlPointMouseDown(DragPoint dragPoint)
	{
	}

	internal void HandleControlPointMouseUp(DragPoint dragPoint, bool hasMoved)
	{
	}

	private void AddControlPointToSelection(DragPoint dragPoint)
	{
	}

	private void RemoveControlPointFromSelection(DragPoint dragPoint)
	{
	}

	private void ClearSelectedRiverControlPoints()
	{
	}

	private GameObject CreateSelectionIndicator(DragPoint dragPoint)
	{
		return null;
	}

	private static Texture2D GetSelectionTexture()
	{
		return null;
	}

	private static void DrawScreenRect(Rect rect, Color color)
	{
	}

	private static void DrawScreenRectBorder(Rect rect, float thickness, Color color)
	{
	}

	private static Rect BuildSelectionRect(Vector2 start, Vector2 end)
	{
		return default;
	}

	private static Rect ConvertToGUIRect(Rect rect)
	{
		return default;
	}

	private void SelectControlPointsWithinRect(Rect selectionRect, bool append)
	{
	}

	private void SelectControlPointByPosition(Vector2 screenPosition, bool append)
	{
	}

	private void ApplySelectionRect(Rect selectionRect, bool append)
	{
	}

	private void HandleRiverControlPointSelectionInput()
	{
	}

	private bool TryDeleteSelectedRiverPoints()
	{
		return false;
	}

	private void UpdateRiverArrow(int riverID, PolylinePath riverPath = null)
	{
	}

	private void DeleteRiver(int riverID)
	{
	}

	private void AddControlPoint(int riverID)
	{
	}

	private Vector3 GetNearestPointOnLine(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
	{
		return default;
	}

	public void CreateNewRiver(Vector3 clickPosition)
	{
	}

	public void SetStateLineVisibility(bool isVisible)
	{
	}

	public void SetReligionLines(Dictionary<string, List<List<Vector3>>> lines, bool clear = false)
	{
	}

	private void UpdateReligionBorderLine(GameObject lineObj, List<Vector3> points, Religion religion)
	{
	}

	public void SetReligionBorderThickness(float thickness)
	{
	}

	public void EnableReligionBorderLines(bool isEnabled)
	{
	}

	public void SetCultureLines(Dictionary<string, List<List<Vector3>>> cultureLines, bool clear = false)
	{
	}

	private void UpdateCultureBorderLine(GameObject lineObj, List<Vector3> points, MapCulture mapCulture)
	{
	}

	public void EnableCultureBorderLines(bool isEnabled)
	{
	}

	public void SetDistrictLines(Dictionary<int, List<List<Vector3>>> lines, bool clear = false)
	{
	}

	private void UpdateDistrictBorderLine(GameObject lineObj, List<Vector3> points, District district)
	{
	}

	private static Color ResolveDistrictBorderColor(District district)
	{
		return default;
	}

	public void EnableDistrictBorderLines(bool isEnabled)
	{
	}

	public void RefreshDistrictBorderColor(int districtId)
	{
	}

	public void SetDistrictLineSelected(int districtId, bool isSelected, Color? highlightColor = null)
	{
	}

	public void ClearDistrictLineSelected()
	{
	}

	private void RemoveBorderLineGeneric<T>(Dictionary<T, List<GameObject>> _borderObjects, T _id, string _poolTag)
	{
	}

	public void SetFamilyLines(Dictionary<int, List<List<Vector3>>> lines, bool clear = false)
	{
	}

	public void SetAllianceLines(Dictionary<int, List<List<Vector3>>> lines, bool clear = false)
	{
	}

	private void UpdateFamilyBorderLine(GameObject lineObj, List<Vector3> points, Family family)
	{
	}

	private bool ShouldShowFamilyOverlay(Family family)
	{
		return false;
	}

	public void EnableFamilyBorderLines(bool isEnabled)
	{
	}

	private void UpdateAllianceBorderLine(GameObject lineObj, List<Vector3> points, Alliance alliance)
	{
	}

	public void EnableAllianceBorderLines(bool isEnabled)
	{
	}

	public void ApplyAllianceStateBorderVisibility()
	{
	}

	public void ApplyFamilyOverlayFilter()
	{
	}

	public void RemoveCultureLine(string _cultureNameID)
	{
	}

	public void RemoveDistrictLine(int _districtId)
	{
	}

	public void RemoveReligionLine(string _religionId)
	{
	}
}
