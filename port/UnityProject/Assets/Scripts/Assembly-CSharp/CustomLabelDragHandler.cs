using UnityEngine;

public sealed class CustomLabelDragHandler : MonoBehaviour
{
	[SerializeField]
	private string m_Id;

	[SerializeField]
	private bool m_EnableDrag;

	private bool m_IsDragging;

	private Vector3 m_DragOffset;

	private Vector3 m_DragStartWorldPos;

	private Vector3 m_HandleAnchorDragStart;

	private CustomLabelHandleDragMode m_DragMode;

	private const float c_LabelZ = -0.61f;

	private const float c_HandleBaseSize = 3f;

	private CustomLabelDragHandleGizmo m_HandleGizmo;

	private bool m_IsHandleMode;

	public void Initialize(string _id)
	{
	}

	public void SetActiveForDrag(bool _active)
	{
	}

	public void SetHandleEditMode(bool enabled)
	{
	}

	public void UpdateHandleVisual(CustomLabelData data)
	{
	}

	private void EnsureHandleGizmo()
	{
	}

	private Vector3 ResolveHandleAnchor(CustomLabelData data)
	{
		return default;
	}

	private float CalculateHandleSize()
	{
		return 0f;
	}

	private void OnDestroy()
	{
	}

	internal void HandlePointerDown()
	{
	}

	internal void HandlePointerDown(CustomLabelHandleDragMode mode)
	{
	}

	internal void HandlePointerDrag()
	{
	}

	internal void HandlePointerUp()
	{
	}

	private void BeginDrag(CustomLabelHandleDragMode mode)
	{
	}

	private void UpdateDrag()
	{
	}

	private void EndDrag()
	{
	}

	private static bool IsPointerOverUI()
	{
		return false;
	}

	private Vector3 ApplyDragConstraint(Vector3 target)
	{
		return default;
	}

	private Vector3 GetMouseWorldOnLabelPlane()
	{
		return default;
	}
}
