using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MPUIKIT;
using UnityEngine;

public class HistoryTimelineUI : BasePanelUI
{
	private enum TimelineOpenSource
	{
		Unknown = 0,
		HistoryInfoPanel = 1,
		StateInfoUI = 2,
		Other = 3
	}

	[CompilerGenerated]
	private sealed class _003CUpdateVisibility_003Ed__96 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HistoryTimelineUI _003C_003E4__this;

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
		public _003CUpdateVisibility_003Ed__96(int _003C_003E1__state)
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
	private sealed class _003CRefreshToggleLocalizationAfterFrames_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HistoryTimelineUI _003C_003E4__this;

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
		public _003CRefreshToggleLocalizationAfterFrames_003Ed__116(int _003C_003E1__state)
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

	private static HistoryTimelineUI s_Instance;

	[SerializeField]
	[Header("UI References")]
	private RectTransform m_TimelineContainer;

	[SerializeField]
	private RectTransform m_ViewportMask;

	[SerializeField]
	private Transform m_NodesContainer;

	[SerializeField]
	private Transform m_LinesContainer;

	[SerializeField]
	private Transform m_TimeAxisContainer;

	[SerializeField]
	private Transform m_FilterPanel;

	[SerializeField]
	private GameObject m_FilterTogglePrefab;

	[SerializeField]
	private Transform m_FilterToggleContainer;

	[Header("Timeline Settings")]
	[SerializeField]
	private float m_TimelineHeight;

	[SerializeField]
	private float m_TimelinePadding;

	[SerializeField]
	private float m_NodeSize;

	[SerializeField]
	private float m_NodeSpacingY;

	[SerializeField]
	private float m_PanelToLineGap;

	[SerializeField]
	private float m_MinNodeSpacingX;

	[SerializeField]
	private float m_PanelWidth;

	[SerializeField]
	private float m_PanelMaxHeight;

	[Header("Colors")]
	[SerializeField]
	private Color m_TimelineColor;

	[SerializeField]
	private Color m_ConnectorLineColor;

	[SerializeField]
	private Color m_DefaultNodeColor;

	[SerializeField]
	[Header("Interaction Settings")]
	private float m_MinZoom;

	[SerializeField]
	private float m_MaxZoom;

	[SerializeField]
	private float m_ZoomSpeed;

	[SerializeField]
	private float m_DragSensitivity;

	[SerializeField]
	private float m_DefaultZoom;

	[Header("Performance Settings")]
	[SerializeField]
	private int m_NodePoolSize;

	[SerializeField]
	private int m_MPImagePoolSize;

	[SerializeField]
	private float m_UpdateInterval;

	private Dictionary<HistoryEventType, Color> m_EventTypeColors;

	private HistoryTimelineLayoutManager m_LayoutManager;

	private List<HistoryTimelineNode> m_ActiveNodes;

	private List<MPImage> m_ActiveLines;

	private List<HistoryEvent> m_CurrentEvents;

	private Queue<GameObject> m_NodePool;

	private Queue<MPImage> m_MPImagePool;

	private float m_CurrentZoom;

	private Vector2 m_TimelinePosition;

	private bool m_IsDragging;

	private Vector2 m_LastMousePosition;

	private MPImage m_MainTimeline;

	private MPImage m_TimelineArrow;

	private List<MPImage> m_TimeMarkers;

	private int m_FilterStateId;

	private int m_FilterFamilyId;

	private TimelineOpenSource m_OpenSource;

	private bool m_IsHistoryInfoPanelHiddenByThis;

	private HashSet<HistoryEventType> m_WorldFilterEventTypes;

	private HashSet<HistoryEventType> m_StateFilterEventTypes;

	private bool m_HasAppliedFilterConfig;

	private Dictionary<HistoryEventType, LocalizationToggleButton> m_EventTypeToggles;

	private Coroutine m_UpdateCoroutine;

	public static HistoryTimelineUI Instance => null;

	public int FilterStateId => 0;

	protected override void Awake()
	{
	}

	protected override void OnPanelInitialize()
	{
	}

	private void InitializePanel()
	{
	}

	private void InitializeFilterPanel()
	{
	}

	private void CreateEventTypeToggles()
	{
	}

