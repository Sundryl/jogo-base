using MPUIKIT;
using UnityEngine;
using UnityEngine.EventSystems;

public class HistoryTimelineNode : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	private TimelineNodeData m_NodeData;

	private HistoryTimelineUI m_TimelineUI;

	private RectTransform m_RectTransform;

	private GameObject m_EventPanelObj;

	private SinglePanel m_EventPanel;

	private GameObject m_CircleNodeObj;

	private MPImage m_CircleNode;

	private MPImage m_ConnectorLine;

	private float m_PanelWidth;

	private float m_NodeSize;

	private Color m_NodeColor;

	private float m_PanelToLineGap;

	public TimelineNodeData NodeData => null;

	public RectTransform RectTransform => null;

	public MPImage ConnectorLine => null;

	public SinglePanel EventPanel => null;

	private void Awake()
	{
	}

	public void Initialize(TimelineNodeData nodeData, HistoryTimelineUI timelineUI, Color nodeColor, float panelWidth, float nodeSize, float panelToLineGap = 15f)
	{
	}

	private void CleanupOldComponents()
	{
	}

	private void CreateCircleNode()
	{
	}

	private void CreateEventPanel()
	{
	}

	private string GetEventDescription()
	{
		return null;
	}

	private Color GetPanelColor()
	{
		return default;
	}

	public void SetConnectorLine(MPImage connectorLine)
	{
	}

	private void UpdateConnectorLine()
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	private void OnCircleClicked()
	{
	}

	private void OnPanelClicked()
	{
	}

	private void OnEnable()
	{
	}

	public void UpdateDisplay()
	{
	}

	public void RefreshDisplay()
	{
	}
}
