using Shapes;
using UnityEngine;

public sealed class CustomLabelDragHandleGizmo : MonoBehaviour
{
	private const float c_MinSize = 0.6f;

	private const float c_HitAreaDepth = 0.24f;

	private const int c_HandleRenderQueue = 4100;

	private static readonly Color c_XAxisColor;

	private static readonly Color c_YAxisColor;

	private static readonly Color c_CenterCoreColor;

	private static readonly Color c_CenterRingColor;

	[SerializeField]
	private float m_Size;

	[SerializeField]
	private Vector2 m_OffsetMultiplier;

	private CustomLabelDragHandler m_Owner;

	private GameObject m_VisualInstance;

	private Line m_XAxisLine;

	private Line m_YAxisLine;

	private Triangle m_XAxisArrow;

	private Triangle m_YAxisArrow;

	private Disc m_CenterRing;

	private Disc m_CenterCore;

	private CustomLabelDragHandleHitArea m_CenterHitArea;

	private CustomLabelDragHandleHitArea m_XAxisHitArea;

	private CustomLabelDragHandleHitArea m_YAxisHitArea;

	private Vector3 m_BaseAnchor;

	private bool m_HasAnchor;

	public void Initialize(CustomLabelDragHandler owner)
	{
	}

	public void SetAnchor(Vector3 worldPosition)
	{
	}

	public void SetSize(float size)
	{
	}

	public void SetVisible(bool visible)
	{
	}

	private void EnsureVisualInstance()
	{
	}

	private void EnsureHitAreas()
	{
	}

	private void UpdateVisualScale()
	{
	}

	private Vector3 ApplyOffset(Vector3 worldPosition)
	{
		return default;
	}

	private void LateUpdate()
	{
	}

	private Line CreateAxisLine(string name, Color axisColor)
	{
		return null;
	}

	private Triangle CreateArrowHead(string name, Color axisColor)
	{
		return null;
	}

	private Disc CreateCenterRing()
	{
		return null;
	}

	private Disc CreateCenterCore()
	{
		return null;
	}

	private GameObject CreateVisualChild(string name)
	{
		return null;
	}

	private CustomLabelDragHandleHitArea CreateHitArea(string name, CustomLabelHandleDragMode mode)
	{
		return null;
	}

	private void UpdateHitAreaLayout(float centerSize, float shaftThickness, float armLength, float arrowLength, float arrowHalfWidth)
	{
	}

	private void SetHitAreasEnabled(bool enabled)
	{
	}

	private static void ConfigureRenderState(ShapeRenderer shape)
	{
	}

	private static void ConfigureAxisLine(Line line, Vector3 start, Vector3 end, float thickness)
	{
	}

	internal void HandleHitAreaPointerDown(CustomLabelHandleDragMode mode)
	{
	}

	internal void HandleHitAreaPointerDrag()
	{
	}

	internal void HandleHitAreaPointerUp()
	{
	}
}