	private void CreateEventTypeToggle(HistoryEventType eventType)
	{
	}

	private void OnEventTypeToggleChanged(HistoryEventType eventType)
	{
	}

	private void RefreshTimelineWithFilter()
	{
	}

	private List<HistoryEvent> GetFilteredEvents()
	{
		return null;
	}

	private void InitializeObjectPools()
	{
	}

	private GameObject CreateTimelineNode()
	{
		return null;
	}

	private MPImage CreateMPImage()
	{
		return null;
	}

	public void DisplayWorldHistory()
	{
	}

	public void DisplayWorldHistoryFromHistoryInfoPanel()
	{
	}

	public void ShowWorldHistoryTimeline()
	{
	}

	public void ShowWorldHistoryTimelineFromHistoryInfoPanel()
	{
	}

	public void Display(int stateId, int leaderId = 0)
	{
	}

	public void DisplayStateHistory(int stateId)
	{
	}

	public void DisplayFamilyHistory(int familyId)
	{
	}

	private List<HistoryEvent> GetAllHistoryEvents()
	{
		return null;
	}

	private void BuildTimeline(List<HistoryEvent> events)
	{
	}

	private float GetTimelineWidth()
	{
		return 0f;
	}

	private void DrawMainTimeline()
	{
	}

	private void DrawTimelineArrow(float timelineLength)
	{
	}

	private void DrawTimeMarkers()
	{
	}

	private void CreateEventNodes()
	{
	}

	private Color GetDominantEventColor(List<HistoryEvent> events)
	{
		return default;
	}

	private Color GetEventColor(HistoryEventType eventType)
	{
		return default;
	}

	private void ClearTimeline()
	{
	}

	private GameObject GetNodeFromPool()
	{
		return null;
	}

	private MPImage GetMPImageFromPool()
	{
		return null;
	}

	private void ReturnNodeToPool(GameObject node)
	{
	}

	private void ReturnMPImageToPool(MPImage mpImage)
	{
	}

	protected override void Update()
	{
	}

	private void HandleInput()
	{
	}

	private void HandleMouseScroll()
	{
	}

	private void HandleDragging()
	{
	}

	private bool IsMouseOverScrollView()
	{
		return false;
	}

	private void SetZoom(float zoom)
	{
	}

	private void OnResetView()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateVisibility_003Ed__96))]
	private IEnumerator UpdateVisibility()
	{
		return null;
	}

	private Rect GetViewportRect()
	{
		return default;
	}

	private bool IsNodeInViewport(HistoryTimelineNode node, Rect viewportRect)
	{
		return false;
	}

	private bool TryGetNodeScreenXBounds(HistoryTimelineNode node, out float minX, out float maxX)
	{
		minX = default;
		maxX = default;
		return false;
	}

	public void OnNodeClicked(HistoryTimelineNode node)
	{
	}

	private string GetEventDescription(HistoryEvent historyEvent)
	{
		return null;
	}

	protected override void OnPanelShow()
	{
	}

	protected override void OnPanelHide()
	{
	}

	public override void Hide(Action _onComplete = null)
	{
	}

	private void PrepareOpenFromHistoryInfoPanel()
	{
	}

	private void RestoreHistoryInfoPanel()
	{
	}

	private void InitializeDefaultFilterEventTypes()
	{
	}

	private void EnsureFilterSetsInitialized()
	{
	}

	private HashSet<HistoryEventType> LoadFilterSetFromConfig(List<string> configValue, HashSet<HistoryEventType> alwaysExcludedTypes)
	{
		return null;
	}

	private HashSet<HistoryEventType> CreateDefaultFilterSet(HashSet<HistoryEventType> alwaysExcludedTypes)
	{
		return null;
	}

	private HashSet<HistoryEventType> GetActiveFilterEventTypes()
	{
		return null;
	}

	private void RefreshEventTypeToggleStates()
	{
	}

	private void PersistActiveFilterToConfig()
	{
	}

	private List<string> SerializeFilterSet(HashSet<HistoryEventType> filterSet)
	{
		return null;
	}

	protected override void RefreshLocalization()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshToggleLocalizationAfterFrames_003Ed__116))]
	private IEnumerator RefreshToggleLocalizationAfterFrames()
	{
		return null;
	}
}
